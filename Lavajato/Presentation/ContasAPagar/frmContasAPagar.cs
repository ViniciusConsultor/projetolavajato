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
            contaPagar.Credor = new Credor();
            contaPagar.DataVencimento = dataDocumento.Value;
            contaPagar.TipoDocumento = tipoDocumento.SelectedItem.ToString();
            contaPagar.Obs = observacao.Text;
            contaPagar.DataPagamento = dataPagamento.Value;
        }
    }
}
