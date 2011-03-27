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
    public partial class frmRetiradaSuprimento : login
    {
        public frmRetiradaSuprimento()
        {
            InitializeComponent();
            SetOperador();
            lstTipoRetirada.SelectedIndex = 0;
        }

        private void frmRetirada_Load(object sender, EventArgs e)
        {

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

            bool isRetirada = lstTipoRetirada.Items[lstTipoRetirada.SelectedIndex].ToString().Contains(TipoRetirada.Sangria.ToString());
            bool isVale = lstTipoRetirada.Items[lstTipoRetirada.SelectedIndex].ToString().Contains(TipoRetirada.Vale.ToString());
            bool isSuprimento = lstTipoRetirada.Items[lstTipoRetirada.SelectedIndex].ToString().Contains(TipoRetirada.Suprimento.ToString());

            try
            {
                if (isRetirada)
                {
                    Retirada retirada = SetUpRetirada();
                    retirada.TipoRetirada = TipoRetirada.Sangria;
                    retirada = new RetiradaBL().Add(retirada);

                    MessageBox.Show("Retirada inserida com sucesso!", "Atenção");
                }
                else if (isVale)
                {
                    Presentation.Logins.frmLoginRetirada frmLoginRetirada = new Logins.frmLoginRetirada();
                    frmLoginRetirada.ShowDialog();

                    if (frmLoginRetirada.User.ID > 0)
                    {
                        Retirada retirada = SetUpRetirada();
                        retirada.TipoRetirada = TipoRetirada.Vale;
                        retirada.Vale = new Vale() { Usuario = frmLoginRetirada.User };
                        retirada.Vale.isVale = 1;
                        retirada = new RetiradaBL().Add(retirada);
                        MessageBox.Show("Retirada inserida com sucesso!", "Atenção");
                    }
                }
                else if (isSuprimento)
                {
                    Suprimento suprimento = SetUpSuprimento();
                    suprimento.TipoRetirada = TipoRetirada.Suprimento;
                    suprimento = new SuprimentoBL().Insert(suprimento);

                    MessageBox.Show("Suprimento inserido com sucesso!", "Atenção");
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro ao selecionar Tipo de Movimentação", "Atenção!");
            }

            LimpaCampos();
        }

        private Retirada SetUpRetirada()
        {
            Retirada retirada = new Retirada();
            retirada.Valor = Operacional.Configuracao.ConverteParaDecimal(valor.Text);
            retirada.Usuario = this.Usuario;
            retirada.Descricao = descricao.Text;
           
            return retirada;
        }

        private Suprimento SetUpSuprimento()
        {
            Suprimento suprimento = new Suprimento();
            suprimento.Valor = Operacional.Configuracao.ConverteParaDecimal(valor.Text);
            suprimento.Usuario = this.Usuario;
            suprimento.Descricao = descricao.Text;
            return suprimento;
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
