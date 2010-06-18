using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmMasterLogin : login
    {
        public frmMasterLogin()
        {
            InitializeComponent();
        }

        private void frmMasterLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(login.Text) || 
                string.IsNullOrEmpty(password.Text)))
            {
                MessageBox.Show("Favor inserir nome e senha", "Preencher todos os campos");
                return;
            }

            HenryCorporation.Lavajato.DomainModel.Usuario user = new HenryCorporation.Lavajato.DomainModel.Usuario();
            user.Login = login.Text;
            user.Password = password.Text;
            this.Usuario= user;

            if (this.IsAutenticado)
            {
                frmPrincipal frmPrin = new frmPrincipal();
                frmPrin.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Nenhum usuário encontrado", "Atenção");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
