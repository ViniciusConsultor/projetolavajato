using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmProdutoPesquisa : Form
    {
        private ProdutoBL produtoBL = new ProdutoBL();

        public frmProdutoPesquisa()
        {
            InitializeComponent();
            CarregaProdutos();
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Produto produto = new HenryCorporation.Lavajato.DomainModel.Produto();
            produto.Descricao = nomePesquisa.Text;
            grdProdutos.DataSource = produtoBL.ByName(produto);
            OcultaCampos();
        }

        private void CarregaProdutos()
        {
            grdProdutos.DataSource = produtoBL.GetAll();
            OcultaCampos();
        }

        private void grdProdutos_DoubleClick(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Produto produto = new HenryCorporation.Lavajato.DomainModel.Produto();
            produto.ID = int.Parse(grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            frmProduto frmProduto = new frmProduto(produto);
            frmProduto.ShowDialog();
            this.Close();
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }

        private void OcultaCampos()
        {
            grdProdutos.Columns[0].Visible = false;
        }

        private void frmProdutoPesquisa_Load(object sender, EventArgs e)
        {
            nomePesquisa.Focus();
        }
    }
}
