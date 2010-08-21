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
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientePesquisa frmClientePesquisa = new frmClientePesquisa();
            frmClientePesquisa.ShowDialog();
        }

        private void categoriaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.ShowDialog();
        }

        private void procuraProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoPesquisa frmProdutoPesquisa = new frmProdutoPesquisa();
            frmProdutoPesquisa.ShowDialog();
        }

        private void cadatroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void procuraUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioPesquisa frmUsuarioPesquisa = new frmUsuarioPesquisa();
            frmUsuarioPesquisa.ShowDialog();
        }

        private void ordemServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdemServico frmOrdemServico = new frmOrdemServico();
            frmOrdemServico.ShowDialog();
        }

        private void retiradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRetirada frmRetirada = new frmRetirada();
            frmRetirada.ShowDialog();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEntrada frmEntra = new frmEntrada();
            frmEntra.ShowDialog();
        }

        private void lavadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdensAbertas frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvenios frmConvenios = new frmConvenios();
            frmConvenios.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasAPagar frmContasAPagar = new frmContasAPagar();
            frmContasAPagar.ShowDialog();
        }

        private void ordemServicoAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdensAbertas frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void credorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCredor frmCredor = new frmCredor();
            frmCredor.ShowDialog();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaContasAPagar frmpesquisacontas = new frmPesquisaContasAPagar();
            frmpesquisacontas.ShowDialog();
        }

        private void fechamentoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFechamentoCaixa frmFechamentoCaixa = new frmFechamentoCaixa();
            frmFechamentoCaixa.ShowDialog();
        }

        private void produtoAbaixoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutoAbaixoEstoque frmPAE = new frmProdutoAbaixoEstoque();
            frmPAE.ShowDialog();
        }

        private void carrosLavadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdensAbertas frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntrada frmEntra = new frmEntrada();
            frmEntra.ShowDialog();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetirada frmRetirada = new frmRetirada();
            frmRetirada.ShowDialog();
        }

        private void clientePorPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientePesquisaPorPlaca cliePesquisa = new frmClientePesquisaPorPlaca();
            cliePesquisa.ShowDialog();
        }

        private void servicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCaixa frmCaixa = new frmCaixa();
            frmCaixa.ShowDialog();
        }

        private void produtosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutosInternos frmProdutoInternos = new frmProdutosInternos();
            frmProdutoInternos.ShowDialog();
        }

        private void lavagemPorLavadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLavagensPorLavador frmlavPorLavador = new frmLavagensPorLavador();
            frmlavPorLavador.ShowDialog();
        }
    }
}
