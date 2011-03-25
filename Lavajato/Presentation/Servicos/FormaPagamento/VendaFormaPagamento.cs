using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Operacional;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class VendaFormaPagamento : Form
    {
        private Servico _servico;
        private decimal _totalBakup = 0;
        private int _indexDesconto = 10000;


        private void VendaFormaPagamento_Load(object sender, EventArgs e)
        {
            CarregaFormaPagamento();
            SetUpTotal();
        }

        public VendaFormaPagamento(Servico servico)
        {
            InitializeComponent();
            _servico = servico;
            _totalBakup = servico.Total;
            ShowAllConvenios();
        }

        private void ShowAllConvenios()
        {

            ConvenioBL convenioBl = new ConvenioBL();
            convenio.DataSource = convenioBl.GetAll();
            convenio.DisplayMember = "Nome";
            convenio.ValueMember = "ID";
        }

        private void SetUpTotal()
        {
            lblVenda.Text = _servico.Total.ToString("C");
            txtTotalPagamento.Text = _servico.Total.ToString("C");
        }

        private Servico SetUpServico()
        {
            _servico.Finalizado = 1;
            _servico.Lavado = 1;
            _servico.Pago = 1;
            _servico.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
            _servico.Total = Configuracao.ConverteParaDecimal(Dinheiro.WithdrawDollar(txtTotalPagamento.Text));
            _servico.SubTotal = Configuracao.ConverteParaDecimal(Dinheiro.WithdrawDollar(txtTotalPagamento.Text));
            _servico.Desconto = Configuracao.ConverteParaDecimal(Dinheiro.WithdrawDollar(txtDesconto.Text));
            
            return _servico;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaFormaPagamento()
        {
            cmbFormaPagamento.DataSource = new FormaPagamentoBL().GetAll();
            cmbFormaPagamento.DisplayMember = "Descricao";
            cmbFormaPagamento.ValueMember = "ID";
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            frmLoginFechamentoDeCaixa frmLoginFechamentoDeCaixa = null;
            if (txtDesconto.TextLength > 0)
            {
                frmLoginFechamentoDeCaixa = new frmLoginFechamentoDeCaixa();
                frmLoginFechamentoDeCaixa.ShowDialog();

                if (!frmLoginFechamentoDeCaixa.User.TipoFuncionario.Descricao.Contains("Gerente"))
                {
                    MessageBox.Show("Você não tem permissão para dar desconto, favor entrar em contato com o Gerente!", "Atenção!!");
                    return;
                }
            }

            Pagamento pagamento = SetUpPagamento();
            pagamento.UsuarioDesconto = frmLoginFechamentoDeCaixa == null ? new Usuario() : frmLoginFechamentoDeCaixa.User;
            _servico = SetUpServico();

            ServicoBL servicoBL = new ServicoBL();
            servicoBL.Update(_servico);
            servicoBL.InsertPagamento(pagamento);
            MessageBox.Show("Venda Realizada com Sucesso!", "Atenção");
            this.Close();

        }

        private Pagamento SetUpPagamento()
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Servico = _servico;
            pagamento.Total = Dinheiro.WithdrawDollar(Dinheiro.ParseToDecimal(txtTotalPagamento.Text));
            pagamento.Desconto = Dinheiro.ParseToDecimal(txtDesconto.Text);
            pagamento.Dinheiro = Dinheiro.ParseToDecimal(txtDinheiro.Text);
            pagamento.Cartao = Dinheiro.ParseToDecimal(txtCartaoValor.Text);
            pagamento.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
            return pagamento;
        }

        private decimal TotalDinheiroMaisCartao()
        {
            return decimal.Add(
                Dinheiro.ParseToDecimal(txtDinheiro.Text), 
                Dinheiro.ParseToDecimal(txtCartaoValor.Text)); 
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPagamento.Text.Contains("."))
            {
                txtTotalPagamento.Text = txtTotalPagamento.Text.Remove(txtTotalPagamento.Text.Length - 1);
                txtTotalPagamento.SelectionStart = txtTotalPagamento.Text.Length;
            }

            SetUpDesconto();
        }

        private void txtCartaoValor_TextChanged(object sender, EventArgs e)
        {
            if (txtCartaoValor.Text.Contains("."))
            {
                txtCartaoValor.Text = txtCartaoValor.Text
                    .Remove(txtCartaoValor.Text.Length - 1);

                txtCartaoValor.SelectionStart = txtCartaoValor.Text.Length;
            }

            SetUpDesconto();
        }

        private void SetUpDesconto()
        {
            if (TotalDinheiroMaisCartao() > _servico.Total)
            {
                txtTroco.Text = Dinheiro.Subtract(TotalDinheiroMaisCartao(), _servico.Total);
            }
            else
            {
                txtTroco.Text = string.Empty;
            }
        }


        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            decimal somaDinheiroCartao = TotalDinheiroMaisCartao();

            if (txtDesconto.Text.Contains("."))
            {
                txtDesconto.Text = txtDesconto.Text
                    .Remove(txtDesconto.Text.Length - 1);

                txtDesconto.SelectionStart = txtDesconto.Text.Length;
            }
            else if (txtDesconto.TextLength == 0)
            {
                if (TotalDinheiroMaisCartao() > _servico.Total)
                {
                    txtTroco.Text = Dinheiro.Subtract(somaDinheiroCartao, _servico.Total)   ;
                    txtTotalPagamento.Text = Dinheiro.WithDollar(_servico.Total);
                    lblVenda.Text = Dinheiro.WithDollar( _servico.Total);
                }
                else
                {
                    txtTroco.Text = string.Empty;
                    txtTotalPagamento.Text = Dinheiro.WithDollar( _servico.Total);
                }
            }

            decimal desconto = Dinheiro.ParseToDecimal(txtDesconto.Text);
            if (somaDinheiroCartao >= desconto)
            {
                if (txtDesconto.TextLength > 0)
                {
                    txtTotalPagamento.Text = Dinheiro.WithDollar(_servico.Total - desconto);

                    txtTroco.Text = Dinheiro.Subtract(
                        somaDinheiroCartao,
                        Dinheiro.ParseToDecimal(txtTotalPagamento.Text)
                        );
                }

            }


        }

        private decimal CalculaDesconto()
        {
            return Dinheiro.Subtract(
                TotalDinheiroMaisCartao().ToString(),
                txtDesconto.Text
                );
        }

        private void convenio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (convenio.SelectedIndex == 0)
            {
                txtTotalPagamento.Text = Dinheiro.WithDollar(_totalBakup);
                _servico.Total = _totalBakup;
                return;
            }

            if (_indexDesconto == convenio.SelectedIndex)
            {
                _indexDesconto = convenio.SelectedIndex;
                return;
            }

            decimal total = _totalBakup;
            int convID = int.Parse(this.convenio.SelectedValue.ToString());

            Convenio conv = new ConvenioBL().ByID(new Convenio() { ID = convID });
            if (conv.Valor > 0)
            {
                txtTotalPagamento.Text = Dinheiro.WithDollar(Dinheiro.Subtract(
                    total.ToString(),
                    conv.Valor.ToString())
                    );
                _servico.Total = Dinheiro.ParseToDecimal(Dinheiro.WithdrawDollar(txtTotalPagamento.Text));
            }
            else
            {
                decimal porcentagem = (total - (conv.PorcentagemDesconto)) / 100 * 10;
                txtTotalPagamento.Text = Dinheiro.WithDollar(Dinheiro.Subtract(
                    total.ToString(),
                    porcentagem.ToString())
                    );
                _servico.Total = Dinheiro.ParseToDecimal(Dinheiro.WithdrawDollar(txtTotalPagamento.Text));
            }
        }

        #region Auxiliares

        private void txtDinheiro_Enter(object sender, EventArgs e)
        {
            txtDinheiro.BackColor = Color.Yellow;
        }

        private void txtDinheiro_Leave(object sender, EventArgs e)
        {
            txtDinheiro.BackColor = Color.White;
        }

        private void cmbFormaPagamento_Enter(object sender, EventArgs e)
        {
            cmbFormaPagamento.BackColor = Color.Yellow;
        }

        private void cmbFormaPagamento_Leave(object sender, EventArgs e)
        {
            cmbFormaPagamento.BackColor = Color.White;
        }

        private void txtCartaoValor_Enter(object sender, EventArgs e)
        {
            txtCartaoValor.BackColor = Color.Yellow;
        }

        private void txtCartaoValor_Leave(object sender, EventArgs e)
        {
            txtCartaoValor.BackColor = Color.White;
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            txtDesconto.BackColor = Color.Yellow;
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            txtDesconto.BackColor = Color.White;
        }

        private void convenio_Enter(object sender, EventArgs e)
        {
            convenio.BackColor = Color.Yellow;
        }

        private void convenio_Leave(object sender, EventArgs e)
        {
            convenio.BackColor = Color.White;
        }

        #endregion
    }
}
