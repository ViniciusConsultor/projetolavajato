using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmExcluirServico : HenryCorporation.Lavajato.Presentation.Logins.frmLoginBase
    {
        public ServicoItem ServicoItem{get;set;}

        public frmExcluirServico()
        {
            InitializeComponent();
            ServicoItem = new ServicoItem();
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

            if (this.User.TipoFuncionario.Descricao == "Gerente")
            {
                new ServicoBL().ItemDelete(ServicoItem, this.User);

                MessageBox.Show("Excluido com sucesso!", "Atenção");
                this.Close();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para concluir essa operação", "Atenção");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetUpLogin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExcluirServico_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
