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
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class ProdutosInternos : Form
    {
        private ProdutoInterno produtoInterno = new ProdutoInterno();
        private ProdutoInternoBL produtoInternoBL = new ProdutoInternoBL();

        public ProdutosInternos()
        {
            InitializeComponent();
            CarregaProdutos();
            CarregaCategoriaProduto();
        }
        public ProdutosInternos(ProdutoInterno produtosInternos)
        {
            InitializeComponent();
            this.produtoInterno = produtoInterno;
            CarregaProdutos();
            this.produtoInterno = ProcuraProduto(this.produtoInterno);
            CarregaCampos(this.produtoInterno);
            tabProdutos.SelectedTab = tabProduto;
        }

        private void CarregaCategoriaProduto()
        {
            cmbCategoriaProduto.DataSource = new CategoriaProdutoBL().GetAll();
            cmbCategoriaProduto.DisplayMember = "Descricao";
            cmbCategoriaProduto.ValueMember = "ID";
        }

        private ProdutoInterno ProcuraProduto(ProdutoInterno produtoInterno)
        {
            return produtoInternoBL.ByID(produtoInterno);
        }

        private void CarregaCampos(ProdutoInterno produtoInterno)
        {
            descricao.Text = produtoInterno.Descricao;
            precoCompra.Text = produtoInterno.PrecoCompra.ToString("C").Replace("R$", "");
            precoVenda.Text = produtoInterno.ValorUnitario.ToString("C").Replace("R$", "");
            cmbCategoriaProduto.SelectedValue = produtoInterno.CategoriaProduto.ID;

            minimo.Text = produtoInterno.Estoque.Minimo.ToString();
            quantidade.Text = produtoInterno.Estoque.Quantidade.ToString();
        }

        private void CarregaProdutos()
        {
            grdProdutos.DataSource = produtoInternoBL.GetAll();
            OcultaCampo();
        }

        private void OcultaCampo()
        {
            grdProdutos.Columns[0].Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SetProduto();
            produtoInternoBL.Add(this.produtoInterno);
            CarregaProdutos();
            MessageBox.Show("Produto salvo com sucesso", "Atenção");
        }

        private void SetProduto()
        {
            this.produtoInterno.Descricao = descricao.Text;
            this.produtoInterno.PrecoCompra = Configuracao.ConverteParaDecimal(precoCompra.Text);
            this.produtoInterno.ValorUnitario = Configuracao.ConverteParaDecimal(precoVenda.Text);
            this.produtoInterno.CategoriaProduto.ID = int.Parse(cmbCategoriaProduto.SelectedValue.ToString());

            this.produtoInterno.Estoque.Quantidade = Configuracao.ConverteParaInteiro(quantidade.Text.Length > 0 ? quantidade.Text : "0");
            this.produtoInterno.Estoque.Minimo = int.Parse(minimo.Text.Length > 0 ? minimo.Text : "0");
            this.produtoInterno.Estoque.Data = this.produtoInterno.Estoque.Data;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.produtoInterno.ID == 0)
            {
                MessageBox.Show("Favor selecionar um produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (descricao.Text.Length == 0)
            {
                MessageBox.Show("Favor preencher todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetProduto();
            produtoInternoBL.Update(this.produtoInterno);
            CarregaProdutos();
            MessageBox.Show("Produto atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.produtoInterno.ID == 0)
            {
                MessageBox.Show("Nennhum produto selecionado!", "Atenção");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o produto", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            produtoInternoBL.Delete(this.produtoInterno);
            CarregaProdutos();
            LimpaCampos();
            MessageBox.Show("Produto excluido!", "Atenção");
        }

        private void LimpaCampos()
        {
            descricao.Clear();
            quantidade.Clear();
            precoCompra.Clear();
            precoVenda.Clear();
            minimo.Clear();
            cmbCategoriaProduto.SelectedIndex = 0;
            this.produtoInterno = new ProdutoInterno();

        }

        private void grdProdutos_DoubleClick(object sender, EventArgs e)
        {
            this.produtoInterno.ID = int.Parse(grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            this.produtoInterno = ProcuraProduto(this.produtoInterno);
            CarregaCampos(this.produtoInterno);
            tabProdutos.SelectedTab = tabProduto;
        }


    }
}
