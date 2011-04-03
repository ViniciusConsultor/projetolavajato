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
    public partial class frmRetiradaEdicao : Form
    {
        private Retirada _retirada = new Retirada();

        public frmRetiradaEdicao()
        {
            InitializeComponent();
        }

        public frmRetiradaEdicao(Retirada retirada)
        {
            InitializeComponent();
            _retirada = retirada;
        }

        private void frmRetiradaEdicao_Load(object sender, EventArgs e)
        {
            SetUpCampos(_retirada);
        }

        private void SetUpCampos(Retirada retirada)
        {
            txtTipoRetirada.Text = retirada.Data.ToShortDateString();
            valor.Text = retirada.Valor.ToString("C").Replace("R$", "");
            descricao.Text = retirada.Descricao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _retirada.Valor = Dinheiro.ParseToDecimal(valor.Text);
            _retirada.Descricao = descricao.Text;
            new RetiradaBL().Update(_retirada);

            MessageBox.Show("Atualizado com sucesso!", "Atenção");
        }

        
    }
}
