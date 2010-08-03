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
            contaPagar.Credor.ID = int.Parse(credor.SelectedValue.ToString());
            contaPagar.DataVencimento = dataDocumento.Value;
            contaPagar.TipoDocumento = tipoDocumento.SelectedItem.ToString();
            contaPagar.Obs = observacao.Text;
            contaPagar.DataPagamento = dataPagamento.Value;
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

    }
}
