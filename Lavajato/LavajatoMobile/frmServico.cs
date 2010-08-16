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

        public frmServico(Cliente cliente, DateTime entrada, DateTime saida)
        {
        
            InitializeComponent();

            this.cliente = cliente;
            this.servico.Entrada = entrada;
            this.servico.Saida = saida;

            SetUpDataSet();
            CarregaProdutos();
            SetUpServico(this.cliente);
            // MensagemSeExistePedidos(this.servico);
            CarregaItensDoServico(this.servico);
        }

        private void MensagemSeExistePedidos(Servico servico)
        {

            this.servico = wsService.ServicoByID(servico);
            if (servico.ID == 0)
                return;

            MessageBox.Show("Pedido número " + servico.OrdemServico);
        }

        private void SetUpDataSet()
        {
            dataSet.Tables.Add(table);
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
            servicoItem.Quantidade = 1;
            servicoItem.Servico = servico;
            wsService.ServicoItemAdd(servicoItem);
        }

        private Servico ServicoSalva()
        {
            Servico servico = new Servico();
            servico.Cliente = this.cliente;
            servico.Total = 0;
            servico.SubTotal = 0;
            servico.Desconto = 0;
            servico.OrdemServico = this.cliente.ID;
            servico.FormaPagamento = new FormaPagamento() { ID = 1 };
            servico.Usuario = new Usuario() { ID = 26 };

            servico.Cancelado = 0;
            servico.Delete = 0;
            servico.Finalizado = 0;
            servico.Lavado = 0;

            return wsService.ServicoAdd(servico);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int impressao = wsService.EmiteRecibo(this.servico);
            if (impressao == 0)
                MessageBox.Show("Erro ao imprimir, favor imprimir pelo Desktop", "Atenção");
            else
                MessageBox.Show("Ticket Impressoo", "Atenção");

            DialogResult result = MessageBox.Show("Deseja imprimir outro ticket ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                impressao = wsService.EmiteRecibo(this.servico);
                if (impressao == 0)
                    MessageBox.Show("Erro ao imprimir, favor imprimir pelo Desktop", "Atenção");
                else
                    MessageBox.Show("Ticket Impressoo", "Atenção");
            }

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
                ItemDoServicoSalva(this.servico);
            }
            else
            {
                ItemDoServicoSalva(this.servico);
            }
            CarregaItensDoServico();
            CarregaItensDoServico(this.servico);
        }

        private void CarregaItensDoServico()
        {
            this.servico = wsService.ServicoByID(this.servico);
        }

        private void SomaTotal()
        {
            decimal total = 0;
            foreach (DataRow item in table.Rows)
                total += decimal.Parse( item["Total"].ToString().Replace("R$", "").Replace(",", ".").Trim());

            lblTotal.Text = "R$ "+ total.ToString();
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

        private void SetUpServico(Cliente cliente)
        {
            this.servico = wsService.ServicoByCliente(cliente);
        }

        private void CarregaProdutos()
        {
            cmdServico.DataSource = wsService.ProdutoTipo(2);
            cmdServico.DisplayMember = "Descricao";
            cmdServico.ValueMember = "ID";
        }

        private void frmServico_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }


    }
}