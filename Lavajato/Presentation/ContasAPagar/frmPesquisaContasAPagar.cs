using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmPesquisaContasAPagar : Form
    {
        private ContaPagarBL contaPagarBL = new ContaPagarBL();

        public frmPesquisaContasAPagar()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void CarregaDados()
        {
            grdContasPagar.DataSource = contaPagarBL.GetAll();
        }

        private void documentoPesquisa_Enter(object sender, EventArgs e)
        {
            documentoPesquisa.BackColor = Color.Yellow;
        }

        private void documentoPesquisa_Leave(object sender, EventArgs e)
        {
            documentoPesquisa.BackColor = Color.White;
        }

        private void nomeCredorPesquisa_Enter(object sender, EventArgs e)
        {
            nomeCredorPesquisa.BackColor = Color.Yellow;
        }

        private void nomeCredorPesquisa_Leave(object sender, EventArgs e)
        {
            nomeCredorPesquisa.BackColor = Color.White;
        }

    }
}
