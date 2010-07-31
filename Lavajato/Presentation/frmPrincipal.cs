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

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaixa frmCaixa = new frmCaixa();
            frmCaixa.ShowDialog();
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
    }
}
