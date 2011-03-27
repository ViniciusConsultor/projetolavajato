﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation.Logins
{
    public partial class frmLoginRetirada : HenryCorporation.Lavajato.Presentation.Logins.frmLoginBase
    {
        public frmLoginRetirada()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SetUpLogin();
        }

        private void SetUpLogin()
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                this.User.Login = txtLogin.Text.Trim();
                this.User.Password = txtPassword.Text.Trim();
                this.User = this.usuarioBL.ByLoginAndPassword(this.User);
            }

            if (this.User.ID == 0)
            {
                MessageBox.Show("Favor digitar login corretamente", "Atenção, Nenhum usuário encontrado");
                txtLogin.Focus();
                return;
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetUpLogin();
        }

        
    }
}
