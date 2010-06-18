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
    public partial class frmRetirada : login
    {
        private RetiradaBL retiradaBL = new RetiradaBL();

        public frmRetirada()
        {
            InitializeComponent();
            SetOperador();
        }

        private void SetOperador()
        {
            lblOperador.Text = this.Usuario.Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (valor.TextLength == 0 || descricao.TextLength == 0)
            {
                MessageBox.Show("Favor não deixar campos em branco","Atenção");
                return;
            }

            Retirada retirada = new Retirada();
            retirada.Valor = decimal.Parse(valor.Text);
            retirada.Usuario = this.Usuario;
            retirada.Descricao = descricao.Text;
            retirada = retiradaBL.Insert(retirada);

            MessageBox.Show("Retirada inserida com sucesso!", "Atenção");

            LimpaCampos();
        }

        private void LimpaCampos()
        {
            valor.Text = "";
            descricao.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {
            if (descricao.Text.Contains("."))
            {
                descricao.Text = descricao.Text.Remove(descricao.Text.Length - 1);
                descricao.SelectionStart = descricao.Text.Length;
            }
        }

        private void valor_Enter(object sender, EventArgs e)
        {
            valor.BackColor = Color.Yellow;
        }

        private void valor_Leave(object sender, EventArgs e)
        {
            valor.BackColor = Color.White;
        }

        private void descricao_Enter(object sender, EventArgs e)
        {
            descricao.BackColor = Color.Yellow;
        }

        private void descricao_Leave(object sender, EventArgs e)
        {
            descricao.BackColor = Color.White;
        }
    }
}
