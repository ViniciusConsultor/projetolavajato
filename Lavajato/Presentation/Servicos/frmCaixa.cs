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
using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmCaixa :login
    {

        public frmCaixa()
        {
            InitializeComponent();
            CarregaFormaPagamento();
            CarregaProdutos();
        }

        public frmCaixa(Servico servico)
        {
            InitializeComponent();
            _servico = servico;
            SetConfiguracaoInicial();
        }

        private void SetConfiguracaoInicial()
        {
            CarregaProdutos();
            CarregaFormaPagamento();
            ProcuraServico(_servico.OrdemServico);
            CarregaCliente(_servico);
            CarregaItens(_servico);
        
            FormataValores();
            MudaNomeDoFormulario(_servico);
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            ordemServico.Text = _servico.OrdemServico.ToString();
            ordemServico.Focus();
            CarregaConvenioDosClientes();
        }

        private void ordemServico_Leave(object sender, EventArgs e)
        {
            PesquisaOrdemServico();   
        }

        private void PesquisaOrdemServico()
        {
            try
            {
                int ordServico = int.Parse(ordemServico.Text);
                _servico = ProcuraServico(ordServico);
                CarregaCliente(_servico);
                CarregaItens(_servico);
                MudaNomeDoFormulario(_servico);
                FormataValores();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(Resources.SomenteNumeros + " " + ex.Message, Resources.Atencao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Favor preencher o campo de pesquisa!" + " " + ex.Message, Resources.Atencao);
            }
        }

        private Servico ProcuraServico(int ordemServico)
        {
            var serv = new Servico();
            if (ordemServico == 0)
            {
                MessageBox.Show(Resources.OrdemServicoNaoEncontrada + this.ordemServico.Text, "Atenção");
                return serv;
            }
            serv.OrdemServico = ordemServico;
            serv = servicoBL.ByOrdemServico(serv);
            return serv;
        }

        private void CarregaCliente(Servico servicoQueSeraCarregado)
        {
            placa.Text = servicoQueSeraCarregado.Cliente.Placa;
            veiculo.Text = servicoQueSeraCarregado.Cliente.Veiculo;
            telefone.Text = servicoQueSeraCarregado.Cliente.Telefone;
            nome.Text = servicoQueSeraCarregado.Cliente.Nome;
            corVeiculo.Text = servicoQueSeraCarregado.Cliente.Cor;
            chbLavado.Checked = Convert.ToBoolean(servicoQueSeraCarregado.Lavado);
            convenio.SelectedValue = servicoQueSeraCarregado.Cliente.Convenio.ID;
        }

        private void MudaNomeDoFormulario(Servico servico)
        {
            this.Text = " Caixa Responsável: " + _servico.Usuario.Nome + " - " +
                " Número da O.S.: " + servico.OrdemServico;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ExisteServico())
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado, Resources.Atencao);
                return;
            }

            int qtde = int.Parse(quantidade.TextLength > 0 ? quantidade.Text : "0");
            qtde = qtde > 0 ? qtde : 1;

            CriaServicoItem(qtde);
            _servico = servicoBL.ByID(_servico);
            CarregaItens(_servico);
            FormataValores();
        }

        private void CriaServicoItem(int quantidadeItens)
        {
            var item = new ServicoItem();
            item.Produto.ID = int.Parse(cmbProduto.SelectedValue.ToString());
            item.Quantidade = quantidadeItens;
            item.Servico = this._servico;
            servicoBL.ItemAdd(item);
        }

        private void btnAlterarQuantidade_Click(object sender, EventArgs e)
        {
            AlterarQuantidade();
        }

        private void AlterarQuantidade()
        {
            _servicoItem = servicoBL.ItemID(_servicoItem);
            if (_servicoItem.ID == 0)
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            frmAlterarQuantidadeItem frmAlterarQuantidade = new frmAlterarQuantidadeItem(_servicoItem);
            frmAlterarQuantidade.ShowDialog();
            _servico = servicoBL.ByID(_servico);
            CarregaItens(_servico);
            FormataValores();
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            var index = grdServico.Rows[grdServico.CurrentRow.Index].Cells[0].Value.ToString();
            index = index.Length > 0 ? index : "0";

            if (grdServico.CurrentRow != null)
                _servicoItem.ID = int.Parse(index);
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            if (!ExisteServico())
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado, Resources.Atencao);
                return;

            }

            _servico.Total = TotalServicos();
            VendaFormaPagamento frmFormaPagamento = new VendaFormaPagamento(_servico);
            frmFormaPagamento.ShowDialog();
            
            //ConcluirVenda();
            LimpaCampos();
            this.Text = "Caixa Livre ";
        }

        private void ConcluirVenda()
        {
            _servico.Finalizado = 1;
            _servico.Lavado = 1;
            _servico.Pago = 1;
            _servico.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
            _servico.Total = Dinheiro.ParseToDecimal(totalServico.Text);
            _servico.SubTotal = Dinheiro.ParseToDecimal(totalServico.Text);
            _servico.Desconto = Dinheiro.ParseToDecimal(desconto.Text);
            servicoBL.Update(_servico);

            new ClienteBL().Update(_servico.Cliente);
        }

        private void troco_TextChanged(object sender, EventArgs e)
        {
            if (!txtTrocoDoServico.Text.Contains(enter))
            {
                trocoServico = txtTrocoDoServico.Text;
            }
            else
            {
                txtTrocoDoServico.Text = trocoServico;
                btnConcluirVenda.Focus();
            }

            if (txtTrocoDoServico.Text.Contains("."))
            {
                txtTrocoDoServico.Text = txtTrocoDoServico.Text.Remove(txtTrocoDoServico.Text.Length - 1);
                txtTrocoDoServico.SelectionStart = txtTrocoDoServico.Text.Length;
            }
        }

        private void chbLavado_CheckedChanged(object sender, EventArgs e)
        {
            _servico.Lavado = Convert.ToInt32(chbLavado.Checked);
            servicoBL.CarroLavado(_servico);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!IsServicoItem())
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExcluirServicoItem();
        }

        private bool IsServicoItem()
        {
            return (_servicoItem.ID > 0);
        }

      
        
        private void acertoFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (ExisteServico())
            {
                _servico.AcertoFuturo = Convert.ToInt32(chbLavado.Checked.ToString());
                servicoBL.CarroLavado(_servico);
            }
            else
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado);
                return;
            }
        }

        private void convenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.convenio.SelectedIndex == 0 || this.convenio.SelectedIndex == -1)
            {
                desconto.Text = "";
                return;
            }

            var convenioDoCliente = new ConvenioBL().ByID(int.Parse(this.convenio.SelectedValue.ToString()));
            _servico.Cliente.Convenio = convenioDoCliente;
            desconto.Text = ValorDesconto().ToString("C").Replace("R$", "");

            new ClienteBL().Update(this._servico.Cliente);
        }

        private void CarregaConvenioDosClientes()
        {
            var convenioBl = new ConvenioBL();
            convenio.DataSource = convenioBl.GetAll();
            convenio.DisplayMember = "Nome";
            convenio.ValueMember = "ID";
        }

        private bool ExisteServico()
        {
            return servicoBL.ExisteServico(this._servico);
        }

        private Convenio SetUpConvenio()
        {
            return convenio.SelectedIndex > 0 ? new ConvenioBL().ByID(Convert.ToInt32(this.convenio.SelectedValue.ToString())) : new Convenio() { ID = 0 };
        }

        private void LimpaCampos()
        {
            placa.Clear();
            veiculo.Clear();
            telefone.Clear();
            nome.Clear();
            corVeiculo.Clear();
            ordemServico.Clear();
            valor.Text = "";
            totalServico.Clear();
            desconto.Clear();
            txtTrocoDoServico.Clear();
            _servico = new Servico();
            grdServico.DataSource = null;
        }

        private void CarregaItens(Servico servico)
        {
            grdServico.DataSource = servicoBL.CriaGrid(servico);
            FormadaGrid();
        }

        private void FormadaGrid()
        {
            grdServico.Columns[0].Visible = false;
            grdServico.Columns[1].Width = 90;
            grdServico.Columns[2].Width = 80;
            grdServico.Columns[3].Width = 70;
            grdServico.Columns[4].Width = 70;
        }

        private void FormataValores()
        {
            totalServico.Text = TotalServicos().ToString();
        }

        private void CarregaProdutos()
        {
            var produtoBl = new ProdutoBL();
            cmbProduto.DataSource = produtoBl.Categoria(EnumCategoriaProduto.Produto);
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.ValueMember = "ID";
        }

        private void CarregaFormaPagamento()
        {
            cmbFormaPagamento.DataSource = new FormaPagamentoBL().GetAll();
            cmbFormaPagamento.DisplayMember = "Descricao";
            cmbFormaPagamento.ValueMember = "ID";
        }

        private decimal ValorDesconto()
        {
            var valorTotalComDesconto = _servico.ServicoItem.Where(
                si => si.Produto.CategoriaProduto.ID == (int) EnumCategoriaProduto.Servico).Sum(
                si => si.Quantidade*si.Produto.ValorUnitario);

            if (this._servico.Cliente.Convenio.PorcentagemDesconto > 0)
            {
                var valTotal = Dinheiro.ParseToDecimal( this.totalServico.Text);
                var desc = valorTotalComDesconto * Math.Abs(this._servico.Cliente.Convenio.PorcentagemDesconto / 100);
                this.valor.Text = (valTotal - desc).ToString("C").Replace("R$", "");
                return desc;
            }
            else if (this._servico.Cliente.Convenio.Valor > 0)
            {
                return valorTotalComDesconto - this._servico.Cliente.Convenio.Valor;
            }
            return 0;
        }

        private decimal TotalServicos()
        {
            decimal totalCompra = 0;
            for (var i = 0; i < grdServico.Rows.Count - 1; i++)
                totalCompra += Dinheiro.ParseToDecimal(grdServico.Rows[i].Cells[4].Value.ToString());

            return totalCompra;
        }

        private void ExcluirServicoItem()
        {
            
            var res = MessageBox.Show(Resources.Apagar_o_item_de_pedido, Resources.Atencao, MessageBoxButtons.YesNo);
            if (res != DialogResult.No)
            {
                servicoBL.ItemDelete(_servicoItem);
                _servico = servicoBL.ByID(_servico);
                CarregaItens(_servico);     
                FormataValores();
                MessageBox.Show(Resources.Item_deletado);
                
            }
        }

        private void CriaServico()
        {
            this._servico.Cliente.ID = 72;
            this._servico.Usuario = this.Usuario;
            this._servico.Total = 0;
            this._servico.SubTotal = 0;
            this._servico.Desconto = 0;
            this._servico.Entrada = DateTime.Now;
            this._servico.Saida = DateTime.Now;
            this._servico.OrdemServico = 000;
            this._servico.FormaPagamento.ID = 1;

            this._servico.Cancelado = 0;
            this._servico.Delete = 0;
            this._servico.Finalizado = 0;
            this._servico.Lavado = 0;
            this._servico = servicoBL.Add(_servico);
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (!IsServicoItem())
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            CancelarVenda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServicoLavador servicoLavador = new frmServicoLavador(_servico);
            servicoLavador.ShowDialog();
            servicoLavador.Close();
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void CancelarVenda()
        {
            DialogResult res = MessageBox.Show(Resources.Deseja_cancelar_a_venda, Resources.Atencao,
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this._servico.Cancelado = 1;
                _servico.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
                _servico.Total = Dinheiro.ParseToDecimal(totalServico.Text);
                _servico.SubTotal = Dinheiro.ParseToDecimal(totalServico.Text);
                _servico.Desconto = Dinheiro.ParseToDecimal(desconto.Text);

                this.servicoBL.Update(this._servico);
                MessageBox.Show(Resources.Venda_cancelada, Resources.Atencao);
            }
        }

        #region Metodos Parados Temporariamente

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor.Text = "";
            switch (cmbFormaPagamento.SelectedIndex)
            {
                case 0:
                    desconto.Enabled = true;
                    break;
                default:
                    desconto.Enabled = false;
                    txtTrocoDoServico.Enabled = false;
                    valor.Text = totalServico.Text;
                    break;
            }
        }

        private void totalServico_TextChanged(object sender, EventArgs e)
        {
            FocoVaiParaValor();

            if (totalServico.Text.Contains("."))
            {
                totalServico.Text = totalServico.Text.Remove(totalServico.Text.Length - 1);
                totalServico.SelectionStart = totalServico.Text.Length;
            }
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            FocoVaiParaDesconto();

            if (valor.TextLength == 0)
            {
                txtTrocoDoServico.Text = "";
                desconto.Text = "";
                return;

            }

            if (valor.Text.Contains("."))
            {
                valor.Text = valor.Text.Remove(valor.Text.Length - 1);
                valor.SelectionStart = valor.Text.Length;
            }

            var valorTemp = valor.Text;
            decimal valorNum = 0;
            if (valorTemp.Length > 0)
                valorNum = Convert.ToDecimal(valorTemp);


            var valorTotal = totalServico.Text;
            decimal totalTemp = 0;
            if (valorTotal.Length > 0)
                totalTemp = Convert.ToDecimal(totalServico.Text);

            txtTrocoDoServico.Text = decimal.Subtract(valorNum, totalTemp).ToString();

        }

        private void desconto_TextChanged(object sender, EventArgs e)
        {
            FocoVaiParaTroco();

            if (desconto.Text.Contains("."))
            {
                desconto.Text = desconto.Text.Remove(desconto.TextLength - 1);
                desconto.SelectionStart = desconto.Text.Length;
            }

            decimal totalServicoTemp = TotalServicos();
            decimal descontoTemp = ServicoBL.ConverteParaDecimal(desconto.Text);
            if (descontoTemp == 0)
            {
                totalServico.Text = totalServicoTemp.ToString();
                valor.Text = valor.Text;
                txtTrocoDoServico.Text = "";

                return;
            }

            if (descontoTemp > totalServicoTemp)
            {
                MessageBox.Show(Resources.Desconto_maior_que_valor_produto, Resources.Atencao);
                desconto.Text = "";
            }

            var valorTemp = decimal.Subtract(totalServicoTemp, descontoTemp).ToString();

            if (valor.TextLength == 0)
            {
                totalServico.Text = (totalServicoTemp - descontoTemp).ToString();
            }

            if (!string.IsNullOrEmpty(txtTrocoDoServico.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(desconto.Text.Trim()))
                {
                    txtTrocoDoServico.Text = (ServicoBL.ConverteParaDecimal(txtTrocoDoServico.Text) - ServicoBL.ConverteParaDecimal(desconto.Text)).ToString();
                    valor.Text = valor.Text;
                    totalServico.Text = decimal.Subtract(totalServicoTemp, descontoTemp).ToString();
                }
            }
        }

        private void FocoVaiParaValor()
        {
            if (totalServico.Text.Contains(enter))
            {
                totalServico.Text = total;
                valor.Focus();
            }
            else
            {
                total = totalServico.Text;
            }
        }

        private void FocoVaiParaDesconto()
        {
            if (!valor.Text.Contains(enter))
            {
                valorServico = valor.Text;
            }
            else
            {
                valor.Text = valorServico;
                desconto.Focus();
            }
        }

        private void FocoVaiParaTroco()
        {
            if (!desconto.Text.Contains(enter))
            {
                descontoServico = desconto.Text;
            }
            else
            {
                desconto.Text = descontoServico;
                txtTrocoDoServico.Focus();
            }
        }

        #endregion

        #region Eventos Auxiliares

        private void ChamaFuncoesDeCaixa(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    PesquisaOrdemServico();
                    break;
                case Keys.F2:
                    ConcluirVenda();
                    break;
                case Keys.F3:
                    AlterarQuantidade();
                    break;
                case Keys.F4:
                    CriaServico();
                    break;
                case Keys.F5:
                    ExcluirServicoItem();
                    break;
                case Keys.F6:
                    CancelarVenda();
                    break;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordemServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void convenio_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void cmbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void quantidade_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void cmbFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void totalServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void valor_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void desconto_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        #endregion

       
    }
}
