using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HenryCorporation.Lavajato.Presentation;

namespace Presentation
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClientePesquisa = new frmClientePesquisa();
            frmClientePesquisa.ShowDialog();
        }

        private void categoriaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProduto = new frmProduto();
            frmProduto.ShowDialog();
        }

        private void procuraProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProdutoPesquisa = new frmProdutoPesquisa();
            frmProdutoPesquisa.ShowDialog();
        }

        private void cadatroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void procuraUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUsuarioPesquisa = new frmUsuarioPesquisa();
            frmUsuarioPesquisa.ShowDialog();
        }

        private void ordemServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmOrdemServico = new frmOrdemServico();
            frmOrdemServico.ShowDialog();
        }

        private void retiradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmRetirada = new frmRetirada();
            frmRetirada.ShowDialog();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmEntra = new frmEntrada();
            frmEntra.ShowDialog();
        }

        private void lavadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConvenios = new frmConvenios();
            frmConvenios.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ordemServicoAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void credorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCredor = new frmCredor();
            frmCredor.ShowDialog();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmpesquisacontas = new frmPesquisaContasAPagar();
            frmpesquisacontas.ShowDialog();
        }

        private void fechamentoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFechamentoCaixa = new frmFechamentoCaixa();
            frmFechamentoCaixa.ShowDialog();
        }

        private void produtoAbaixoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void carrosLavadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEntra = new frmEntrada();
            frmEntra.ShowDialog();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmRetirada = new frmRetirada();
            frmRetirada.ShowDialog();
        }

        private void clientePorPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientePesquisaPorPlaca cliePesquisa = new frmClientePesquisaPorPlaca();
            cliePesquisa.ShowDialog();
        }

        private void servicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmCaixa = new frmCaixa();
            frmCaixa.ShowDialog();
        }

        private void produtosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProdutoInternos = new frmProdutosInternos();
            frmProdutoInternos.ShowDialog();
        }

        private void lavagemPorLavadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlavPorLavador = new frmLavagensPorLavador();
            frmlavPorLavador.ShowDialog();
        }

        private void fechamentoDeCaixaPorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vendasDiarias = new frmVendasDiarias();
            vendasDiarias.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trocarUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterLogin = new frmMasterLogin();
            masterLogin.ShowDialog();
        }

        private void incluirLavadorNoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcuraServicoPorPlaca frmProcuraServicoPorPlaca = new frmProcuraServicoPorPlaca();
            frmProcuraServicoPorPlaca.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCaixa frmcaixa = new frmCaixa();
            frmcaixa.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmProduto frmproduto = new frmProduto();
            frmproduto.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduto frmproduto = new frmProduto();
            frmproduto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCaixa frmcaixa = new frmCaixa();
            frmcaixa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario();
            frmusuario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendaAvulsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaAvulsa frmVendaAvulsa = new frmVendaAvulsa();
            frmVendaAvulsa.ShowDialog();
        }

        private void proudutoAbaixoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPAE = new frmProdutoAbaixoEstoque();
            frmPAE.ShowDialog();
        }

        private void produtoEmEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frmproduto = new frmProdutos();
            frmproduto.ShowDialog();
        }

        private void carrosNoLavajatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarrosNoLavajato frmcarrosnolavajato = new frmCarrosNoLavajato();
            frmcarrosnolavajato.ShowDialog();
        }

        private void serviçoPorOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicoPorOS frmServicoPorOS = new frmServicoPorOS();
            frmServicoPorOS.ShowDialog();
        }

        private void cancelaServiçoFinalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcuraServicoPorOS frmProcuraServicoPorOS = new frmProcuraServicoPorOS();
            frmProcuraServicoPorOS.ShowDialog();
        }

        private void serviçoCanceladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicoCanceladoPorUsuario frmServicoCanceladoPorUsuario = new frmServicoCanceladoPorUsuario();
            frmServicoCanceladoPorUsuario.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmContasAPagar = new frmContasAPagar();
            frmContasAPagar.ShowDialog();
        }
    }
}
