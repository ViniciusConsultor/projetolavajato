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
        }


        private void btnLogar_Click(object sender, EventArgs e)
        {
            //if ((string.IsNullOrEmpty(login.Text) ||
            //    string.IsNullOrEmpty(password.Text)))
            //{
            //    MessageBox.Show(Resources.Favor_inserir_nome_e_senha, Resources.Preencher_todos_os_campos);
            //    return;
            //}

            var user = new Usuario
                           {
                               Login = "loginteste",//login.Text,
                               Password = "senhateste"//password.Text
                           };
            this.Usuario= user;

            if (this.IsAutenticado)
            {
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
    }
}
