using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Presentation.Properties;
using Presentation;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmMasterLogin : login
    {
        public frmMasterLogin()
        {
            InitializeComponent();
            this.login.Focus();
        }

        private void frmMasterLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            SetUpLogin();
        }

        private void SetUpLogin()
        {
            if ((string.IsNullOrEmpty(this.login.Text) ||
                string.IsNullOrEmpty(this.password.Text)))
            {
                MessageBox.Show(Resources.Favor_inserir_nome_e_senha, Resources.Preencher_todos_os_campos);
                return;
            }

            var user = new Usuario
            {
                Login = this.login.Text,//"loginteste"
                Password = this.password.Text//"senhateste"
            };
            this.Usuario = user;

            if (this.IsAutenticado)
            {
                this.Visible = false;
                var frmPrin = new frmPrincipal();
                frmPrin.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(Resources.Usuario_nao_encontrado, Resources.Atencao);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetUpLogin();
        }
    }
}
