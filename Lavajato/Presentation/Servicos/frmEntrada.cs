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
    public partial class frmEntrada : login
    {
        private SuprimentoBL suprimentoBL = new SuprimentoBL();

        public frmEntrada()
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
                MessageBox.Show("Favor não deixar campos em branco", "Atenção");
                return;
            }

            Suprimento suprimento = new Suprimento();
            suprimento.Valor = decimal.Parse(valor.Text);
            suprimento.Usuario = this.Usuario;
            suprimento.Descricao = descricao.Text;
            suprimento = suprimentoBL.Insert(suprimento);

            MessageBox.Show("Suprimento inserido com sucesso!", "Atenção");

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
