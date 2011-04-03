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
    public partial class frmCaixa :login
    {

        public frmCaixa()
        {
            InitializeComponent();
            
            CarregaProdutos();
        }

        public frmCaixa(Servico servico)
        {
            InitializeComponent();
            _servico = servico;
            SetConfiguracaoInicial();
        }

        private void SetConfiguracaoInicial()
        {
            CarregaProdutos();
            ProcuraServico(_servico.OrdemServico);
            CarregaCliente(_servico);
            CarregaItens(_servico);
        
           
            MudaNomeDoFormulario(_servico);
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            ordemServico.Text = _servico.OrdemServico.ToString();
            ordemServico.Focus();
        }

        private void ordemServico_Leave(object sender, EventArgs e)
        {
            PesquisaOrdemServico();
            ordemServico.BackColor = Color.White;
        }

        private void PesquisaOrdemServico()
        {
            try
            {
                int ordServico = int.Parse(ordemServico.Text);
                if (ordServico > 0)
                {
                    _servico = ProcuraServico(ordServico);
                    if (_servico.ID > 0)
                    {
                        CarregaCliente(_servico);
                        CarregaItens(_servico);
                        MudaNomeDoFormulario(_servico);
                       
                    }
                    else
                    {
                        MessageBox.Show("O.S. finalizada!", "Atenção");
                    }
                }
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

        private Servico ProcuraServico(int ordemServico)
        {
            var serv = new Servico();
            if (ordemServico == 0)
            {
                MessageBox.Show(Resources.OrdemServicoNaoEncontrada + this.ordemServico.Text, "Atenção");
                return serv;
            }
            serv.OrdemServico = ordemServico;
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
            checkBoxAcertoFuturo.Checked = Convert.ToBoolean(servicoQueSeraCarregado.AcertoFuturo);
        }

        private void MudaNomeDoFormulario(Servico servico)
        {
            this.Text = " Caixa Responsável: " + _servico.Usuario.Nome + " - " +
                " Número da O.S.: " + servico.OrdemServico;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ExisteServico())
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado, Resources.Atencao);
                return;
            }

            int qtde = int.Parse(quantidade.TextLength > 0 ? quantidade.Text : "0");
            qtde = qtde > 0 ? qtde : 1;

            CriaServicoItem(qtde);
            _servico = servicoBL.ByID(_servico);
            CarregaItens(_servico);
           
        }

        private void CriaServicoItem(int quantidadeItens)
        {
            var item = new ServicoItem();
            item.Produto.ID = int.Parse(cmbProduto.SelectedValue.ToString());
            item.Quantidade = quantidadeItens;
            item.Servico = this._servico;
            servicoBL.ItemAdd(item);
        }

        private void btnAlterarQuantidade_Click(object sender, EventArgs e)
        {
            AlterarQuantidade();
        }

        private void AlterarQuantidade()
        {
            _servicoItem = servicoBL.ItemID(_servicoItem);
            if (_servicoItem.Produto.CategoriaProduto.Descricao == "Serviço")
            {
                MessageBox.Show("Não é permitido alterar quantidade de serviço", "Atenção!");
                return;
            }

            if (_servicoItem.ID == 0)
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado + " Favor selecionar o correto", 
                    Resources.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            frmAlterarQuantidadeItem frmAlterarQuantidade = new frmAlterarQuantidadeItem(_servicoItem);
            frmAlterarQuantidade.ShowDialog();
            _servico = servicoBL.ByID(_servico);
            CarregaItens(_servico);
           
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdServico.Rows.Count > 0)
            {
                var id = grdServico.Rows[Validador.RetornaValorSelecionadoNoGrid(grdServico.CurrentRow)]
                    .Cells[0].Value.ToString();

                id = id.Length > 0 ? id : "0";
                _servicoItem.ID = int.Parse(id);
            }
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            ConcluirVenda();
            this.ordemServico.Focus();
        }

        private void ConcluirVenda()
        {
            if (!ExisteServico())
            {
                MessageBox.Show(Resources.Nenhum_servico_encontrado, Resources.Atencao);
                return;

            }

            _servico.Total = TotalServicos();
            _servico.Usuario = this.Usuario;
            VendaFormaPagamento frmFormaPagamento = new VendaFormaPagamento(_servico);
            frmFormaPagamento.ShowDialog();

            //ConcluirVenda();
            LimpaCampos();
            this.Text = "Caixa Livre ";
        }

        private void chbLavado_CheckedChanged(object sender, EventArgs e)
        {
            _servico.Lavado = Convert.ToInt32(chbLavado.Checked);
            servicoBL.CarroLavado(_servico);
        }

        private void checkBoxAcertoFuturo_CheckedChanged(object sender, EventArgs e)
        {
            _servico.AcertoFuturo = Convert.ToInt32(checkBoxAcertoFuturo.Checked);
            servicoBL.AcertoFuturo(_servico);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!IsServicoItem())
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ExcluirServicoItem();
            _servico = ProcuraServico(_servico.OrdemServico);
            CarregaItens(_servico);
        }

        private void ExcluirServicoItem()
        {
            frmExcluirServico frmExcluirServico = new frmExcluirServico();
            frmExcluirServico.ServicoItem = _servicoItem;
            frmExcluirServico.ShowDialog();
            

        }

        private bool IsServicoItem()
        {
            return (_servicoItem.ID > 0);
        }
        
        private bool ExisteServico()
        {
            return servicoBL.ExisteServico(this._servico);
        }

        private void LimpaCampos()
        {
            placa.Clear();
            veiculo.Clear();
            telefone.Clear();
            nome.Clear();
            corVeiculo.Clear();
            ordemServico.Clear();
            
            _servico = new Servico();
            grdServico.DataSource = null;
        }

        private void CarregaItens(Servico servico)
        {
            grdServico.DataSource = servicoBL.CriaGrid(servico);
            FormadaGrid();
        }

        private void FormadaGrid()
        {
            grdServico.Columns[0].Visible = false;
            grdServico.Columns[1].Width = 90;
            grdServico.Columns[2].Width = 80;
            grdServico.Columns[3].Width = 70;
            grdServico.Columns[4].Width = 70;
        }

        private void CarregaProdutos()
        {
            var produtoBl = new ProdutoBL();
            cmbProduto.DataSource = produtoBl.Categoria(EnumCategoriaProduto.Produto);
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.ValueMember = "ID";
        }

        private decimal TotalServicos()
        {
            decimal totalCompra = 0;
            for (var i = 0; i < grdServico.Rows.Count - 1; i++)
                totalCompra += Dinheiro.ParseToDecimal(grdServico.Rows[i].Cells[4].Value.ToString());

            return totalCompra;
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (!IsServicoItem())
            {
                MessageBox.Show(Resources.Nenhem_item_encontrado, Resources.Atencao, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            CancelarVenda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmServicoLavador servicoLavador = new frmServicoLavador(_servico);
            servicoLavador.ShowDialog();
            servicoLavador.Close();
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void CancelarVenda()
        {
            DialogResult res = MessageBox.Show(Resources.Deseja_cancelar_a_venda, Resources.Atencao,
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                frmCancelaOrdemServico frmCancelaOrdemServico = new frmCancelaOrdemServico();
                frmCancelaOrdemServico.ShowDialog();

                if (frmCancelaOrdemServico.User.ID > 0 &&
                frmCancelaOrdemServico.User.TipoFuncionario.Descricao == "Gerente")
                {
                    _servico.Cancelado = 1;
                    _servico.Usuario = this.Usuario;
                    
                    servicoBL.Cancela(_servico);
                    MessageBox.Show(Resources.Venda_cancelada, Resources.Atencao);
                }
                else
                {
                    MessageBox.Show("Usuário invalido!", "Atenção");
                }
            }
        }

        #region Eventos Auxiliares

        private void ChamaFuncoesDeCaixa(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    PesquisaOrdemServico();
                    break;
                case Keys.F2:
                    ConcluirVenda();
                    break;
                case Keys.F3:
                    AlterarQuantidade();
                    break;
                case Keys.F5:
                    ExcluirServicoItem();
                    break;
                case Keys.F6:
                    CancelarVenda();
                    break;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordemServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void convenio_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void cmbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void quantidade_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void cmbFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void totalServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void valor_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void desconto_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        private void grdServico_KeyDown(object sender, KeyEventArgs e)
        {
            ChamaFuncoesDeCaixa(e);
        }

        #endregion

        private void ordemServico_Enter(object sender, EventArgs e)
        {
            ordemServico.BackColor = Color.Yellow;
        }

        private void cmbProduto_Enter(object sender, EventArgs e)
        {
            cmbProduto.BackColor = Color.Yellow;
        }

        private void cmbProduto_Leave(object sender, EventArgs e)
        {
            cmbProduto.BackColor = Color.White;
        }

        private void quantidade_Enter(object sender, EventArgs e)
        {
            quantidade.BackColor = Color.Yellow;
        }

        private void quantidade_Leave(object sender, EventArgs e)
        {
            quantidade.BackColor = Color.White;
        }
    }
}
