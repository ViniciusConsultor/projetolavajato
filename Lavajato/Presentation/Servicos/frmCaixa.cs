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
    public partial class frmCaixa : login
    {
        private Servico servico = new Servico();
        private ServicoItem servicoItem = new ServicoItem();
        private ServicoBL servicoBL = new ServicoBL();

        private string enter = "\r\n";
        private string total;
        private string valorServico;
        private string descontoServico;
        private string trocoServico;


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
            CarregaConvenioDosClientes();
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

        private void CarregaConvenioDosClientes()
        {
            ConvenioBL convenioBL = new ConvenioBL();
            convenio.DataSource = convenioBL.GetAll();
            convenio.DisplayMember = "Nome";
            convenio.ValueMember = "ID";
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
            convenio.SelectedValue = servico.Cliente.Convenio.ID;
        }

        private Convenio SetUpConvenio()
        {
            return this.convenio.SelectedIndex > 0 ? new ConvenioBL().ByID(Convert.ToInt32(this.convenio.SelectedValue.ToString())) : new Convenio() { ID = 0 };
        }

        private void LimpaCampos()
        {
            placa.Clear();
            veiculo.Clear();
            telefone.Clear();
            nome.Clear();
            corVeiculo.Clear();
            ordemServico.Clear();
            valor.Clear();
            totalServico.Clear();
            desconto.Clear();
            troco.Clear();
            this.servico = new Servico();
            grdServico.DataSource = null;
        }

        private void CriaTabela(Servico servico)
        {
            grdServico.DataSource = servicoBL.CriaGrid(servico);
            FormadaGrid(grdServico);
        }

        private void FormadaGrid(DataGridView grdServico)
        {
            grdServico.Columns[0].Visible = false;
            grdServico.Columns[1].Width = 90;
            grdServico.Columns[2].Width = 80;
            grdServico.Columns[3].Width = 70;
            grdServico.Columns[4].Width = 70;
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
            desconto.Text = ValorDesconto().ToString("C").Replace("R$", "");
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
            ProdutoBL produtoBL = new ProdutoBL();
            cmbProduto.DataSource = produtoBL.TipoServico(EnumCategoriaProduto.Produto);
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

            if (!ExisteServico())
            {
                MessageBox.Show("Nenhum servico encontrado", "Atenção!");
                return;
            }

            CriaServicoItem();
            this.servico = servicoBL.ByID(this.servico);
            CriaTabela(this.servico);
        }

        private void CriaServicoItem()
        {
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto.ID = int.Parse(cmbProduto.SelectedValue.ToString());
            servicoItem.Quantidade = int.Parse(quantidade.Text);
            servicoItem.Servico = this.servico;
            servicoBL.ServicoItemInsert(servicoItem);
        }

        private void FazerVendaAvulsa()
        {
            if (this.servico.ID != 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Deseja fazer venda avulsa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                CriaServico();

        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
            new Configuracao().EmiteReciboPC(this.servico);

            LimpaCampos();
        }

        private void ConcluirVenda()
        {
            if (!ExisteServico())
            {
                MessageBox.Show("Nenhum serviço encontrado", "Atenção");
                return;
            }

            this.servico.Finalizado = 1;
            this.servico.Lavado = 1;
            this.servico.Pago = 1;
            this.servico.Total = Configuracao.ConverteParaDecimal(totalServico.Text);
            this.servico.SubTotal = Configuracao.ConverteParaDecimal(totalServico.Text);
            this.servico.Desconto = Configuracao.ConverteParaDecimal(desconto.Text);
            servicoBL.Update(this.servico);
        }

        private decimal ValorDesconto()
        {
            decimal valorTotalComDesconto = 0;
            foreach (var si in this.servico.ServicoItem)
            {
                if (si.Produto.CategoriaProduto.ID == (int)EnumCategoriaProduto.Servico)
                    valorTotalComDesconto += si.Quantidade * si.Produto.ValorUnitario;

            }

            if (this.servico.Cliente.Convenio.PorcentagemDesconto > 0)
                return valorTotalComDesconto * Math.Abs(this.servico.Cliente.Convenio.PorcentagemDesconto/100);
            else if (this.servico.Cliente.Convenio.Valor > 0)
                return valorTotalComDesconto - this.servico.Cliente.Convenio.Valor;

            return 0;
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
            if (!totalServico.Text.Contains(enter))
            {
                total = totalServico.Text;
            }
            else
            {
                totalServico.Text = total;
                valor.Focus();
            }
            
            
            if (totalServico.Text.Contains("."))
            {
                totalServico.Text = totalServico.Text.Remove(totalServico.Text.Length - 1);
                totalServico.SelectionStart = totalServico.Text.Length;
            }
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            if (!valor.Text.Contains(enter))
            {
                valorServico = valor.Text;
            }
            else
            {
                valor.Text = valorServico;
                desconto.Focus();
            }
            
            
            int num = 0;
            if (!int.TryParse(valor.Text, out num))
                return;

            
            if (valor.Text.Contains("."))
            {
                valor.Text = valor.Text.Remove(valor.Text.Length - 1);
                valor.SelectionStart = valor.Text.Length;
            }

            decimal valorText = Convert.ToDecimal(valor.TextLength > 0 ? valor.Text : "0" );
            decimal valorTotal = Convert.ToDecimal(totalServico.TextLength > 0 ? totalServico.Text : "0");
            if (valorText > valorTotal)
                troco.Text = (valorText - valorTotal).ToString("C").Replace("R$", "");
            else
                troco.Text = "";

        }

        private void desconto_TextChanged(object sender, EventArgs e)
        {

            if (!desconto.Text.Contains(enter))
            {
                descontoServico = desconto.Text;
            }
            else
            {
                desconto.Text = descontoServico;
                troco.Focus();
            }
            
            if (desconto.Text.Contains("."))
            {
                desconto.Text = desconto.Text.Remove(desconto.TextLength - 1);
                desconto.SelectionStart = desconto.Text.Length;
            }

            decimal descontoTemp = Convert.ToDecimal(desconto.TextLength > 0 ? desconto.Text : "0");
            decimal totalValor = ValorTotalCompra();

            if (totalValor == 0)
                return;

            if (descontoTemp <= totalValor)
                valor.Text = (totalValor - descontoTemp).ToString("C").Replace("R$", "");
            else
                valor.Text = ValorTotalCompra().ToString("C").Replace("R$", "")
; if (descontoTemp > totalValor)
            {
                MessageBox.Show("Desconto maior que o valor do produto!", "Atenção");
                desconto.Text = "";
                desconto.Focus();
            }
        }

        private void troco_TextChanged(object sender, EventArgs e)
        {
            if (!troco.Text.Contains(enter))
            {
                trocoServico = troco.Text;
            }
            else
            {
                troco.Text = trocoServico;
                btnConcluirVenda.Focus();
            }
            
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

            DialogResult res = MessageBox.Show("Deseja realmente apagar o item de pedido", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            servicoBL.ServicoItemDelete(this.servicoItem);
            this.servico = servicoBL.ByID(this.servico);
            CriaTabela(this.servico);
            MessageBox.Show("Item excluido");
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

            DialogResult res = MessageBox.Show("Deseja cancelar a venda", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            this.servico.Cancelado = 1;
            this.servicoBL.Update(this.servico);
            MessageBox.Show("Venda cancelada com sucesso!");
        }

        private void btnVendaAvulca_Click(object sender, EventArgs e)
        {
            FazerVendaAvulsa();
        }

        private void CriaServico()
        {
            this.servico.Cliente.ID = 69;
            this.servico.Usuario = this.Usuario;
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
            this.servico = servicoBL.Add(servico);
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
                CriaServico();
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

        private void acertoFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ExisteServico())
            {
                MessageBox.Show("Nenhum servico encontrado");
                return;
            }
            servico.AcertoFuturo = Convert.ToInt32(chbLavado.Checked.ToString());
            servicoBL.CarroLavado(servico);
        }

        private void chbLavado_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!ExisteServico())
            {
                MessageBox.Show("Nenhum servico encontrado");
                return;
            }

            servico.Lavado = Convert.ToInt32(chbLavado.Checked);
            servicoBL.CarroLavado(servico);
        }

        private void convenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.convenio.SelectedIndex == 0 || this.convenio.SelectedIndex == -1)
            {
                desconto.Text = "";
                return;
            }
            Convenio convenio = new ConvenioBL().ByID(int.Parse(this.convenio.SelectedValue.ToString()));
            this.servico.Cliente.Convenio = convenio;
            desconto.Text = ValorDesconto().ToString("C").Replace("R$", "");

            new ClienteBL().Update(this.servico.Cliente);
        } 
    }
}
