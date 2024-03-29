﻿using System;
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
using HenryCorporation.Lavajato.Interface;
using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmProduto : Form
    {
        private const string contemPonto = ".";
        private IProdutoRepositorio _produtoRepository = new ProdutoBL();
        private HenryCorporation.Lavajato.DomainModel.Produto _produto = new Produto();

        
        public frmProduto()
        {
            InitializeComponent();
            CarregaProdutos();
            OcultaCampo();
            CarregaCategoriaProduto();
            nomePesquisa.Focus();
        }

        public frmProduto(Produto produto)
        {
            InitializeComponent();
            _produto = produto;
            CarregaProdutos();
            OcultaCampo();
            CarregaCategoriaProduto();
            _produto = ProcuraProduto(_produto);
            CarregaCampos(_produto);
            tabProdutos.SelectedTab = tabProduto;
                        
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            nomePesquisa.Focus();
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = nomePesquisa.Text;
            grdProdutos.DataSource = _produtoRepository.ByName(produto);
            OcultaCampo();
        }

        private void grdProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _produto.ID = int.Parse(grdProdutos.Rows[grdProdutos.CurrentRow.Index].Cells[0].Value.ToString());
            _produto = ProcuraProduto(_produto);
            CarregaCampos(_produto);
            tabProdutos.SelectedTab = tabProduto;
            descricao.Focus();
        }

        private HenryCorporation.Lavajato.DomainModel.Produto ProcuraProduto(HenryCorporation.Lavajato.DomainModel.Produto produto)
        {
            return _produtoRepository.ByID(produto);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ProdutoExiste())
            {
                MessageBox.Show(Resources.FavorSelecionarUmItem, Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (descricao.Text.Length == 0)
            {
                MessageBox.Show(Resources.FavorPreencherTodosOsCampos, Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetProduto();
            _produtoRepository.Update(_produto);
            CarregaProdutos();
            MessageBox.Show(Resources.ProdutoAtualizadoComSucesso, Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void precoCompra_TextChanged(object sender, EventArgs e)
        {
            if (precoCompra.Text.Contains(contemPonto))
            {
                precoCompra.Text = precoCompra.Text.Remove(precoCompra.Text.Length - 1);
                precoCompra.SelectionStart = precoCompra.Text.Length;
            }
        }

        private void precoVenda_TextChanged(object sender, EventArgs e)
        {
            if (precoVenda.Text.Contains(contemPonto))
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
            if (Todos_Os_Campos_Obrigatorios_Estao_Preenchitos())
            {
                MessageBox.Show(Resources.Preencher_todos_os_campos, Resources.Atencao);
                return;
            }

            SetProduto();
            _produtoRepository.Add(_produto);
            CarregaProdutos();
            OcultaCampo();
            MessageBox.Show(Resources.ProdutoSalvoComSucesso, Resources.Atencao);
        }

        private bool Todos_Os_Campos_Obrigatorios_Estao_Preenchitos()
        {

            int tipoProdutoID = 0;
            try
            {
                tipoProdutoID = ((CategoriaProduto)cmbCategoriaProduto.SelectedValue).ID;
            }
            catch
            {
                tipoProdutoID = ((CategoriaProduto)cmbCategoriaProduto.SelectedItem).ID;
            }


            bool camposServico = descricao.TextLength != 0 || precoVenda.TextLength != 0;
            bool camposProduto = camposServico || minimo.TextLength != 0 || quantidade.TextLength != 0;

            if (tipoProdutoID == EnumCategoriaProduto.Servico)
            {
                if (!camposServico)
                    return false;

            }
            else
            {
                if (!camposProduto)
                    return false;
            }

            return false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o Item?", Resources.Atencao, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _produtoRepository.Delete(_produto);
                CarregaProdutos();
                LimpaCampos();
                MessageBox.Show(Resources.Item_deletado, Resources.Atencao);
            }
        }

        private bool ProdutoExiste()
        {
            return !(_produto.ID > 0);
        }

        private void CarregaCampos(HenryCorporation.Lavajato.DomainModel.Produto produto)
        {
            descricao.Text = produto.Descricao;
            precoCompra.Text = produto.PrecoCompra.ToString("C").Replace("R$", "");
            precoVenda.Text = produto.ValorUnitario.ToString("C").Replace("R$", "");
            cmbCategoriaProduto.SelectedValue = produto.CategoriaProduto.ID;

            minimo.Text = produto.Estoque.Minimo.ToString();
            quantidade.Text = produto.Estoque.Quantidade.ToString();

            expMinimo.Text = produto.Expositor.Minimo.ToString();
            expQuantidade.Text = produto.Expositor.Quantidade.ToString();

        }

        private void LimpaCampos()
        {
            descricao.Clear();
            quantidade.Clear();
            precoCompra.Clear();
            precoVenda.Clear();
            minimo.Clear();
            cmbCategoriaProduto.SelectedIndex = 0;
            _produto = new Produto();
            
        }

        private void SetProduto()
        {
            _produto.Descricao = descricao.Text;
            _produto.PrecoCompra = Configuracao.ConverteParaDecimal(precoCompra.Text);
            _produto.ValorUnitario = Configuracao.ConverteParaDecimal(precoVenda.Text);
            _produto.CategoriaProduto.ID = int.Parse(cmbCategoriaProduto.SelectedValue.ToString());

            _produto.Estoque.Quantidade = Configuracao.ConverteParaInteiro(quantidade.Text.Length > 0 ? quantidade.Text: "0");
            _produto.Estoque.Minimo = int.Parse(minimo.Text.Length > 0 ? minimo.Text : "0");
            _produto.Estoque.Data = this._produto.Estoque.Data;

            _produto.Expositor.Quantidade = Configuracao.ConverteParaInteiro(expQuantidade.Text.Length > 0 ? expQuantidade.Text : "0");
            _produto.Expositor.Minimo = int.Parse(expMinimo.Text.Length > 0 ? expMinimo.Text : "0");
            _produto.Expositor.Data = this._produto.Estoque.Data;
        }

        private void FormataGrid()
        {
            grdProdutos.Columns[1].Width = 180;
            grdProdutos.Columns[1].HeaderText = "Descrição";

            grdProdutos.Columns[2].Width = 130;
            grdProdutos.Columns[2].HeaderText = "Preço Venda";

            grdProdutos.Columns[3].Width = 130;
            grdProdutos.Columns[3].HeaderText = "Valor Unitário";

            grdProdutos.Columns[4].Width = 80;
            grdProdutos.Columns[4].HeaderText = "Estoque";
            grdProdutos.Columns[5].Width = 135;
        }

        private void precoCompra_Enter(object sender, EventArgs e)
        {
            precoCompra.BackColor = Color.Yellow;
        }

        private void precoCompra_Leave(object sender, EventArgs e)
        {
            precoCompra.BackColor = Color.White;
        }

        private void descricao_Enter(object sender, EventArgs e)
        {
            descricao.BackColor = Color.Yellow;
        }

        private void descricao_Leave(object sender, EventArgs e)
        {
            descricao.BackColor = Color.White;
        }

        private void precoVenda_Enter(object sender, EventArgs e)
        {
            precoVenda.BackColor = Color.Yellow;
        }

        private void precoVenda_Leave(object sender, EventArgs e)
        {
            precoVenda.BackColor = Color.White;
        }

        private void quantidade_Enter(object sender, EventArgs e)
        {
            quantidade.BackColor = Color.Yellow;
        }

        private void quantidade_Leave(object sender, EventArgs e)
        {
            quantidade.BackColor = Color.White;
        }

        private void minimo_Enter(object sender, EventArgs e)
        {
            minimo.BackColor = Color.Yellow;
        }

        private void minimo_Leave(object sender, EventArgs e)
        {
            minimo.BackColor = Color.White;
        }

        private void cmbCategoriaProduto_Enter(object sender, EventArgs e)
        {
            cmbCategoriaProduto.BackColor = Color.Yellow;
        }

        private void cmbCategoriaProduto_Leave(object sender, EventArgs e)
        {
            cmbCategoriaProduto.BackColor = Color.White;
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

        #region Metodos Auxiliares

        private void CarregaCategoriaProduto()
        {
            cmbCategoriaProduto.DataSource = new CategoriaProdutoBL().GetAll();
            cmbCategoriaProduto.DisplayMember = "Descricao";
            cmbCategoriaProduto.ValueMember = "ID";
        }

        private void CarregaProdutos()
        {
            grdProdutos.DataSource = _produtoRepository.GetAll();
            FormataGrid();
        }

        private void OcultaCampo()
        {
            grdProdutos.Columns[0].Visible = false;
        }
        
        private void btnSalvar_Leave(object sender, EventArgs e)
        {
        }

        private void btnExcluir_Leave(object sender, EventArgs e)
        {
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
        }

        private void btnNovo_Leave(object sender, EventArgs e)
        {
        }

        private void btnAlterar_Leave(object sender, EventArgs e)
        {
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }

        

        #endregion

     
    }
}
