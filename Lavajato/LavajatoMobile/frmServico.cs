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
        private WSLavajato.Cliente _cliente = new LavajatoMobile.WSLavajato.Cliente();
        private WSLavajato.Servico _servico = new LavajatoMobile.WSLavajato.Servico();
        private WSLavajato.ServicoItem _servicoItem = new LavajatoMobile.WSLavajato.ServicoItem();
        private WSLavajato.WebServiceLavajato wsService = new LavajatoMobile.WSLavajato.WebServiceLavajato();

        private DataSet dataSetItens = new DataSet();
        private DataTable dataTable = new DataTable();
        private DateTime _dataSaida;

        public frmServico()
        {
            InitializeComponent();
            CarregaProdutos();
        }

        public frmServico(Cliente cliente, DateTime saida)
        {
             InitializeComponent();
             CarregaProdutos();
             SetUpDataSet();

            _cliente = cliente;
            _dataSaida = saida;
            
            _servico = ServicoBL.ServicoCarrega(_cliente);

            ServicoBL.ImprimeNumeroOrdemServico(_servico);
            ServicoBL.ImprimeMensagemParaCarroJaLavado(_servico);

            CarregaItens(_servico);

        }

        public frmServico(Servico servico)
        {
            InitializeComponent();
            CarregaProdutos();
            SetUpDataSet();

            _cliente = servico.Cliente;
            
            _servico = ServicoBL.ServicoJaFinalizado(servico);

            //ServicoBL.ImprimeNumeroOrdemServico(_servico);
            ServicoBL.ImprimeMensagemParaCarroJaLavado(_servico);

            CarregaItens(_servico);
            lblTotal.Text = "R$ " + SomaTotal();

        }

        private void CarregaItens(Servico servicoParaCarregarItens)
        {
            if (grdServico == null) return;

            grdServico.DataSource = CarregaItensNoGrid(servicoParaCarregarItens);
            grdServico.TableStyles.Clear();
            grdServico.TableStyles.Add(ServicoBL.SetUpStyleGrid(dataSetItens));
        }

        private void SetUpDataSet()
        {
            dataTable.Columns.AddRange(ServicoColunas.CarregaColunasServico());
            dataSetItens.Tables.Add(dataTable);
        }

        private void CarregaProdutos()
        {
            cmdServico.DisplayMember = "Descricao1";
            cmdServico.ValueMember = "ProdutoID";
            cmdServico.DataSource = wsService.ByCategoria(2);

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
            if (dataSetItens.Tables[0].Rows.Count > 0)
            {
                if (grdServico.CurrentRowIndex == null)
                    return;

                DataRow row = dataSetItens.Tables[0].Rows[grdServico.CurrentRowIndex];
                int itemID = int.Parse(row["ID"].ToString());
                bool itemDel = true;
                foreach (var item in _servico.ServicoItem)
                {
                    if (item.ID == itemID)
                    {
                        itemDel = false;
                        break;
                    }
                }

                if (itemDel)
                {
                    DialogResult res = MessageBox.Show("Deseja realmente apagar o item de pedido", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        dataSetItens.Tables[0].Rows[grdServico.CurrentRowIndex].Delete();
                        grdServico.DataSource = dataSetItens.Tables[0].DefaultView;
                    }
                }
                else
                {
                    MessageBox.Show("Impossível excluir, chame o responsável", "Atenção");
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

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (dataSetItens.Tables[0].Rows.Count > 0)
            {
                _servico.Total = SomaTotal();
                _servico.SubTotal = _servico.Total;
                _servico.Cliente = _cliente;
                _servico = ServicoBL.ServicoSalva(_servico);
                
                var itens = ItensParaInsercao(_servico);
                SalvaItens(itens);

                _servico = wsService.ServicoByID(_servico);

                //imprime recibo
                ServicoBL.ImpressaoDeRecibo(_servico); 
                MessageBox.Show("Número da O. S.: " + this._servico.OrdemServico, "Ordem Serviço");
            }
            else
            {
                MessageBox.Show("Nenhum serviço adicionado a O.S. ");
                return;
            }

            this.Close();
        }

        private void AdicionaItemAoServico(List<ServicoItem> itens)
        {
            ServicoItem[] back = _servico.ServicoItem;

            _servico.ServicoItem = 
                new ServicoItem[_servico.ServicoItem.Count() + itens.Count];
            itens.AddRange(back);

            int i =0;
            foreach (ServicoItem item in itens)
            {
                _servico.ServicoItem[i] = item;
                i++;
            }
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
            if (_servico.Cliente.ID == 0)
            {
                MessageBox.Show("Favor retornar e escolher um cliente valido", "Atenção!");
                return;
            }

            AdicionaItem();
            lblTotal.Text = "R$ " + SomaTotal();
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

        
        private decimal SomaTotal()
        {
            decimal total = 0;
            foreach (DataRow item in dataSetItens.Tables[0].Rows)
            {
                string tot = item["Total"].ToString();
                tot = tot.Replace("R", "");
                tot = tot.Replace("$", "");
                total += decimal.Parse(tot.Trim());
            }
            
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}