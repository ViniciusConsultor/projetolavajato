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
    public partial class frmCredorPesquisa : Form
    {
        private Credor credor = new Credor();
        private CredorBL credorBL = new CredorBL();

        public frmCredorPesquisa()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void CarregaDados()
        {
            grdCredor.DataSource = credorBL.GetAll();
        }

        public Credor Credor
        {
            get { return credor; }
            set { credor = value; }
        }
      
        private void razaoSocialPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            Credor crd = new Credor();
            crd.RazaoSocial = razaoSocialPesquisa.Text;
            grdCredor.DataSource = credorBL.ByRazaoSocial(crd);
        }

        private void nomeFantasiaPesquisa_TextChanged(object sender, EventArgs e)
        {
            Credor crd = new Credor();
            crd.NomeFantasia = nomeFantasiaPesquisa.Text;
            grdCredor.DataSource = credorBL.ByNomeFantasia(crd);
        }

        private void razaoSocialPesquisa_Enter(object sender, EventArgs e)
        {
            razaoSocialPesquisa.BackColor = Color.Yellow;
        }

        private void razaoSocialPesquisa_Leave(object sender, EventArgs e)
        {
            razaoSocialPesquisa.BackColor = Color.White;
        }

        private void nomeFantasiaPesquisa_Enter(object sender, EventArgs e)
        {
            nomeFantasiaPesquisa.BackColor = Color.Yellow;
        }

        private void nomeFantasiaPesquisa_Leave(object sender, EventArgs e)
        {
            nomeFantasiaPesquisa.BackColor = Color.White;
        }

        private void grdCredor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.credor.ID = int.Parse(grdCredor.Rows[grdCredor.CurrentRow.Index].Cells[0].Value.ToString());
            this.credor = this.credorBL.ByID(this.credor);
            this.Close();
        }


    }
}
