using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.Operacional;
using System.Drawing.Printing;
using System.IO;
using HenryCorporation.Lavajato.Presentation.Properties;
using Impressao;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmOrdemServico : login
    {
        public frmOrdemServico()
        {
            InitializeComponent();
            btnCadastraCliente.Enabled = false;
            dataTable.Columns.AddRange(ServicoColunas.ServicoCarregaColunas());
            dataSetItens.Tables.Add(dataTable);
        }

        private void frmOrdemServico_Load(object sender, EventArgs e)
        {
            CarregaHora();
            CarregaProdutos();
        }

        private void placa_Leave(object sender, EventArgs e)
        {
            placa.BackColor = Color.White;
            if (Equals(placa.Text, Resources.Placa_vazia))
                return;

            Cliente cliente = CarregaInformacoesDoCliente();
            CarregaCliente(cliente);
            LiberaBotaoParaCadastroDeCliente();
            
            _servico = ServicoCarrega();
            
            ImprimeNumeroOrdemServico();
            ImprimeMensagemParaCarroJaLavado();
            
            LimpaGrid(placa.Text);
            CarregaItens(_servico);
            
            
            LiberaBotaoParaExclusaoDeItens();
        }

        private Cliente CarregaInformacoesDoCliente()
        {
            _cliente.Placa = placa.Text;
            _cliente = ProcuraCliente(this._cliente);
            return _cliente;
        }

        private void LiberaBotaoParaCadastroDeCliente()
        {
            if (_cliente.ID == 0)
            {
                var dialogResult = MessageBox.Show(Resources.Cliente_não_Cadastrado, Resources.Atencao, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    btnCadastraCliente.Enabled = true;
                    LimpaGrid();
                    return;
                }
            }
        }

        private void LimpaGrid()
        {
            dataTable = new DataTable();
            dataSetItens = new DataSet();
            dataTable.Columns.AddRange(ServicoColunas.CarregaColunasOrdemServico());
            dataSetItens.Tables.Add(dataTable);
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;
        }

        private void LimpaGrid(string placaPesquisada)
        {
            if (Equals(_cliente.Placa, placaPesquisada))
            {
                dataTable = new DataTable();
                dataSetItens = new DataSet();
                dataTable.Columns.AddRange(ServicoColunas.CarregaColunasOrdemServico());
                dataSetItens.Tables.Add(dataTable);
                grdServico.DataSource = dataSetItens.Tables[0].DefaultView;
            }
        }

        private Servico ServicoCarrega()
        {
            Servico servico = servicoBL.ByCliente(_cliente);
            if (servico.Finalizado == 0)
                return servico;
            else
                return new Servico();
        }

        private void CarroJaLavado()
        {
            if (this._servico.Finalizado == 0)
                MessageBox.Show(Resources.Ordem_de_Serviço_Aberto + _servico.OrdemServico, Resources.Atencao);
        }

        private void LiberaBotaoParaExclusaoDeItens()
        {
            btnExcluir.Enabled = this._servico.ID == 0;
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

        private void placa_TextChanged(object sender, EventArgs e)
        {
            FormataPlaca();
        }

        private void adicionarServico_Click(object sender, EventArgs e)
        {
            if (_cliente.ID == 0)
            {
                MessageBox.Show(Resources.Favor_escolher_um_cliente, Resources.Atencao);
                return;
            }
            AdicionaItem();
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            var clientePlaca = new Cliente();
            _cliente.Placa = placa.Text;
            if (clienteBL.Existe(_cliente))
            {
                MessageBox.Show(Resources.Cliente_já_existente_na_base, Resources.Atencao);
                return;
            }

            SetUpFieldsCliente();
            ClienteInsert();
            MessageBox.Show(Resources.Cliente_salvo_com_sucesso, Resources.Atencao);
            btnCadastraCliente.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var index = grdServico.Rows[_indexRow].Cells[1].Value;
            var tempIndex = index != null ? index : "";
            
            tempIndex = tempIndex.ToString().Length > 0 ? index : "0";
            if (tempIndex.Equals("0"))
            {
                MessageBox.Show("Nenhum item encontrado", "Atenção!");
                return;
            }

            var res = MessageBox.Show(Resources.Apagar_item_de_pedido, Resources.Atencao, MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                dataSetItens.Tables[0].Rows[
                   dataSetItens.Tables[0].Rows.Count != 0 ? _indexRow : 0].Delete();
                grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

                MessageBox.Show(Resources.Item_deletado, Resources.Atencao);

            }
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            _indexRow = grdServico.CurrentRow.Index;
        }

        private void btnGerarOrdemServico_Click(object sender, EventArgs e)
        {
            if (HoraEMinMaiorQueZero())
            {
                MessageBox.Show("Favor marcar hora ou minuto diferente de zero!", "Atenção!");
                return;
            }
            
            if (dataSetItens.Tables[0].Rows.Count > 0)
            {
                _servico = ServicoSalva();
                var itens = ItensParaInsercao(_servico);
                SalvaItens(itens);
                //IImprimir impressao = new ImprimirComprovantePagamento(this.servico);
                LiberaBotaoParaExclusaoDeItens();
                MessageBox.Show("Número da Ordem Serviço é: " + this._servico.OrdemServico, "Ordem Serviço");
            }
            else
            {
                MessageBox.Show("Nenhum serviço adicionado a O.S. ");
            }
        }

        private bool HoraEMinMaiorQueZero()
        {
            if (_servico.ID > 0)
            {
                double m = double.Parse(min.SelectedItem.ToString());
                double h = double.Parse(hora.SelectedItem.ToString());
                return (m == 0 && h == 0);
            }
            return false;
        }

        private Servico ServicoSalva()
        {
            if (!ServicoExiste(this._servico))
                return servicoBL.Add(NovoServico());
            else
            {
                _servico.Total = SomaTotal();
                servicoBL.Update(this._servico);
                return this._servico;
            }
        }

        private void SalvaItens(List<ServicoItem> servicoItens)
        {
            foreach (var item in servicoItens)
                this.servicoBL.ItemAdd(item);
        }
        
        private bool ServicoExiste(Servico servico)
        {
            return servico.ID > 0;
        }

        private Servico NovoServico()
        {
            var servicoSalva = new Servico();
            servicoSalva.Cliente = this._cliente;
            servicoSalva.Total = SomaTotal();
            servicoSalva.SubTotal = 0;
            servicoSalva.Desconto = 0;
            servicoSalva.Entrada = DateTime.Now;

            servicoSalva.Saida = servicoSalva.Entrada
                .AddHours(double.Parse(hora.SelectedItem.ToString()))
                .AddMinutes(double.Parse(min.SelectedItem.ToString()));
            
            servicoSalva.OrdemServico = servicoBL.OrdemServicoMax();
            servicoSalva.FormaPagamento.ID = 1;
            servicoSalva.Usuario = this.Usuario;

            servicoSalva.Cancelado = 0;
            servicoSalva.Delete = 0;
            servicoSalva.Finalizado = 0;
            servicoSalva.Lavado = 0;

            return servicoSalva;
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

            var servicoItems = new List< ServicoItem>(); 
            var idpi = new List<int>();
            foreach (DataRow row in dataSetItens.Tables[0].Rows)
            {
                var servicoItemID = int.Parse(row["ID"].ToString());
                if (!ids.Contains(servicoItemID))
                {
                    var item = new ServicoItem();
                    var produto = new Produto() { ID = int.Parse(row["ID"].ToString()) };
                    item.Produto = new ProdutoBL().ByID(produto);
                    item.Quantidade = int.Parse(row["Quantidade"].ToString());
                    item.Servico = servico;
                    servicoItems.Add(item);
                }
            }

            return servicoItems;
        }
    
        private decimal SomaTotal()
        {
            var qtdeTotal = dataSetItens.Tables[0].Rows.Cast<DataRow>().Sum(
                row => Configuracao.ConverteParaDecimal(row["Total"].ToString()));
            this._servico.Total = qtdeTotal;
            return  qtdeTotal;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            _servico = new Servico();
            _cliente = new Cliente();
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            corVeiculo.Text = "";
            dataSetItens = new DataSet();
            dataTable = new DataTable();
            dataTable.Columns.AddRange(ServicoColunas.CarregaColunasOrdemServico());
            dataSetItens.Tables.Add(dataTable);
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

        }

        private void ClienteInsert()
        {
            this._cliente = clienteBL.Insert(_cliente);
        }

        private void SetUpFieldsCliente()
        {
            this._cliente.Placa = placa.Text;
            this._cliente.Veiculo = veiculo.Text;
            this._cliente.Telefone = telefone.Text;
            this._cliente.Nome = nome.Text;
            this._cliente.Cor = corVeiculo.Text;
        }

        private void CarregaHora()
        {
            hora.Items.AddRange(Configuracao.CarregaHora());
            min.Items.AddRange(Configuracao.CarregaMinuto());
            hora.SelectedIndex = 0;
            min.SelectedIndex = 0;
        }

        private void CarregaItens(Servico servicoParaCarregarItens)
        {
            if (grdServico == null) return;

            grdServico.DataSource = CarregaItensNoGrid(servicoParaCarregarItens);
            grdServico.Columns[0].Visible = false;
            grdServico.Columns[1].Width = 150;
            grdServico.Columns[2].Width = 100;
            grdServico.Columns[3].Width = 100;
        }

        private void AdicionaItem()
        {
            var item = new Produto();
            item.ID = int.Parse(cmdServico.SelectedValue.ToString());
            item = new ProdutoBL().ByID(item);
            dataSetItens.Tables[0].Rows.Add(AdicionaLinhaDeItemAoGrid(item));
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

            grdServico.Columns[0].Visible = false;
        }

        private DataRow AdicionaLinhaDeItemAoGrid(Produto item)
        {
            var quantidadeDeItens = string.IsNullOrEmpty(quantidadeProduto.Text) ? 1 : int.Parse(quantidadeProduto.Text);

            var row = dataSetItens.Tables[0].NewRow();
            row["ID"] = item.ID;
            row["Descricao"] = item.Descricao;
            row["Quantidade"] = quantidadeDeItens;
            row["Valor"] = item.ValorUnitario.ToString("C");
            row["Total"] = (item.ValorUnitario * quantidadeDeItens).ToString("C");

            return row;
        }

        private void ItemDoServicoSalva(Servico servicoDoItem)
        {
            var item = new ServicoItem();
            item.Produto.ID = int.Parse(cmdServico.SelectedValue.ToString());
            item.Quantidade = quantidadeProduto.TextLength == 0 ? 1 : Convert.ToDecimal(quantidadeProduto.Text);
            item.Servico = servicoDoItem;
            servicoBL.ItemAdd(item);
        }

        private void FormataPlaca()
        {
            var tamanhoPlaca = placa.Text.Length - 1;
            if (Equals(tamanhoPlaca, 2))
            {
                placa.Text = placa.Text + Resources.Separador_Placa;
                placa.SelectionStart = placa.TextLength;
            }

            tamanhoPlaca = placa.Text.Length;
            var tamanhoMaximoDaPlaca = 8;
            if (Equals(tamanhoPlaca, int.Parse(Resources.Tamanho_Maximo_Placa)))
            {

                placa.Text = placa.Text.Remove(placa.Text.Length - 1);
                placa.SelectionStart = placa.TextLength;
            }
        }

        private DataTable CarregaItensNoGrid(Servico servicoParaSerCarregado)
        {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (quantidadeProduto.Text.Contains("."))
            {
                quantidadeProduto.Text = quantidadeProduto.Text.Remove(quantidadeProduto.Text.Length - 1);
                quantidadeProduto.SelectionStart = quantidadeProduto.Text.Length;
            }
        }

        private void CarregaProdutos()
        {
            cmdServico.DataSource = new ProdutoBL().TipoServico(EnumCategoriaProduto.Servico);
            cmdServico.DisplayMember = "Descricao";
            cmdServico.ValueMember = "ID";
        }


        private void CarregaCliente(Cliente cliente)
        {
            if (cliente.ID == 0)
            {
                LimparCamposCadastro();
                return;
            }

            placa.Text = _cliente.Placa;
            veiculo.Text = _cliente.Veiculo;
            telefone.Text = _cliente.Telefone;
            nome.Text = _cliente.Nome;
            corVeiculo.Text = _cliente.Cor;
        }

        private void LimparCamposCadastro()
        {
            veiculo.Clear();
            telefone.Clear();
            nome.Clear();
            corVeiculo.Clear();
        }
        
        private Cliente ProcuraCliente(Cliente clienteProcurado)
        {
            return clienteBL.ByPlaca(clienteProcurado);
        }
        
        #region "Metodos de apoio"

        
        
        private void min_Enter(object sender, EventArgs e)
        {
            min.BackColor = Color.Yellow;
        }

        private void min_Leave(object sender, EventArgs e)
        {
            min.BackColor = Color.White;
        }

        private void telefone_Enter(object sender, EventArgs e)
        {
            telefone.BackColor = Color.Yellow;
        }

        private void telefone_Leave(object sender, EventArgs e)
        {
            telefone.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            quantidadeProduto.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            quantidadeProduto.BackColor = Color.White;
        }

        private void veiculo_Enter(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.Yellow;
        }

        private void veiculo_Leave(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.White;
        }

        private void nome_Enter(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
        }

        private void nome_Leave(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
        }

        private void corVeiculo_Enter(object sender, EventArgs e)
        {
            corVeiculo.BackColor = Color.Yellow;
        }

        private void corVeiculo_Leave(object sender, EventArgs e)
        {
            corVeiculo.BackColor = Color.White;
        }

        private void dataEntrada_Enter(object sender, EventArgs e)
        {
            dataEntrada.BackColor = Color.Yellow;
        }

        private void dataEntrada_Leave(object sender, EventArgs e)
        {
            dataEntrada.BackColor = Color.White;
        }

        private void hora_Enter(object sender, EventArgs e)
        {
            hora.BackColor = Color.Yellow;
        }

        private void hora_Leave(object sender, EventArgs e)
        {
            hora.BackColor = Color.White;
        }

        private void cmdServico_Enter(object sender, EventArgs e)
        {
            cmdServico.BackColor = Color.Yellow;
        }

        private void cmdServico_Leave(object sender, EventArgs e)
        {
            cmdServico.BackColor = Color.White;
        }

        private void placa_Enter_1(object sender, EventArgs e)
        {
            placa.BackColor = Color.Yellow;
        }

        #endregion

        private void placa_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

        }
    }
}
