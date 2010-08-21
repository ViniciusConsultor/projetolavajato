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
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmProdutoRetiradoEstoqueInterno : Form
    {
        private ProdutoInterno produtoInterno = new ProdutoInterno();
        private ProdutoInternoBL produtoInternoBL = new ProdutoInternoBL();
        private EstoqueBL estoqueBL = new EstoqueBL();

        public frmProdutoRetiradoEstoqueInterno()
        {
            InitializeComponent();
        }

        public frmProdutoRetiradoEstoqueInterno(ProdutoInterno produtoInterno)
        {
            InitializeComponent();
            this.produtoInterno = produtoInterno;
            SetUpCampos(this.produtoInterno);
        }

        private void SetUpCampos(ProdutoInterno produtoInterno)
        {
            label1.Text = this.produtoInterno.Descricao;
        }

        private void btnRetirada_Click(object sender, EventArgs e)
        {
            if (txtRetirada.TextLength == 0)
            {
                MessageBox.Show("Favor digitar uma quantidade", "Atenção");
                return;
            }

            int qtdeEstoque = produtoInterno.Estoque.Quantidade;
            int qtdeParaRetirada = txtRetirada.Text.Length > 0 ? int.Parse(txtRetirada.Text) : 0;
            if (qtdeParaRetirada >= qtdeEstoque)
            {
                MessageBox.Show("Quantidade para retirar maior superior ao estoque atual", "Atenção");
                return;
            }
            produtoInterno.Estoque.Quantidade = qtdeEstoque - qtdeParaRetirada;
            estoqueBL.Update(produtoInterno.Estoque);

            MessageBox.Show("Quantidade alterada com sucesso!", "Atenção");
            txtRetirada.Clear();
            produtoInterno = produtoInternoBL.ByID(this.produtoInterno);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
