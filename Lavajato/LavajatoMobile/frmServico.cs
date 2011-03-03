using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LavajatoMobile.WSLavajato;
using Impressao;

namespace LavajatoMobile
{
    public partial class frmServico : Form
    {
        private WSLavajato.Cliente _cliente = new LavajatoMobile.WSLavajato.Cliente();
        private WSLavajato.Servico _servico = new LavajatoMobile.WSLavajato.Servico();
        private WSLavajato.ServicoItem _servicoItem = new LavajatoMobile.WSLavajato.ServicoItem();
        private WSLavajato.WebServiceLavajato wsService = new LavajatoMobile.WSLavajato.WebServiceLavajato();

        private DataSet dataSetItens = new DataSet();
        private DataTable dataTable = new DataTable();
        private DateTime _dataSaida;
        private int _indexRow;

        public frmServico()
        {
            InitializeComponent();
            CarregaProdutos();
        }

        private void CarregaProdutos()
        {
            cmdServico.DisplayMember = "Descricao1";
            cmdServico.ValueMember = "ProdutoID";
            cmdServico.DataSource = wsService.Categoria(2);

        }

        public frmServico(Cliente cliente, DateTime saida)
        {
             InitializeComponent();
             CarregaProdutos();
             SetUpDataSet();

            _cliente = cliente;
            _dataSaida = saida;
            
            _servico = ServicoCarrega();

            ImprimeNumeroOrdemServico();
            ImprimeMensagemParaCarroJaLavado();

            CarregaItens(_servico);

        }

        private void SetUpDataSet()
        {
            dataTable.Columns.AddRange(ServicoColunas.CarregaColunasServico());
            dataSetItens.Tables.Add(dataTable);
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
        }

        private void CarregaItens(Servico servicoParaCarregarItens)
        {
            if (grdServico == null) return;

            grdServico.DataSource = CarregaItensNoGrid(servicoParaCarregarItens);
            grdServico.TableStyles.Clear();
            grdServico.TableStyles.Add(ServicoBL.SetUpStyleGrid(dataSetItens));
        }

        private DataTable CarregaItensNoGrid(Servico servicoParaSerCarregado)
        {

            if (_servico == null || _servico.ServicoItem == null)
                return new DataTable();

            foreach (var si in servicoParaSerCarregado.ServicoItem)
            {
                var row = dataTable.NewRow();
                row["ID"] = si.ID;
                row["Descricao"] = si.Produto.Descricao;
                row["Quantidade"] = si.Quantidade;
                row["Valor"] = si.Produto.ValorUnitario.ToString("C");
                row["Total"] = (si.Produto.ValorUnitario * si.Quantidade).ToString("C");
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        private Servico ServicoCarrega()
        {
            Servico servico = wsService.ByCliente(_cliente);
            if (servico.Finalizado == 0)
                return servico;
            else
                return new Servico();
        }

        private void ImprimeNumeroOrdemServico()
        {
            if (_servico.Finalizado == 0 && _servico.ID > 0)
                MessageBox.Show("Número da Ordem Serviço: " + this._servico.OrdemServico, "Atenção");
        }

        private void ImprimeMensagemParaCarroJaLavado()
        {
            if (this._servico.Lavado > 0)
                MessageBox.Show("Carro já lavado", "Atenção");
        }

        private void LimpaGrid()
        {
            dataTable = new DataTable();
            dataSetItens = new DataSet();
            dataTable.Columns.AddRange(ServicoColunas.CarregaColunasServico());
            dataSetItens.Tables.Add(dataTable);
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;
        }

        private void LimpaGrid(string placaPesquisada)
        {
            if (Equals(_cliente.Placa, placaPesquisada))
            {
                dataTable = new DataTable();
                dataSetItens = new DataSet();
                dataTable.Columns.AddRange(ServicoColunas.CarregaColunasServico());
                dataSetItens.Tables.Add(dataTable);
                grdServico.DataSource = dataSetItens.Tables[0].DefaultView;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataSetItens.Tables[0].Rows.Count > 0)
            {

                DialogResult res = MessageBox.Show("Deseja realmente apagar o item de pedido", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                if (res == DialogResult.Yes)
                {
                    dataSetItens.Tables[0].Rows[grdServico.CurrentRowIndex].Delete();
                    grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

                    MessageBox.Show("Item Deletado", "Atenção!");
                }
            }
        }

        private void grdServico_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                if (grdServico.CurrentRowIndex <= -1)
                return;

            id = int.Parse(ServicoBL.CriaGrid(_servico).Rows[grdServico.CurrentRowIndex]["ID"].ToString());
            
            }
            catch (IndexOutOfRangeException)
            {
                id = 0;    
            }
        }

        private void ItemDoServicoSalva(Servico servico)
        {
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto = new Produto() { ID = ((Produto)cmdServico.SelectedItem).ID };
            servicoItem.Quantidade = qtde.TextLength == 0 ? 1 : Convert.ToDecimal( qtde.Text);
            servicoItem.Servico = servico;
            wsService.ServicoItemAdd(servicoItem);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (dataSetItens.Tables[0].Rows.Count > 0)
            {
                _servico = ServicoSalva();
                var itens = ItensParaInsercao(_servico);
                SalvaItens(itens);
                wsService.EmiteRecibo(_servico);
                MessageBox.Show("Número da O. S.: " + this._servico.OrdemServico, "Ordem Serviço");
            }
            else
            {
                MessageBox.Show("Nenhum serviço adicionado a O.S. ");
            }

            this.Close();
        }

        //Caso o item já exista no bd não será necessario inserilo novamente
        //criar um novo lista somente com os existentes.
        //criar metodo somente para inserção passando o list
        private List<ServicoItem> ItensParaInsercao(Servico servico)
        {
            IList<int> ids = new List<int>();
            foreach (DataRow row in dataSetItens.Tables[0].Rows)
            {
                var ID = int.Parse(row["ID"].ToString());
                foreach (ServicoItem si in servico.ServicoItem)
                {
                    if (ID == si.ID)
                        ids.Add(ID);
                }
            }

            var servicoItems = new List<ServicoItem>();
            var idpi = new List<int>();
            foreach (DataRow row in dataSetItens.Tables[0].Rows)
            {
                var servicoItemID = int.Parse(row["ID"].ToString());
                if (!ids.Contains(servicoItemID))
                {
                    var item = new ServicoItem();
                    var produto = new Produto() { ID = int.Parse(row["ID"].ToString()) };
                    item.Produto = wsService.ProdutoByID(produto);
                    item.Quantidade = int.Parse(row["Quantidade"].ToString());
                    item.Servico = servico;
                    servicoItems.Add(item);
                }
            }

            return servicoItems;
        }

        private void SalvaItens(List<ServicoItem> servicoItens)
        {
            foreach (var item in servicoItens)
                wsService.ServicoItemAdd(item);
        }

        private void btnAdicionaProduto_Click(object sender, EventArgs e)
        {
            if (_cliente.ID == 0)
            {
                MessageBox.Show("Favor retornar e escolher um cliente valido", "Atenção!");
                return;
            }

            AdicionaItem();
        }

        private void AdicionaItem()
        {
            Produto produto = SetProduto();
            dataSetItens.Tables[0].Rows.Add(AdicionaLinhaDeItemAoGrid(produto));
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

        }

        private Produto SetProduto()
        {
            Produto produto = new Produto();
            produto.ID = int.Parse(cmdServico.SelectedValue.ToString());
            produto = wsService.ProdutoByID(produto);
            return produto;
        }

        private DataRow AdicionaLinhaDeItemAoGrid(Produto item)
        {
            var quantidadeDeItens = string.IsNullOrEmpty(qtde.Text) ? 1 : int.Parse(qtde.Text);

            var row = dataSetItens.Tables[0].NewRow();
            row["ID"] = item.ID;
            row["Descricao"] = item.Descricao;
            row["Quantidade"] = quantidadeDeItens;
            row["Valor"] = item.ValorUnitario.ToString("C");
            row["Total"] = (item.ValorUnitario * quantidadeDeItens).ToString("C");

            return row;
        }

        private Servico ServicoSalva()
        {
            if (!ServicoExiste(_servico))
                return wsService.ServicoAdd(NovoServico());
            else
            {
                _servico.Total = SomaTotal();
                wsService.ServicoUpdate(_servico);
                return this._servico;
            }
        }

        private Servico NovoServico()
        {
            var servicoSalva = new Servico();
            servicoSalva.Cliente = this._cliente;
            servicoSalva.Total = SomaTotal();
            servicoSalva.SubTotal = 0;
            servicoSalva.Desconto = 0;
            servicoSalva.Entrada = DateTime.Now;

            servicoSalva.Saida = _dataSaida;

            servicoSalva.FormaPagamento = new FormaPagamento();
            servicoSalva.FormaPagamento.ID = 1;

            servicoSalva.Usuario = new Usuario();
            servicoSalva.Usuario.ID = 26;

            servicoSalva.Cancelado = 0;
            servicoSalva.Delete = 0;
            servicoSalva.Finalizado = 0;
            servicoSalva.Lavado = 0;

            return servicoSalva;
        }

        private decimal SomaTotal()
        {
            decimal total = 0;
            foreach (DataRow item in dataSetItens.Tables[0].Rows)
                total += decimal.Parse(item["Total"].ToString().Replace("$", "").Replace("R$", "").Replace(",", ".").Trim());

            lblTotal.Text = "R$ " + total.ToString();
            return total;
        }

        private bool ServicoExiste(Servico servico)
        {
            return servico.ID > 0;
        }

        private void btnAvarias_Click(object sender, EventArgs e)
        {
            frmAvarias frmAvarias = new frmAvarias();
            frmAvarias.ShowDialog();
        }

    }
}