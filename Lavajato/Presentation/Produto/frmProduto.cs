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
    public partial class frmProduto : Form
    {
        private ProdutoBL produtoBL = new ProdutoBL();
        private HenryCorporation.Lavajato.DomainModel.Produto produto = new HenryCorporation.Lavajato.DomainModel.Produto();
        
        public frmProduto()
        {
            InitializeComponent();
            CarregaProdutos();
            CarregaCategoriaProduto();
        }

        public frmProduto(HenryCorporation.Lavajato.DomainModel.Produto produto)
        {
            InitializeComponent();
            this.produto = produto;
            CarregaProdutos();
            CarregaCategoriaProduto();
            this.produto = ProcuraProduto(this.produto);
            CarregaCampos(this.produto);
            tabProdutos.SelectedTab = tabProduto;
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Produto produto = new HenryCorporation.Lavajato.DomainModel.Produto();
            produto.Descricao = nomePesquisa.Text;
            grdProdutos.DataSource = produtoBL.ByName(produto);
            OcultaCampo();
        }

        private void OcultaCampo()
        {
            grdProdutos.Columns[0].Visible = false;
        }

        private void grdProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.produto.ID = int.Parse(grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            this.produto = ProcuraProduto(this.produto);
            CarregaCampos(this.produto);
            tabProdutos.SelectedTab = tabProduto;
        }

        private HenryCorporation.Lavajato.DomainModel.Produto ProcuraProduto(HenryCorporation.Lavajato.DomainModel.Produto produto)
        {
            return produtoBL.ByID(produto);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.produto.ID == 0)
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
            produtoBL.Update(this.produto);
            CarregaProdutos();
            MessageBox.Show("Produto atualizado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void precoCompra_TextChanged(object sender, EventArgs e)
        {
            if (precoCompra.Text.Contains("."))
            {
                precoCompra.Text = precoCompra.Text.Remove(precoCompra.Text.Length - 1);
                precoCompra.SelectionStart = precoCompra.Text.Length;
            }
        }

        private void precoVenda_TextChanged(object sender, EventArgs e)
        {
            if (precoVenda.Text.Contains("."))
            {
                precoVenda.Text = precoVenda.Text.Remove(precoVenda.Text.Length - 1);
                precoVenda.SelectionStart = precoVenda.Text.Length;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SetProduto();
            produtoBL.Add(this.produto);
            CarregaProdutos();
            MessageBox.Show("Produto salvo com sucesso", "Atenção");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.produto.ID == 0)
            {
                MessageBox.Show("Nennhum produto selecionado!", "Atenção");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o produto", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            produtoBL.Delete(this.produto);
            CarregaProdutos();
            LimpaCampos();
            MessageBox.Show("Produto excluido!", "Atenção");
        }

        private void CarregaCategoriaProduto()
        {
            cmbCategoriaProduto.DataSource = new CategoriaProdutoBL().GetAll();
            cmbCategoriaProduto.DisplayMember = "Descricao";
            cmbCategoriaProduto.ValueMember = "ID";
        }

        private void CarregaProdutos()
        {
            grdProdutos.DataSource = produtoBL.GetAll();
            OcultaCampo();
        }

        private void CarregaCampos(HenryCorporation.Lavajato.DomainModel.Produto produto)
        {
            descricao.Text = produto.Descricao;
            precoCompra.Text = produto.PrecoCompra.ToString("C").Replace("R$", "");
            precoVenda.Text = produto.ValorUnitario.ToString("C").Replace("R$", "");
            cmbCategoriaProduto.SelectedValue = produto.CategoriaProduto.ID;

            minimo.Text = produto.Estoque.Minimo.ToString();
            quantidade.Text = produto.Estoque.Quantidade.ToString();
        }

        private void LimpaCampos()
        {
            descricao.Text = "";
            quantidade.Text = "";
            precoCompra.Text = "";
            precoVenda.Text = "";
            minimo.Text = "";
            cmbCategoriaProduto.SelectedIndex = 0;
            this.produto = new HenryCorporation.Lavajato.DomainModel.Produto();
            
        }

        private void SetProduto()
        {
            this.produto.Descricao = descricao.Text;
            this.produto.PrecoCompra = Configuracao.ConverteParaDecimal(precoCompra.Text);
            this.produto.ValorUnitario = Configuracao.ConverteParaDecimal(precoVenda.Text);
            this.produto.CategoriaProduto.ID = int.Parse(cmbCategoriaProduto.SelectedValue.ToString());

            this.produto.Estoque.Quantidade = Configuracao.ConverteParaInteiro(quantidade.Text.Length > 0 ? quantidade.Text: "0");
            this.produto.Estoque.Minimo = int.Parse(minimo.Text.Length > 0 ? minimo.Text : "0");
            this.produto.Estoque.Data = this.produto.Estoque.Data;
        }

        private void precoCompra_Enter(object sender, EventArgs e)
        {
            precoCompra.BackColor = Color.Yellow;
        }

        private void precoCompra_Leave(object sender, EventArgs e)
        {
            precoCompra.BackColor = Color.White;
            precoVenda.Focus();
        }

        private void descricao_Enter(object sender, EventArgs e)
        {
            descricao.BackColor = Color.Yellow;
        }

        private void descricao_Leave(object sender, EventArgs e)
        {
            descricao.BackColor = Color.White;
            this.cmbCategoriaProduto.Focus();
        }

        private void precoVenda_Enter(object sender, EventArgs e)
        {
            precoVenda.BackColor = Color.Yellow;
        }

        private void precoVenda_Leave(object sender, EventArgs e)
        {
            precoVenda.BackColor = Color.White;
            quantidade.Focus();
        }

        private void quantidade_Enter(object sender, EventArgs e)
        {
            quantidade.BackColor = Color.Yellow;
        }

        private void quantidade_Leave(object sender, EventArgs e)
        {
            quantidade.BackColor = Color.White;
            minimo.Focus();
        }

        private void minimo_Enter(object sender, EventArgs e)
        {
            minimo.BackColor = Color.Yellow;
        }

        private void minimo_Leave(object sender, EventArgs e)
        {
            minimo.BackColor = Color.White;
            btnSalvar.Focus();
        }

        private void cmbCategoriaProduto_Enter(object sender, EventArgs e)
        {
            cmbCategoriaProduto.BackColor = Color.Yellow;
        }

        private void cmbCategoriaProduto_Leave(object sender, EventArgs e)
        {
            cmbCategoriaProduto.BackColor = Color.White;
            precoCompra.Focus();
        }

        private void quantidade_TextChanged(object sender, EventArgs e)
        {
            int valor = 0;
            if (Configuracao.EInteiro(quantidade.Text, out valor))
            {
                quantidade.Text = valor.ToString();
            }
            else
            {
                if (quantidade.Text.Length > 0)
                {
                    quantidade.Text = quantidade.Text.Remove(quantidade.Text.Length - 1);
                    MessageBox.Show("Favor digitar somente números inteiros", "Atenção");
                }
                quantidade.Focus();
            }
        }

        private void minimo_TextChanged(object sender, EventArgs e)
        {
            int valor = 0;
            if (Configuracao.EInteiro(minimo.Text, out valor))
            {
                minimo.Text = valor.ToString();
            }
            else
            {
                if (minimo.Text.Length > 0)
                {
                    minimo.Text = quantidade.Text.Remove(minimo.Text.Length - 1);
                    MessageBox.Show("Favor digitar somente números inteiros", "Atenção");
                }
                minimo.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void cmbCategoriaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoProdutoID = 0;
            try
            {
                tipoProdutoID = ((CategoriaProduto)cmbCategoriaProduto.SelectedValue).ID;
            }
            catch (Exception)
            {
                tipoProdutoID = ((CategoriaProduto)cmbCategoriaProduto.SelectedItem).ID;
            }
            
            if (tipoProdutoID == EnumCategoriaProduto.Servico)
            {
                precoCompra.Enabled = false;
                minimo.Enabled = false;
                quantidade.Enabled = false;
                precoCompra.Focus();
            }
            else
            {
                precoCompra.Enabled = true;
                minimo.Enabled = true;
                quantidade.Enabled = true;
                precoVenda.Focus();
            }
        }

        private void btnSalvar_Leave(object sender, EventArgs e)
        {
            btnExcluir.Focus();
        }

        private void btnExcluir_Leave(object sender, EventArgs e)
        {
            btnSair.Focus();
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
            btnNovo.Focus();
        }

        private void btnNovo_Leave(object sender, EventArgs e)
        {
            btnAlterar.Focus();
        }

        private void btnAlterar_Leave(object sender, EventArgs e)
        {
            descricao.Focus();
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
