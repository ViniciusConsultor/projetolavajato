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
using HenryCorporation.Lavajato.Presentation.Properties;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmVendaAvulsa : login
    {
        private ServicoBL _servicoBL = new ServicoBL();
        private Servico _servico = new Servico();
        private ProdutoBL _produtoBL = new ProdutoBL();
        private string enter = "\r\n";
        private int _indexRow = 0;

        public frmVendaAvulsa()
        {
            InitializeComponent();
        }

        private void frmVendaAvulsa_Load(object sender, EventArgs e)
        {
            lblOperador.Text = _servicoBL.NomeDoUsuario(this.Usuario);
            CarregaProdutos();
            CarregaFormaPagamento();
        }

        private void CarregaProdutos()
        {
            var produtoBl = new ProdutoBL();
            cmbProduto.DataSource = produtoBl.Categoria(EnumCategoriaProduto.Produto);
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.ValueMember = "ID";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int qtde = (txtQuantidade.TextLength > 0 
                ? int.Parse(txtQuantidade.Text) : 1);

            CriaServicoItem(qtde);
            CarregaGrid(_servico);
            FormataGrid();
            SetUpValorTotal();
        }

        private void SetUpValorTotal()
        {
            txtTotal.Text = ValorTotalCompra().ToString();
        }

        private void CriaServicoItem(int quantidadeItens)
        {
            ServicoItem item = new ServicoItem();
            item.Produto = _produtoBL.ByID(FindProduto());
            item.Quantidade = quantidadeItens;
            _servico.ServicoItem.Add(item);
        }

        private Produto FindProduto()
        {
            return new Produto() { ID = int.Parse(cmbProduto.SelectedValue.ToString()) };
        }

        private void CarregaGrid(Servico servico)
        {
            grdServico.DataSource = _servicoBL.CriaGrid(servico);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            var res = MessageBox.Show(Resources.Apagar_item_de_pedido, 
                Resources.Atencao, MessageBoxButtons.YesNo);

            try
            {
                if (res == DialogResult.Yes)
                {
                    var delServico = _servico.ServicoItem[_indexRow];
                    _servico.ServicoItem.Remove(delServico);
                    CarregaGrid(_servico);
                    FormataGrid();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Produto inexistente ", Resources.Atencao);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro: Favor chamar o administrador do sistema ", Resources.Atencao);
            }
            
        }

        private void btnAlterarQuantidade_Click(object sender, EventArgs e)
        {
            try
            {
                var servicoItem = _servico.ServicoItem[_indexRow];

                var frmAlterarQuantidadeItem = new frmAlterarQuantidadeItem(servicoItem);
                frmAlterarQuantidadeItem.ShowDialog();

                _servico.ServicoItem[_indexRow] = frmAlterarQuantidadeItem.ServicoItem;
                CarregaGrid(_servico);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Erro: Seleciona corretamente ", Resources.Atencao);
            }
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            _indexRow = grdServico.CurrentRow.Index;
        }

        private void FormataGrid()
        {
            grdServico.Columns[0].Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            List<ServicoItem> servItemBack = _servico.ServicoItem;
            _servico = SetUpServico();
            _servico = _servicoBL.Add(_servico);
            _servico.ServicoItem = servItemBack;
            _servicoBL.ItemAdd(_servico);
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            _servico = new Servico();
            grdServico.DataSource = null;
        }

        private Servico SetUpServico()
        {
            _servico.Cliente.ID = 72;
            _servico.Usuario =  this.Usuario;
            _servico.Total = ValorTotalCompra();
            _servico.SubTotal = ValorTotalCompra();
            _servico.Desconto = 0;
            _servico.Entrada = DateTime.Now;
            _servico.Saida = DateTime.Now;
            _servico.OrdemServico = 000;
            _servico.FormaPagamento.ID = 1;

            _servico.Cancelado = 0;
            _servico.Delete = 0;
            _servico.Finalizado = 1;
            _servico.Lavado = 1;

            return _servico;
        }

        private decimal ValorTotalCompra()
        {
            decimal totalCompra = 0;
            for (var i = 0; i < grdServico.Rows.Count - 1; i++)
                totalCompra += Configuracao.ConverteParaDecimal(grdServico.Rows[i].Cells[4].Value.ToString());

            return totalCompra;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.TextLength == 0)
            {
                txtTroco.Text = "";
                txtDesconto.Text = "";
                return;

            }

            if (txtValor.Text.Contains("."))
            {
                txtValor.Text = txtValor.Text.Remove(txtValor.Text.Length - 1);
                txtValor.SelectionStart = txtValor.Text.Length;
            }

            var valorTemp = txtValor.Text;
            decimal valorNum = 0;
            if (valorTemp.Length > 0)
                valorNum = Convert.ToDecimal(valorTemp);


            var valorTotal = txtTotal.Text;
            decimal totalTemp = 0;
            if (valorTotal.Length > 0)
                totalTemp = Convert.ToDecimal(txtTotal.Text);

            txtTroco.Text = decimal.Subtract(valorNum, totalTemp).ToString();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text.Contains("."))
            {
                txtDesconto.Text = txtDesconto.Text.Remove(txtDesconto.TextLength - 1);
                txtDesconto.SelectionStart = txtDesconto.Text.Length;
            }

            decimal totalServicoTemp = ValorTotalCompra();
            decimal descontoTemp = ServicoBL.ConverteParaDecimal(txtDesconto.Text);
            if (descontoTemp == 0)
            {
                txtTotal.Text = totalServicoTemp.ToString();
                txtValor.Text = txtValor.Text;
                txtTroco.Text = "";

                return;
            }

            if (descontoTemp > totalServicoTemp)
            {
                MessageBox.Show(Resources.Desconto_maior_que_valor_produto, Resources.Atencao);
                txtDesconto.Text = "";
            }

            var valorTemp = decimal.Subtract(totalServicoTemp, descontoTemp).ToString();

            if (txtValor.TextLength == 0)
            {
                txtTotal.Text = (totalServicoTemp - descontoTemp).ToString();
            }

            if (!string.IsNullOrEmpty(txtTroco.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(txtDesconto.Text.Trim()))
                {
                    txtTroco.Text = (ServicoBL.ConverteParaDecimal(txtTroco.Text) - ServicoBL.ConverteParaDecimal(txtDesconto.Text)).ToString();
                    txtValor.Text = txtValor.Text;
                    txtTotal.Text = decimal.Subtract(totalServicoTemp, descontoTemp).ToString();
                }
            }
        }

        private void CarregaFormaPagamento()
        {
            cmbFormaPagamento.DataSource = new FormaPagamentoBL().GetAll();
            cmbFormaPagamento.DisplayMember = "Descricao";
            cmbFormaPagamento.ValueMember = "ID";
        }

        private void FocoVaiParaValor()
        {
            if (txtTotal.Text.Contains(enter))
            {
                txtTotal.Text = _servicoBL.RetiraCifraoDaMoedaReal(ValorTotalCompra());
                txtValor.Focus();
            }
            else
            {
                //total = totalServico.Text;
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            FocoVaiParaValor();
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValor.Text = "";
            switch (cmbFormaPagamento.SelectedIndex)
            {
                case 0:
                    txtValor.Enabled = true;
                    txtDesconto.Enabled = true;
                    break;
                default:
                    txtDesconto.Enabled = false;
                    txtValor.Enabled = false;
                    txtValor.Text = txtTotal.Text;
                    break;
            }
        }

        private void cmbProduto_Enter(object sender, EventArgs e)
        {
            cmbProduto.BackColor = Color.Yellow;
        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            cmbProduto.BackColor = Color.White;
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            txtQuantidade.BackColor = Color.Yellow;
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            txtQuantidade.BackColor = Color.White;
        }

        private void cmbFormaPagamento_Enter(object sender, EventArgs e)
        {
            cmbFormaPagamento.BackColor = Color.Yellow;
        }

        private void cmbFormaPagamento_Leave(object sender, EventArgs e)
        {
            cmbFormaPagamento.BackColor = Color.White;
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            txtTotal.BackColor = Color.Yellow;
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            txtTotal.BackColor = Color.White;
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.Yellow;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.White;
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            txtDesconto.BackColor = Color.Yellow;
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            txtDesconto.BackColor = Color.White;
        }

        private void txtTroco_Enter(object sender, EventArgs e)
        {
            txtTroco.BackColor = Color.Yellow;
        }

        private void txtTroco_Leave(object sender, EventArgs e)
        {
            txtTroco.BackColor = Color.White;
        }
    }
}
