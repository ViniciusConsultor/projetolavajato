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
    public partial class frmUsuarioPesquisa : Form
    {
        UsuarioBL usuarioBL = new UsuarioBL();

        public frmUsuarioPesquisa()
        {
            InitializeComponent();
            grdUsuarios.DataSource = usuarioBL.GetAll().Tables[0];
            OcultaCampos();
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomePesquisa.Text;
            grdUsuarios.DataSource = usuarioBL.ByName(usuario);
            OcultaCampos();
        }

        private void grdUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.ID = int.Parse(grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            frmUsuario frmUsuario = new frmUsuario(usuario);
            frmUsuario.ShowDialog();
            this.Close();
        }

        private void loginPesquisa_TextChanged(object sender, EventArgs e)
        {
            grdUsuarios.DataSource = usuarioBL.ByLogin(loginPesquisa.Text);
            OcultaCampos();
        }

        private void OcultaCampos()
        {
            grdUsuarios.Columns[0].Visible = false;
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }

        private void loginPesquisa_Enter(object sender, EventArgs e)
        {
            loginPesquisa.BackColor = Color.Yellow;
        }

        private void loginPesquisa_Leave(object sender, EventArgs e)
        {
            loginPesquisa.BackColor = Color.White;
        }

       
    }
}
