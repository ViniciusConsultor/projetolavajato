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
using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmCaixa : login
    {
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

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            ordemServico.Focus();
            CarregaConvenioDosClientes();
        }

        private void ordemServico_Leave(object sender, EventArgs e)
        {
            try
            {
                int ordServico = int.Parse(this.ordemServico.Text);
                this.servico = ProcuraServico(ordServico);
                CarregaCliente(this.servico);
                CriaTabela(this.servico);
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(Resources.SomenteNumeros + " " + ex.Message, Resources.Atencao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Favor preencher o campo de pesquisa!" + " " + ex.Message, Resources.Atencao);
            }
            
        }

        private Servico ProcuraServico(int ordemServicoProcurada)
        {
            var serv = new Servico();
            if (ordemServicoProcurada == 0)
            {
                MessageBox.Show(Resources.OrdemServicoNaoEncontrada + this.ordemServico.Text, "Atenção");
                return serv;
            }
            serv.OrdemServico = ordemServicoProcurada;
            serv = servicoBL.ByOrdemServico(serv);
            return serv;
        }

        private void CarregaCliente(Servico servicoQueSeraCarregado)
        {
            placa.Text = servicoQueSeraCarregado.Cliente.Placa;
            veiculo.Text = servicoQueSeraCarregado.Cliente.Veiculo;
            telefone.Text = servicoQueSeraCarregado.Cliente.Telefone;
            nome.Text = servicoQueSeraCarregado.Cliente.Nome;
            corVeiculo.Text = servicoQueSeraCarregado.Cliente.Cor;
            chbLavado.Checked = Convert.ToBoolean(servicoQueSeraCarregado.Lavado);
            convenio.SelectedValue = servicoQueSeraCarregado.Cliente.Convenio.ID;
            cmbLavador.SelectedValue = servicoQueSeraCarregado.Lavador;
            this.cmbLavador.SelectedValue = servicoQueSeraCarregado.Lavador;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (quantidade.TextLength == 0)
            {
                MessageBox.Show(Resources.Inserir_quantidade_valida, Resources.Atencao);
                return;
            }

            if (!ExisteServico())
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado, Resources.Atencao);
                return;
            }

            CriaServicoItem();
            servico = servicoBL.ID(servico);
            CriaTabela(servico);
        }

        private void btnAlterarQuantidade_Click(object sender, EventArgs e)
        {
            AlterarQuantidade();
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdServico.CurrentRow != null)
                this.servicoItem.ID = int.Parse(grdServico.Rows[grdServico.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
            LimpaCampos();
        }

        private void totalServico_TextChanged(object sender, EventArgs e)
        {
            if (totalServico.Text.Contains(enter))
            {
                totalServico.Text = total;
                valor.Focus();
            }
            else
            {
                total = totalServico.Text;
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


            var num = 0;
            if (!int.TryParse(valor.Text, out num))
                return;


            if (valor.Text.Contains("."))
            {
                valor.Text = valor.Text.Remove(valor.Text.Length - 1);
                valor.SelectionStart = valor.Text.Length;
            }

            var valorText = Convert.ToDecimal(valor.TextLength > 0 ? valor.Text : "0");
            var valorTotal = Convert.ToDecimal(totalServico.TextLength > 0 ? totalServico.Text : "0");
            troco.Text = valorText > valorTotal ? (valorText - valorTotal).ToString("C").Replace("R$", "") : "";

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

            var descontoTemp = Convert.ToDecimal(desconto.TextLength > 0 ? desconto.Text : "0");
            var totalValor = ValorTotalCompra();

            if (totalValor != 0)
            {
                valor.Text = descontoTemp <= totalValor
                                 ? (totalValor - descontoTemp).ToString("C").Replace("R$", "")
                                 : ValorTotalCompra().ToString("C").Replace("R$", "");
                if (descontoTemp > totalValor)
                {
                    MessageBox.Show(Resources.Desconto_maior_que_valor_produto, Resources.Atencao);
                    desconto.Text = "";
                    desconto.Focus();
                }
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
            if (!chbLavado.Checked)
            {
                servico.Lavado = 0;
                servicoBL.Update(servico);
            }
            else
            {
                servico.Lavado = 1;
                servicoBL.Update(servico);
                return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirItem();
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor.Text = "";
            switch (cmbFormaPagamento.SelectedIndex)
            {
                case 0:
                    desconto.Enabled = true;
                    troco.Enabled = true;
                    break;
                default:
                    desconto.Enabled = false;
                    troco.Enabled = false;
                    valor.Text = totalServico.Text;
                    break;
            }
        }        
        
        private void acertoFuturo_CheckedChanged(object sender, EventArgs e)
        {
            if (ExisteServico())
            {
                servico.AcertoFuturo = Convert.ToInt32(chbLavado.Checked.ToString());
                servicoBL.CarroLavado(servico);
            }
            else
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado);
                return;
            }
        }

        private void chbLavado_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ExisteServico())
            {
                servico.Lavado = Convert.ToInt32(chbLavado.Checked);
                servicoBL.CarroLavado(servico);
            }
            else
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado);
                return;
            }
        }

        private void convenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.convenio.SelectedIndex == 0 || this.convenio.SelectedIndex == -1)
            {
                desconto.Text = "";
                return;
            }

            var convenioDoCliente = new ConvenioBL().ByID(int.Parse(this.convenio.SelectedValue.ToString()));
            servico.Cliente.Convenio = convenioDoCliente;
            desconto.Text = ValorDesconto().ToString("C").Replace("R$", "");

            new ClienteBL().Update(this.servico.Cliente);
        }

        private void cmbLavador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLavador.SelectedIndex == 0 || this.cmbLavador.SelectedIndex == -1) return;
            
            servico.Lavador = int.Parse(cmbLavador.SelectedValue.ToString());
            servicoBL.Update(this.servico);
        }

        private void CarregaConvenioDosClientes()
        {
            var convenioBl = new ConvenioBL();
            convenio.DataSource = convenioBl.GetAll();
            convenio.DisplayMember = "Nome";
            convenio.ValueMember = "ID";
        }

        private bool ExisteServico()
        {
            return servicoBL.ExisteServico(this.servico);
        }

        private void CarregaLavadores()
        {
            cmbLavador.DataSource = new UsuarioBL().GetUsuarioTipoLavador();
            cmbLavador.DisplayMember = "Nome";
            cmbLavador.ValueMember = "ID";
        }

        private Convenio SetUpConvenio()
        {
            return convenio.SelectedIndex > 0 ? new ConvenioBL().ByID(Convert.ToInt32(this.convenio.SelectedValue.ToString())) : new Convenio() { ID = 0 };
        }

        private void LimpaCampos()
        {
            placa.Clear();
            veiculo.Clear();
            telefone.Clear();
            nome.Clear();
            corVeiculo.Clear();
            ordemServico.Clear();
            valor.Text = "";
            totalServico.Clear();
            desconto.Clear();
            troco.Clear();
            servico = new Servico();
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
            
            totalServico.Text = ValorTotalCompra().ToString();
            this.cmbFormaPagamento.SelectedIndexChanged += cmbFormaPagamento_SelectedIndexChanged;
            desconto.Text = ValorDesconto().ToString("C").Replace("R$", "");
        }

        private void AlterarQuantidade()
        {
            SetUpServicoItem(servicoItem);
            var frmAlterarQuantidade = new frmAlterarQuantidadeItem(this.servicoItem);
            frmAlterarQuantidade.ShowDialog();
            servico = servicoBL.ID(servico);
            CriaTabela(servico);
        }

        private ServicoItem SetUpServicoItem(ServicoItem servicoItemParaCarregar)
        {
            if (this.servicoItem.ID != 0)
            {
                this.servicoItem = servicoBL.ItemID(servicoItemParaCarregar);
                if (this.servicoItem.ID == 0)
                {
                    MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao, MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return new ServicoItem();
                }

                return servicoItemParaCarregar;
            }

            MessageBox.Show(Resources.Nenhem_item_selecionado, Resources.Atencao);
            return new ServicoItem();
        }

        private void CarregaProdutos()
        {
            var produtoBl = new ProdutoBL();
            cmbProduto.DataSource = produtoBl.TipoServico(EnumCategoriaProduto.Produto);
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.ValueMember = "ID";
        }

        private void CarregaFormaPagamento()
        {
            cmbFormaPagamento.DataSource = new FormaPagamentoBL().GetAll();
            cmbFormaPagamento.DisplayMember = "Descricao";
            cmbFormaPagamento.ValueMember = "ID";
        }

        private void CriaServicoItem()
        {
            var item = new ServicoItem();
            item.Produto.ID = int.Parse(cmbProduto.SelectedValue.ToString());
            item.Quantidade = int.Parse(quantidade.Text);
            item.Servico = this.servico;
            servicoBL.ItemAdd(item);
        }

        private void FazerVendaAvulsa()
        {
            if (this.servico.ID == 0)
            {
                var result = MessageBox.Show(Resources.frmCaixa_VendaAvulsa, Resources.Atencao, MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                    CriaServico();
            }
        }

        private void ConcluirVenda()
        {
            if (!ExisteServico())
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado, Resources.Atencao);
                return;
            }

            this.servico.Finalizado = 1;
            this.servico.Lavado = 1;
            this.servico.Pago = 1;
            this.servico.FormaPagamento = ((FormaPagamento)(cmbFormaPagamento.SelectedItem));
            this.servico.Lavador = cmbLavador.SelectedValue == null ? 0 : int.Parse(cmbLavador.SelectedValue.ToString());
            this.servico.Total = Configuracao.ConverteParaDecimal(totalServico.Text);
            this.servico.SubTotal = Configuracao.ConverteParaDecimal(totalServico.Text);
            this.servico.Desconto = Configuracao.ConverteParaDecimal(desconto.Text);
            servicoBL.Update(this.servico);

            new ClienteBL().Update(this.servico.Cliente);
        }

        private decimal ValorDesconto()
        {
            var valorTotalComDesconto = this.servico.ServicoItem.Where(
                si => si.Produto.CategoriaProduto.ID == (int) EnumCategoriaProduto.Servico).Sum(
                si => si.Quantidade*si.Produto.ValorUnitario);

            if (this.servico.Cliente.Convenio.PorcentagemDesconto > 0)
            {
                var valTotal = Configuracao.ConverteParaDecimal( this.totalServico.Text);
                var desc = valorTotalComDesconto * Math.Abs(this.servico.Cliente.Convenio.PorcentagemDesconto / 100);
                this.valor.Text = (valTotal - desc).ToString("C").Replace("R$", "");
                return desc;
            }
            else if (this.servico.Cliente.Convenio.Valor > 0)
            {
                return valorTotalComDesconto - this.servico.Cliente.Convenio.Valor;
            }
            return 0;
        }

        private decimal ValorTotalCompra()
        {

            decimal totalCompra = 0;
            for (var i = 0; i < grdServico.Rows.Count - 1; i++)
                totalCompra += Configuracao.ConverteParaDecimal(grdServico.Rows[i].Cells[4].Value.ToString());

            return totalCompra;
        }

        private void ExcluirItem()
        {
            if (this.servicoItem.ID == 0)
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show(Resources.Apagar_o_item_de_pedido, Resources.Atencao, MessageBoxButtons.YesNo);
            if (res != DialogResult.No)
            {
                servicoBL.ItemDelete(this.servicoItem);
                this.servico = servicoBL.ID(this.servico);
                CriaTabela(this.servico);
                MessageBox.Show(Resources.Item_deletado);
            }
        }

        private void CancelarVenda()
        {
            if (this.servicoItem.ID == 0)
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult res = MessageBox.Show(Resources.Deseja_cancelar_a_venda, Resources.Atencao, MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            this.servico.Cancelado = 1;
            this.servicoBL.Update(this.servico);
            MessageBox.Show(Resources.Venda_cancelada);
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

        private void FormataGridView()
        {
            
            
            
        }

        private void ordemServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeVenda(e); 
        }

        private void ChamaFuncoesDeVenda(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    ConcluirVenda();
                    break;
                case Keys.F3:
                    AlterarQuantidade();
                    break;
                case Keys.F4:
                    CriaServico();
                    break;
                case Keys.F5:
                    ExcluirItem();
                    break;
                case Keys.F6:
                    CancelarVenda();
                    break;
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void btnVendaAvulca_Click(object sender, EventArgs e)
        {
            FazerVendaAvulsa();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ServicoLavador servicoLavador = new ServicoLavador();
            servicoLavador.ShowDialog();
            servicoLavador.Close();
        }

    }
}
