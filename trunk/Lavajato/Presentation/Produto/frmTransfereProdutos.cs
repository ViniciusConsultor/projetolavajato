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
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.Interface;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmTransfereProdutos : Form
    {
        private Produto _produto;
        private IProdutoRepositorio _produtoBL = new ProdutoBL();

        public frmTransfereProdutos()
        {
            InitializeComponent();
        }

        public frmTransfereProdutos(Produto produto)
        {
            InitializeComponent();
            _produto = produto;
        }

        private void frmTransfereProdutos_Load(object sender, EventArgs e)
        {
            SetUpOjbects(_produto);
        }

        private void SetUpOjbects(Produto _produto)
        {
            lblProduto.Text = _produto.Descricao;
            quantidade.Text = _produto.Estoque.Quantidade.ToString();
            expositor.Text = _produto.Expositor.Quantidade.ToString();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            if (transferencia.TextLength > 0)
            {
                if (Dinheiro.ParseToInt(transferencia.Text))
                {
                    _produto.Expositor.Quantidade += int.Parse(transferencia.Text);
                    _produto.Estoque.Quantidade -= int.Parse(transferencia.Text);
                    _produtoBL.Update(_produto);
                    MessageBox.Show("Transferencia realizada com sucesso", "Atenção");
                }
                else
                {
                    MessageBox.Show("Favor inserir somente números", "Atenção");
                }
            }
            else
            {
                MessageBox.Show("Favor inserir quantidade!", "Atenção");
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }
    }
}
