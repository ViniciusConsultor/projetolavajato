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

        public VendaFormaPagamento(Servico servico)
        {
            InitializeComponent();
            _servico = servico;
        }

        private void VendaFormaPagamento_Load(object sender, EventArgs e)
        {
            CarregaFormaPagamento();
            SetUpTotal();
        }

        private void SetUpTotal()
        {
            lblVenda.Text =  _servico.Total.ToString("C");
            txtTotalPagamento.Text = _servico.Total.ToString("C");
        }

        //criar tabela para receber forma de pagamento
        //dinheiro, cartão, desconto, valor
        //mudar relatorio para pegar dessa tabela


        private Servico SetUpServico()
        {
            _servico.Finalizado = 1;
            _servico.Lavado = 1;
            _servico.Pago = 1;
            _servico.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
            _servico.Total = Configuracao.ConverteParaDecimal(txtTotalPagamento.Text);
            _servico.SubTotal = Configuracao.ConverteParaDecimal(txtTotalPagamento.Text);
            _servico.Desconto = Configuracao.ConverteParaDecimal(txtDesconto.Text);
            
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
                    MessageBox.Show("Você não tem permissão para dar desconto, favor entrar em contato com o Gerente", "Atenção");
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
            pagamento.Total = Dinheiro.RetiraCifraoDaMoedaReal(txtTotalPagamento.Text);
            pagamento.Desconto = Dinheiro.ConverteParaDecimal(txtDesconto.Text);
            pagamento.Dinheiro = Dinheiro.ConverteParaDecimal(txtDinheiro.Text);
            pagamento.Cartao = Dinheiro.ConverteParaDecimal(txtCartaoValor.Text);
            pagamento.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
            return pagamento;
        }

        private decimal SomaDinheiroCartao()
        {
           return Dinheiro.ConverteParaDecimal( txtDinheiro.Text) + Dinheiro.ConverteParaDecimal(txtCartaoValor.Text); 
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
                txtCartaoValor.Text = txtCartaoValor.Text.Remove(txtCartaoValor.Text.Length - 1);
                txtCartaoValor.SelectionStart = txtCartaoValor.Text.Length;
            }

            SetUpDesconto();
        }

        private void SetUpDesconto()
        {
            if (SomaDinheiroCartao() > _servico.Total)
            {
                txtTroco.Text = (SomaDinheiroCartao() - _servico.Total).ToString();
            }
            else
            {
                txtTroco.Text = "";
            }
        }


        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text.Contains("."))
            {
                txtDesconto.Text = txtDesconto.Text.Remove(txtDesconto.Text.Length - 1);
                txtDesconto.SelectionStart = txtDesconto.Text.Length;
            }

            decimal somaDinheiroCartao = SomaDinheiroCartao();
            decimal desconto = Dinheiro.ConverteParaDecimal(txtDesconto.Text);
            if (somaDinheiroCartao >= desconto)
            {
                if (txtDesconto.TextLength > 0)
                {
                    txtTotalPagamento.Text = (_servico.Total - desconto).ToString();
                    txtTroco.Text = (somaDinheiroCartao - Dinheiro.ConverteParaDecimal(txtTotalPagamento.Text)).ToString();
                }

            }

           
        }

        private decimal CalculaDesconto()
        {
            return (SomaDinheiroCartao() - Dinheiro.ConverteParaDecimal(txtDesconto.Text));
        }




        
    }
}
