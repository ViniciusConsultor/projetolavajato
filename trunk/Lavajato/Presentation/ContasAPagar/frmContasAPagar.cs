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

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmContasAPagar : Form
    {
        private ContaPagar contaPagar = new ContaPagar();
        private ContaPagarBL contaPagarBL = new ContaPagarBL();

        public frmContasAPagar()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SetUpContasAPagar();
            contaPagarBL.Add(this.contaPagar);
            MessageBox.Show("Conta a pagar salva com sucesso!", "Atenção");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetUpContasAPagar()
        {
            contaPagar.NF = notaFiscal.Text;
            contaPagar.Serie = serie.Text;
            contaPagar.Documento = documento.Text;
            contaPagar.DataDocomento = dataDocumento.Value;
            var credorTemp = credor.SelectedValue == null ? "0" : credor.SelectedValue.ToString();
            contaPagar.Credor.ID = int.Parse(credorTemp.ToString());
            contaPagar.DataVencimento = dataDocumento.Value;
            contaPagar.TipoDocumento = tipoDocumento.SelectedItem.ToString();
            contaPagar.Obs = observacao.Text;
            contaPagar.DataPagamento = dataPagamento.Value;
            contaPagar.ValorPago = decimal.Parse(valorPago.Text);
            contaPagar.ValorTitulo = decimal.Parse(valorTitulo.Text);
        }

        private void SetUpCampos()
        {
            notaFiscal.Text = contaPagar.NF;
            serie.Text = contaPagar.Serie;
            documento.Text = contaPagar.Documento;
            dataDocumento.Value = contaPagar.DataDocomento;
            credor.SelectedValue = contaPagar.Credor.ID;
            dataDocumento.Value = contaPagar.DataVencimento;
            tipoDocumento.SelectedItem = contaPagar.TipoDocumento;
            observacao.Text = contaPagar.Obs;
            dataPagamento.Value = contaPagar.DataPagamento;
        }


        private void CarregaDados()
        {
            credor.DataSource = new CredorBL().GetAll();
            credor.DisplayMember = "Razao Social";
            credor.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaContasAPagar frmPesquisaContasAPagar = new frmPesquisaContasAPagar();
            frmPesquisaContasAPagar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCredorPesquisa frmCredorPesquisa = new frmCredorPesquisa();
            frmCredorPesquisa.ShowDialog();
            this.contaPagar.Credor =  frmCredorPesquisa.Credor;
            credor.SelectedValue = this.contaPagar.Credor.ID;
        }

        private void notaFiscal_Enter(object sender, EventArgs e)
        {
            notaFiscal.BackColor = Color.Yellow;
        }

        private void notaFiscal_Leave(object sender, EventArgs e)
        {
            notaFiscal.BackColor = Color.White;
        }

        private void serie_Enter(object sender, EventArgs e)
        {
            serie.BackColor = Color.Yellow;
        }

        private void serie_Leave(object sender, EventArgs e)
        {
            serie.BackColor = Color.White;

        }

        private void documento_Enter(object sender, EventArgs e)
        {
            documento.BackColor = Color.Yellow;
        }

        private void documento_Leave(object sender, EventArgs e)
        {
            documento.BackColor = Color.White;
        }

        private void dataDocumento_Enter(object sender, EventArgs e)
        {
            dataDocumento.BackColor = Color.Yellow;
        }

        private void dataDocumento_Leave(object sender, EventArgs e)
        {
            dataDocumento.BackColor = Color.White;
        }

        private void credor_Enter(object sender, EventArgs e)
        {
            credor.BackColor = Color.Yellow;
        }

        private void credor_Leave(object sender, EventArgs e)
        {
            credor.BackColor = Color.White;
        }

        private void dataVencimento_Enter(object sender, EventArgs e)
        {
            dataVencimento.BackColor = Color.Yellow;
        }

        private void dataVencimento_Leave(object sender, EventArgs e)
        {
            dataVencimento.BackColor = Color.White;
        }

        private void tipoDocumento_Enter(object sender, EventArgs e)
        {
            tipoDocumento.BackColor = Color.Yellow;
        }

        private void tipoDocumento_Leave(object sender, EventArgs e)
        {
            tipoDocumento.BackColor = Color.White;
        }

        private void valorTitulo_Enter(object sender, EventArgs e)
        {
            valorTitulo.BackColor = Color.Yellow;
        }

        private void valorTitulo_Leave(object sender, EventArgs e)
        {
            valorTitulo.BackColor = Color.White;
        }

        private void observacao_Enter(object sender, EventArgs e)
        {
            observacao.BackColor = Color.Yellow;
        }

        private void observacao_Leave(object sender, EventArgs e)
        {
            observacao.BackColor = Color.White;
        }

        private void dataPagamento_Enter(object sender, EventArgs e)
        {
            dataPagamento.BackColor = Color.Yellow;
        }

        private void dataPagamento_Leave(object sender, EventArgs e)
        {
            dataPagamento.BackColor = Color.White;

        }

        private void diasAtraso_Enter(object sender, EventArgs e)
        {
            diasAtraso.BackColor = Color.Yellow;
        }

        private void diasAtraso_Leave(object sender, EventArgs e)
        {
            diasAtraso.BackColor = Color.White;
        }

        private void valorPago_Enter(object sender, EventArgs e)
        {
            valorPago.BackColor = Color.Yellow;
        }

        private void valorPago_Leave(object sender, EventArgs e)
        {
            valorPago.BackColor = Color.White;
        }

        private void saldoPaga_Enter(object sender, EventArgs e)
        {
            saldoPaga.BackColor = Color.Yellow;
        }

        private void saldoPaga_Leave(object sender, EventArgs e)
        {
            saldoPaga.BackColor = Color.White;
        }

    }
}
