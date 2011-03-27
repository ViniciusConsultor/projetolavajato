using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmLoginFechamentoDeCaixa : HenryCorporation.Lavajato.Presentation.Logins.frmLoginBase
    {
        public frmLoginFechamentoDeCaixa()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SetUpLogin();
        }

        private void SetUpLogin()
        {
            if (txtLogin.TextLength > 0 && txtPassword.TextLength > 0)
            {
                this.User.Login = txtLogin.Text.Trim();
                this.User.Password = txtPassword.Text.Trim();
                this.User = usuarioBL.ByLoginAndPassword(this.User);
            }

            if (this.User.ID == 0)
            {
                MessageBox.Show("Favor digitar login corretamente", "Atenção, Nenhum usuário encontrado");
                txtLogin.Focus();
                return;
            }

            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetUpLogin();
        }
    }
}
