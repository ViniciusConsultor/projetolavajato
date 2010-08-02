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
    public partial class frmCaixa : Form
    {
        private Servico servico = new Servico();
        private ServicoItem servicoItem = new ServicoItem();
        private ServicoBL servicoBL = new ServicoBL();

        public frmCaixa()
        {
            InitializeComponent();
            CarregaProdutos();
            CarregaLavadores();
            CarregaFormaPagamento();
            ordemServico.Focus();
        }

        public frmCaixa(Servico servico)
        {
            InitializeComponent();
            CarregaProdutos();
            CarregaLavadores();
            CarregaFormaPagamento();
            ProcuraServico(servico.OrdemServico);
            
        }

        private void CarregaLavadores()
        {
            cmbLavador.DataSource = new UsuarioBL().GetUsuarioTipoLavador();
            cmbLavador.DisplayMember = "Nome";
            cmbLavador.ValueMember = "ID";
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            ordemServico.Focus();
        }

      

        private void ProcuraServico(int ordemServico)
        {
            if (ordemServico == 0)
                return;

            this.servico.OrdemServico = ordemServico;
            this.servico = servicoBL.ByOrdemServico(servico);

            if (!ExisteServico())
            {
                MessageBox.Show("Nenhum ordem servico aberta com esse número!", "Atenção");
                LimpaCampos();
                return;
            }
            else
            {
                //ordem de serviço avulça
            }

            CarregaCliente(this.servico);
            CriaTabela(this.servico);
        }

        private bool ExisteServico()
        {
            return servicoBL.ExisteServico(this.servico);
        }

        private void CarregaCliente(Servico servico)
        {
            placa.Text = servico.Cliente.Placa;
            veiculo.Text = servico.Cliente.Veiculo;
            telefone.Text = servico.Cliente.Telefone;
            nome.Text = servico.Cliente.Nome;
            corVeiculo.Text = servico.Cliente.Cor;
            chbLavado.Checked = Convert.ToBoolean(servico.Lavado);
        }

        private void LimpaCampos()
        {
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            corVeiculo.Text = "";
            ordemServico.Text = "";
            this.servico = new Servico();
            grdServico.DataSource = null;
        }

        private void CriaTabela(Servico servico)
        {
            grdServico.DataSource = ServicoBL.CriaGrid(servico);
            FormadaGrid(grdServico);
        }

        private void FormadaGrid(DataGridView grdServico)
        {
            for (int i = 0; i < grdServico.Rows.Count; i++)
            {
                decimal div = (i % 2);
                if (div == 0)
                {
                    grdServico.BackgroundColor = System.Drawing.Color.AntiqueWhite;
                }
            }
            totalServico.Text = ValorTotalCompra().ToString();
            this.cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;
        }

        private void btnAlterarQuantidade_Click(object sender, EventArgs e)
        {
            AlterarQuantidade();
        }

        private void AlterarQuantidade()
        {
            SetUpServicoItem(this.servicoItem);
            frmAlterarQuantidadeItem frmAlterarQuantidade = new frmAlterarQuantidadeItem(this.servicoItem);
            frmAlterarQuantidade.ShowDialog();
            this.servico = servicoBL.ByID(this.servico);
            CriaTabela(this.servico);
        }

        private ServicoItem SetUpServicoItem(ServicoItem servicoItem)
        {
            if (this.servicoItem.ID == 0)
            {
                MessageBox.Show("Nenhem item selecionado para alteração", "Atenção");
                return new ServicoItem();
            }

            this.servicoItem = servicoBL.ByServicoItemID(servicoItem);
            if (this.servicoItem.ID == 0)
            {
                MessageBox.Show("Nenhem item encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new ServicoItem();
            }

            return servicoItem;
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            this.servicoItem.ID = int.Parse(grdServico.Rows[grdServico.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void CarregaProdutos()
        {
            cmbProduto.DataSource = new ProdutoBL().TipoServico(EnumCategoriaProduto.Produto);
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.ValueMember = "ID";
        }

        private void CarregaFormaPagamento()
        {
            cmbFormaPagamento.DataSource = new FormaPagamentoBL().GetAll();
            cmbFormaPagamento.DisplayMember = "Descricao";
            cmbFormaPagamento.ValueMember = "ID";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (quantidade.TextLength == 0)
            {
                MessageBox.Show("Favor inserir uma quantidade valida!", "Atenção");
                return;
            }

            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto = ((Produto)cmbProduto.SelectedItem);
            servicoItem.Quantidade = int.Parse( quantidade.Text);
            servicoItem.Servico = this.servico;
            servicoBL.ServicoItemInsert(servicoItem);
            
            this.servico = servicoBL.ByID(this.servico);
            CriaTabela(this.servico);
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
            //imprime copom

            LimpaCampos();
        }

        private void ConcluirVenda()
        {
            if (ExisteServico())
            {
                MessageBox.Show("Nenhum serviço encontrado", "Atenção");
                return;
            }

            this.servico.Finalizado = 1;
            this.servico.Lavado = 1;
            this.servico.Total = Configuracao.ConverteParaDecimal(totalServico.Text);
            this.servico.SubTotal = Configuracao.ConverteParaDecimal(totalServico.Text);
            this.servico.Desconto = Configuracao.ConverteParaDecimal(desconto.Text);
            servicoBL.Update(this.servico);
        }

        private decimal ValorTotalCompra()
        {
            decimal total = 0;
            for (int i = 0; i < grdServico.Rows.Count - 1; i++)
                total += Configuracao.ConverteParaDecimal(grdServico.Rows[i].Cells[4].Value.ToString());
            
            return total;
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor.Text = "";
            if (cmbFormaPagamento.SelectedIndex == 0)
            {
                desconto.Enabled = true;
                troco.Enabled = true;
            }
            else
            {
                desconto.Enabled = false;
                troco.Enabled = false;
                valor.Text = totalServico.Text;
            }
        }

        private void totalServico_TextChanged(object sender, EventArgs e)
        {
            if (totalServico.Text.Contains("."))
            {
                totalServico.Text = totalServico.Text.Remove(totalServico.Text.Length - 1);
                totalServico.SelectionStart = totalServico.Text.Length;
            }
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            if (valor.Text.Contains("."))
            {
                valor.Text = valor.Text.Remove(valor.Text.Length - 1);
                valor.SelectionStart = valor.Text.Length;
            }

            decimal valorText = Convert.ToDecimal(valor.TextLength > 0 ? valor.Text : "0" );
            decimal valorTotal = Convert.ToDecimal(totalServico.TextLength > 0 ? totalServico.Text : "0");
            if (valorText > valorTotal)
                troco.Text = (valorText - valorTotal).ToString();
            else
                troco.Text = "";
        }

        private void desconto_TextChanged(object sender, EventArgs e)
        {
            if (desconto.Text.Contains("."))
            {
                desconto.Text = desconto.Text.Remove(desconto.TextLength - 1);
                desconto.SelectionStart = desconto.Text.Length;
            }

            decimal descontoTxt = Convert.ToDecimal(desconto.TextLength > 0 ? desconto.Text : "0");
            decimal totalValor = ValorTotalCompra();

            if (totalValor == 0)
                return;

            if (descontoTxt <= totalValor)
                totalServico.Text = (totalValor - descontoTxt).ToString();
            else
                totalServico.Text = ValorTotalCompra().ToString();

            if (descontoTxt > totalValor)
            {
                MessageBox.Show("Desconto maior que o valor do produto!", "Atenção");
                desconto.Text = "";
                desconto.Focus();
            }
        }

        private void troco_TextChanged(object sender, EventArgs e)
        {
            if (troco.Text.Contains("."))
            {
                troco.Text = troco.Text.Remove(troco.Text.Length - 1);
                troco.SelectionStart = troco.Text.Length;
            }
        }

        private void chbLavado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLavado.Checked)
            {
                this.servico.Lavado = 1;
                this.servicoBL.Update(this.servico);
                return;
            }

            this.servico.Lavado = 0;
            this.servicoBL.Update(this.servico);
                
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirItem();
        }

        private void ExcluirItem()
        {
            if (this.servicoItem.ID == 0)
            {
                MessageBox.Show("Nenhem item encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            servicoBL.ServicoItemDelete(this.servicoItem);
            this.servico = servicoBL.ByID(this.servico);
            CriaTabela(this.servico);
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void CancelarVenda()
        {
            if (this.servicoItem.ID == 0)
            {
                MessageBox.Show("Nenhem item encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.servico.Cancelado = 1;
            this.servicoBL.Update(this.servico);
        }

        private void btnVendaAvulca_Click(object sender, EventArgs e)
        {
            VendaAvulsa();
        }

        private void VendaAvulsa()
        {
            DialogResult result = MessageBox.Show("Deseja realmente fazer uma venda avulsa?", "Venda avulça", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                return;
            }

            LimpaCampos();
            this.servico.Cliente.ID = 16;

            this.servico.Cliente = servico.Cliente;
            this.servico.Total = 0;
            this.servico.SubTotal = 0;
            this.servico.Desconto = 0;
            this.servico.Entrada = DateTime.Now;
            this.servico.Saida = DateTime.Now;
            this.servico.OrdemServico = 000;
            this.servico.FormaPagamento.ID = 1;

            this.servico.Cancelado = 0;
            this.servico.Delete = 0;
            this.servico.Finalizado = 0;
            this.servico.Lavado = 0;
            this.servico = servicoBL.Add(this.servico);
        }

        private void ordemServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e); 
        }

        private void ChamaFuncoesDeVenda(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ConcluirVenda();
            else if (e.KeyCode == Keys.F3)
                AlterarQuantidade();
            else if (e.KeyCode == Keys.F4)
                VendaAvulsa();
            else if (e.KeyCode == Keys.F5)
                ExcluirItem();
            else if (e.KeyCode == Keys.F6)
                CancelarVenda();
        }

        private void frmCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void cmbLavador_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void totalServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void cmbFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void desconto_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void troco_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void btnConcluirVenda_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void cmbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void btnVendaAvulca_KeyUp(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e);
        }

        private void ordemServico_Leave(object sender, EventArgs e)
        {
            int ordServico;
            if (int.TryParse(this.ordemServico.Text, out ordServico))
                ProcuraServico(ordServico);
        }
        
    }
}
