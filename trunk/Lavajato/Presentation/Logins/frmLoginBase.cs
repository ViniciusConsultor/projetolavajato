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

namespace HenryCorporation.Lavajato.Presentation.Logins
{
    public partial class frmLoginBase : Form
    {
        public Usuario User { get; set; }
        public UsuarioBL usuarioBL;

        public frmLoginBase()
        {
            InitializeComponent();
            User = new Usuario();
            usuarioBL = new UsuarioBL();
        }

        private void frmLoginBase_Load(object sender, EventArgs e)
        {
            this.txtLogin.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtLogin.Text)|| txtPassword.TextLength > 0)
            //{
            //    this.User.Login = txtLogin.Text.Trim();
            //    this.User = usuarioBL.ByLoginAndPassword(this.User);
            //}

            //if (this.User.ID == 0)
            //{
            //    MessageBox.Show("Favor digitar login corretamente", "Atenção, Nenhum usuário encontrado");
            //    txtLogin.Focus();
            //    return;
            //}
            //this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
