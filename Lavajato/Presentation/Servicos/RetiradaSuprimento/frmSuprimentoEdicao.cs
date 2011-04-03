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
using HenryCorporation.Lavajato.Presentation;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmSuprimentoEdicao : Form
    {
        private Suprimento _suprimento = new Suprimento();
        public frmSuprimentoEdicao()
        {
            InitializeComponent();
        }

        public frmSuprimentoEdicao(Suprimento suprimento)
        {
            InitializeComponent();
            _suprimento = suprimento;
        }

        private void frmSuprimentoEdicao_Load(object sender, EventArgs e)
        {
            SetUpCampos(_suprimento);
        }

        private void SetUpCampos(Suprimento suprimento)
        {
            txtTipoRetirada.Text = suprimento.Data.ToShortDateString();
            valor.Text = suprimento.Valor.ToString("C").Replace("R$", "");
            descricao.Text = suprimento.Descricao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _suprimento.Valor = Dinheiro.ParseToDecimal(valor.Text);
            _suprimento.Descricao = descricao.Text;
            new SuprimentoBL().Update(_suprimento);

            MessageBox.Show("Atualizado com sucesso!", "Atenção");
        }
    }
}
