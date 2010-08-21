using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LavajatoMobile.WSLavajato;

namespace LavajatoMobile
{
    public partial class frmServico : Form
    {
        private WSLavajato.Cliente cliente = new LavajatoMobile.WSLavajato.Cliente();
        private WSLavajato.Servico servico = new LavajatoMobile.WSLavajato.Servico();
        private WSLavajato.ServicoItem servicoItem = new LavajatoMobile.WSLavajato.ServicoItem();
        private WSLavajato.Service wsService = new LavajatoMobile.WSLavajato.Service();
        private DataSet dataSet = new DataSet();
        private DataTable table = new DataTable();

        public frmServico()
        {
            InitializeComponent();
            CarregaProdutos();
        }

        private DateTime dataEntrada;
        private DateTime dataSaida;
        public frmServico(Cliente cliente, DateTime entrada, DateTime saida)
        {

            InitializeComponent();
            this.cliente = cliente;
            dataEntrada = entrada;
            dataSaida = saida;

            SetUpDataSet();
            CarregaProdutos();
            SetUpServico(this.cliente);
            ExistePedidos(this.servico);
            //CarregaItensDoServico(this.servico);
        }

        private void ExistePedidos(Servico servico)
        {
            if (this.servico.ID > 0 && this.servico.ServicoItem.Count() > 0)
                MessageBox.Show("Ordem de serviço já emitida" + servico.OrdemServico);
            else
                MessageBox.Show("Escolha os produtos para adicionar o serviço", "Atenção");
        }

        private void SetUpDataSet()
        {
            dataSet.Tables.Add(table);
            dataSet.Tables[0].Columns.AddRange(CarregaColunas());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.servico.ID == 0)
            {
                MessageBox.Show("Nenhum item encontrado!", "Atenção");
                return;
            }

            DialogResult res = MessageBox.Show("Deseja realmente apagar o item de pedido", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No)
            {
                return;
            }

            wsService.ServicoItemDelete(this.servicoItem);
            MessageBox.Show("Item deletado com sucesso!", "Atenção");
            CarregaItensDoServico();
            CarregaItensDoServico(this.servico);
        }

        private void grdServico_Click(object sender, EventArgs e)
        {
            if (grdServico.CurrentRowIndex <= -1)
                return;

            int id = int.Parse(wsService.ServicoCriaGrid(this.servico).Rows[grdServico.CurrentRowIndex]["ID"].ToString());
            this.servicoItem.ID = id;
        }

        private void ItemDoServicoSalva(Servico servico)
        {
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto = new Produto() { ID = ((Produto)cmdServico.SelectedItem).ID };
            servicoItem.Quantidade = qtde.TextLength == 0 ? 1 : Convert.ToDecimal( qtde.Text);
            servicoItem.Servico = servico;
            wsService.ServicoItemAdd(servicoItem);
        }

        private void ItemDoServicoSalva2(Servico servico)
        {
            Produto produto = ((Produto)cmdServico.SelectedItem); 
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto = produto;
            servicoItem.Quantidade = qtde.TextLength == 0 ? 1 : Convert.ToDecimal(qtde.Text);
            servicoItem.Servico = servico;
            CriaGrid(servicoItem);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in this.dataSet.Tables[0].Rows)
            {
                ServicoItem si = new ServicoItem();
                si.Produto = new Produto();
                si.Servico = new Servico();
                si.Produto.ID = int.Parse(row[0].ToString());
                si.Servico.ID = int.Parse(row[1].ToString());
                si.Quantidade = int.Parse(row[3].ToString());
                wsService.ServicoItemAdd(si);
               
            }
           
            this.servico = wsService.ServicoByID(this.servico);
            int impressao = wsService.EmiteRecibo(this.servico, frmAvarias.Avarias); 
            if (impressao == 0)
                MessageBox.Show("Erro ao imprimir, favor imprimir pelo Desktop", "Atenção");
            else
                MessageBox.Show("Ticket Impressoo", "Atenção");

            DialogResult result = MessageBox.Show("Deseja imprimir outro ticket ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                impressao = wsService.EmiteRecibo(this.servico, frmAvarias.Avarias);
            
            this.Close();
        }

        private void btnAdicionaProduto_Click(object sender, EventArgs e)
        {
            if (this.cliente.ID == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Atenção");
                return;
            }

            if (this.servico.ID == 0)
            {
                this.servico = ServicoSalva();
                ItemDoServicoSalva2(this.servico);
            }
            else
            {
                ItemDoServicoSalva2(this.servico);
            }

            // CarregaItensDoServico2();
            CarregaItensDoServico2(this.servico);
        }
      
        private void CarregaItensDoServico(Servico servico)
        {
            table = wsService.ServicoCriaGrid(this.servico);
            grdServico.DataSource = table;

            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = table.TableName;

            DataGridColumnStyle id = new DataGridTextBoxColumn();
            id.MappingName = "ID";
            id.Width = -1;
            ts1.GridColumnStyles.Add(id);

            DataGridColumnStyle desc = new DataGridTextBoxColumn();
            desc.MappingName = "Descricao";
            desc.HeaderText = "Desc.";
            desc.Width = 70;
            ts1.GridColumnStyles.Add(desc);

            DataGridColumnStyle qtde = new DataGridTextBoxColumn();
            qtde.MappingName = "Quantidade";
            qtde.HeaderText = "Qt";
            qtde.Width = 22;
            ts1.GridColumnStyles.Add(qtde);

            DataGridColumnStyle val = new DataGridTextBoxColumn();
            val.MappingName = "Valor";
            val.HeaderText = "Valor";
            val.Width = 56;
            ts1.GridColumnStyles.Add(val);

            DataGridColumnStyle tot = new DataGridTextBoxColumn();
            tot.MappingName = "Total";
            tot.HeaderText = "Total";
            tot.Width = 56;
            ts1.GridColumnStyles.Add(tot);

            grdServico.TableStyles.Clear();
            grdServico.TableStyles.Add(ts1);
            SomaTotal();
        }

        public void CriaGrid(ServicoItem servicoItem)
        {
            DataRow row = this.dataSet.Tables[0].NewRow();
            //row["ID"] = servicoItem.ID;
            row["ProdutoID"] = servicoItem.Produto.ID;
            row["ServicoID"] = servicoItem.Servico.ID;
            row["Descricao"] = servicoItem.Produto.Descricao;
            row["Quantidade"] = servicoItem.Quantidade;
            row["Valor"] = servicoItem.Produto.ValorUnitario.ToString("C");
            row["Total"] = (servicoItem.Produto.ValorUnitario * servicoItem.Quantidade).ToString("C");
            this.dataSet.Tables[0].Rows.Add(row);
        }

        private DataColumn[] CarregaColunas()
        {
            DataColumn[] columns = new DataColumn[6];

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            //DataColumn ID = new DataColumn();
            //ID.ColumnName = "ID";
            //columns[0] = ID;

            DataColumn produtoID = new DataColumn();
            produtoID.ColumnName = "ProdutoID";
            columns[0] = produtoID;

            DataColumn servicoid = new DataColumn();
            servicoid.ColumnName = "ServicoID";
            columns[1] = servicoid;


            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Descricao";
            columns[2] = Descricao;

            DataColumn Quantidade = new DataColumn();
            Quantidade.ColumnName = "Quantidade";
            columns[3] = Quantidade;

            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Valor";
            columns[4] = Valor;

            DataColumn Total = new DataColumn();
            Total.ColumnName = "Total";
            columns[5] = Total;
            return columns;
        }

        private Servico ServicoSalva()
        {
            Servico servico = new Servico();
            servico.Cliente = this.cliente;
            servico.Total = 0;
            servico.SubTotal = 0;
            servico.Desconto = 0;
            servico.Entrada =this.dataEntrada;
            servico.Saida = this.dataSaida;
            servico.FormaPagamento = new FormaPagamento() { ID = 1 };
            servico.Usuario = new Usuario() { ID = 26 };

            servico.Cancelado = 0;
            servico.Delete = 0;
            servico.Finalizado = 0;
            servico.Lavado = 0;

            return wsService.ServicoAdd(servico);
        }


        private void CarregaItensDoServico2(Servico servico)
        {
            grdServico.DataSource = this.dataSet.Tables[0].DefaultView;

            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = this.dataSet.Tables[0].TableName;

            //DataGridColumnStyle id = new DataGridTextBoxColumn();
            //id.MappingName = "ID";
            //id.Width = -1;
            //ts1.GridColumnStyles.Add(id);

            DataGridColumnStyle produtoid = new DataGridTextBoxColumn();
            produtoid.MappingName = "ProdutoID";
            produtoid.Width = -1;
            ts1.GridColumnStyles.Add(produtoid);

            DataGridColumnStyle servicoid = new DataGridTextBoxColumn();
            servicoid.MappingName = "ServicoID";
            servicoid.Width = -1;
            ts1.GridColumnStyles.Add(servicoid);


            DataGridColumnStyle desc = new DataGridTextBoxColumn();
            desc.MappingName = "Descricao";
            desc.HeaderText = "Desc.";
            desc.Width = 70;
            ts1.GridColumnStyles.Add(desc);

            DataGridColumnStyle qtde = new DataGridTextBoxColumn();
            qtde.MappingName = "Quantidade";
            qtde.HeaderText = "Qt";
            qtde.Width = 22;
            ts1.GridColumnStyles.Add(qtde);

            DataGridColumnStyle val = new DataGridTextBoxColumn();
            val.MappingName = "Valor";
            val.HeaderText = "Valor";
            val.Width = 56;
            ts1.GridColumnStyles.Add(val);

            DataGridColumnStyle tot = new DataGridTextBoxColumn();
            tot.MappingName = "Total";
            tot.HeaderText = "Total";
            tot.Width = 56;
            ts1.GridColumnStyles.Add(tot);

            grdServico.TableStyles.Clear();
            grdServico.TableStyles.Add(ts1);
            SomaTotal();
        }

        private void SetUpServico(Cliente cliente)
        {
            this.servico = wsService.ServicoByCliente(cliente);
        }

        private void CarregaItensDoServico()
        {
            this.servico = wsService.ServicoByID(this.servico);
        }      

        private void SomaTotal()
        {
            decimal total = 0;
            foreach (DataRow item in this.dataSet.Tables[0].Rows)
                total += decimal.Parse(item["Total"].ToString().Replace("R$", "").Replace("$", "").Replace(",", ".").Trim());

            lblTotal.Text = "R$ " + total.ToString();
        }

        private void CarregaProdutos()
        {
            cmdServico.DataSource = wsService.ProdutoTipo(2);
            cmdServico.DisplayMember = "Descricao";
            cmdServico.ValueMember = "ID";
        }

        private void btnAvarias_Click(object sender, EventArgs e)
        {
            frmAvarias frmAvarias = new frmAvarias();
            frmAvarias.ShowDialog();
        }
    }
}