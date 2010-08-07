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
            grdContasPagar.DataSource = contaPagarBL.PesquisaPorDataETipo(ContaPagar.TipoPesquisa.MostrarTodos.ToString(), documentoPesquisa.Text, DateTime.Now).DefaultView;
        }

        private void documentoPesquisa_TextChanged(object sender, EventArgs e)
        {
            grdContasPagar.DataSource = contaPagarBL.PesquisaPorDataETipo(ContaPagar.TipoPesquisa.Documento.ToString(), documentoPesquisa.Text, DateTime.Now);
        }

        private void nomeCredorPesquisa_TextChanged(object sender, EventArgs e)
        {
            grdContasPagar.DataSource = contaPagarBL.PesquisaPorDataETipo(ContaPagar.TipoPesquisa.VencendoHoje.ToString(), nomeCredorPesquisa.Text, DateTime.Now);
        }

        private void VencendoHoje_Click(object sender, EventArgs e)
        {
            grdContasPagar.DataSource = contaPagarBL.PesquisaPorDataETipo(ContaPagar.TipoPesquisa.VencendoHoje.ToString(), "", DateTime.Now);
        }

        private void MostrarTodos_Click(object sender, EventArgs e)
        {
            grdContasPagar.DataSource = contaPagarBL.PesquisaPorDataETipo(ContaPagar.TipoPesquisa.MostrarTodos.ToString(), "", DateTime.Now);
        }

        private void Pagos_Click(object sender, EventArgs e)
        {
            grdContasPagar.DataSource = contaPagarBL.PesquisaPorDataETipo(ContaPagar.TipoPesquisa.Pagos.ToString(), "", DateTime.Now);
        }
    }
}
