using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Interface;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmListaProdutosTranferencia : Form
    {
        private IProdutoRepositorio _produtoRepository = new ProdutoBL();
        private Produto _produto = new Produto();

        public frmListaProdutosTranferencia()
        {
            InitializeComponent();
        }

        private void frmListaProdutosTranferencia_Load(object sender, EventArgs e)
        {
            CarregaProdutos();

        }

        private void CarregaProdutos()
        {
            grdProdutos.DataSource = _produtoRepository.TipoServico(1);
            OcultaCampos();
        }

        private void OcultaCampos()
        {
            grdProdutos.Columns[0].Visible = false;
        }

        private void grdProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grdProdutos.CurrentRow == null)
                return;

            _produto.ID = int.Parse(grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            _produto = ProcuraProduto(_produto);

            frmTransfereProdutos frmTransPro = new frmTransfereProdutos(_produto);
            frmTransPro.ShowDialog();

            CarregaProdutos();
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = nomePesquisa.Text;

            grdProdutos.DataSource = _produtoRepository.ByCategoria(produto);
            OcultaCampos();
        }

        private HenryCorporation.Lavajato.DomainModel.Produto ProcuraProduto(HenryCorporation.Lavajato.DomainModel.Produto produto)
        {
            return _produtoRepository.ByID(produto);
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }
    }
}
