using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HenryCorporation.Lavajato.Presentation;
using HenryCorporation.Lavajato.DomainModel;

namespace Presentation
{
    public partial class frmPrincipal : Form//login
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //SetPermissoes();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCliente = new frmCliente();
            frmCliente.ShowDialog();
            //SetPermissoes();
        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClientePesquisa = new frmClientePesquisa();
            frmClientePesquisa.ShowDialog();
            //SetPermissoes();
        }

        private void categoriaProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProduto = new frmProduto();
            frmProduto.ShowDialog();
            //SetPermissoes();
        }

        private void procuraProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProdutoPesquisa = new frmProdutoPesquisa();
            frmProdutoPesquisa.ShowDialog();
            //SetPermissoes();
        }

        private void cadatroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
            //SetPermissoes();
        }

        private void procuraUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioPesquisa frmUsuarioPesquisa = new frmUsuarioPesquisa();
            frmUsuarioPesquisa.ShowDialog();
            //SetPermissoes();
        }

        private void ordemServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdemServico frmOrdemServico = new frmOrdemServico();
            frmOrdemServico.ShowDialog();
            //SetPermissoes();
        }

        private void retiradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRetiradaSuprimento frmRetirada = new frmRetiradaSuprimento();
            frmRetirada.ShowDialog();
            //SetPermissoes();
        }

        private void entradaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEntrada frmEntra = new frmEntrada();
            frmEntra.ShowDialog();
            //SetPermissoes();
        }

        private void lavadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdensAbertas frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
            //SetPermissoes();
        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConvenios = new frmConvenios();
            frmConvenios.ShowDialog();
            //SetPermissoes();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetPermissoes();
        }

        private void ordemServicoAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
            //SetPermissoes();
        }

        private void credorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCredor = new frmCredor();
            frmCredor.ShowDialog();
            //SetPermissoes();
        }

        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmpesquisacontas = new frmPesquisaContasAPagar();
            frmpesquisacontas.ShowDialog();
            //SetPermissoes();
        }

        private void fechamentoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFechamentoCaixa = new frmFechamentoCaixa();
            frmFechamentoCaixa.ShowDialog();
            //SetPermissoes();
        }

        private void produtoAbaixoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetPermissoes();
        }

        private void carrosLavadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
            //SetPermissoes();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEntra = new frmEntrada();
            frmEntra.ShowDialog();
            //SetPermissoes();
        }

        private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetiradaSuprimento frmRetirada = new frmRetiradaSuprimento();
            frmRetirada.ShowDialog();
            //SetPermissoes();
        }

        private void clientePorPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientePesquisaPorPlaca cliePesquisa = new frmClientePesquisaPorPlaca();
            cliePesquisa.ShowDialog();
            //SetPermissoes();
        }

        private void servicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmCaixa = new frmCaixa();
            frmCaixa.ShowDialog();
            //SetPermissoes();
        }

        private void produtosInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProdutoInternos = new frmProdutosInternos();
            frmProdutoInternos.ShowDialog();
            //SetPermissoes();
        }

        private void lavagemPorLavadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlavPorLavador = new frmLavagensPorLavador();
            frmlavPorLavador.ShowDialog();
            //SetPermissoes();
        }

        private void fechamentoDeCaixaPorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vendasDiarias = new frmVendasDiarias();
            vendasDiarias.ShowDialog();
            //SetPermissoes();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trocarUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var masterLogin = new frmMasterLogin();
            masterLogin.ShowDialog();
            //SetPermissoes();
        }

        private void incluirLavadorNoServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcuraServicoPorPlaca frmProcuraServicoPorPlaca = new frmProcuraServicoPorPlaca();
            frmProcuraServicoPorPlaca.ShowDialog();
            //SetPermissoes();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.ShowDialog();
            //SetPermissoes();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCaixa frmcaixa = new frmCaixa();
            frmcaixa.ShowDialog();
            //SetPermissoes();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmProduto frmproduto = new frmProduto();
            frmproduto.ShowDialog();
            //SetPermissoes();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var frmAbertas = new frmOrdensAbertas();
            frmAbertas.ShowDialog();
                //SetPermissoes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCliente frmcliente = new frmCliente();
            frmcliente.ShowDialog();
            //SetPermissoes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProduto frmproduto = new frmProduto();
            frmproduto.ShowDialog();
            //SetPermissoes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCaixa frmcaixa = new frmCaixa();
            frmcaixa.ShowDialog();
            //SetPermissoes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUsuario frmusuario = new frmUsuario();
            frmusuario.ShowDialog();
            //SetPermissoes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendaAvulsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaAvulsa frmVendaAvulsa = new frmVendaAvulsa();
            frmVendaAvulsa.ShowDialog();
            //SetPermissoes();
        }

        private void proudutoAbaixoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPAE = new frmProdutoAbaixoEstoque();
            frmPAE.ShowDialog();
            //SetPermissoes();
        }

        private void produtoEmEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frmproduto = new frmProdutos();
            frmproduto.ShowDialog();
            //SetPermissoes();
        }

        private void carrosNoLavajatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarrosNoLavajato frmcarrosnolavajato = new frmCarrosNoLavajato();
            frmcarrosnolavajato.ShowDialog();
            //SetPermissoes();
        }

        private void serviçoPorOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicoPorOS frmServicoPorOS = new frmServicoPorOS();
            frmServicoPorOS.ShowDialog();
            //SetPermissoes();
        }

        private void cancelaServiçoFinalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcuraServicoPorOS frmProcuraServicoPorOS = new frmProcuraServicoPorOS();
            frmProcuraServicoPorOS.ShowDialog();
            //SetPermissoes();
        }

        private void serviçoCanceladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicoCanceladoPorUsuario frmServicoCanceladoPorUsuario = new frmServicoCanceladoPorUsuario();
            frmServicoCanceladoPorUsuario.ShowDialog();
            //SetPermissoes();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmContasAPagar = new frmContasAPagar();
            frmContasAPagar.ShowDialog();
            //SetPermissoes();
        }

        private void transferenciaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaProdutosTranferencia frmTransProdutos = new frmListaProdutosTranferencia();
            frmTransProdutos.ShowDialog();
            //SetPermissoes();
        }

        private void fechamentoDeCaixaPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFechamentoCaixaPorData porData = new frmFechamentoCaixaPorData();
            porData.ShowDialog();
            //SetPermissoes();
        }


        //private void SetPermissoes()
        //{
        //    Permissao permissao = this.Usuario.Permissao;
        //    clientesToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.cliente);
        //    cadastroClienteToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.cliente);
        //    consultaClienteToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.cliente);

        //    usuáriosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Usuario);
        //    cadatroProdutosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Usuario);
        //    procuraUsuariosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Usuario);
            
        //    produtoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);
        //    categoriaProdutosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);
        //    procuraProdutosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);
        //    produtosInternosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);
        //    transferenciaDeProdutosToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);


        //    promoçõesToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Convenio);
        //    credorToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Credor);
        //    //trocarUToolStripMenuItem.Enabled= permissao.cliente == 0 ? false : true;

        //    caixaToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Servico);
        //    servicoToolStripMenuItem1.Enabled = Convert.ToBoolean(permissao.Servico);
        //    vendaAvulsaToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Servico);
        //    saidaToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Servico);

        //    ordemServiçoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.OrdemServico);

        //    ordemServicoAbertoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.OrdemAberto);
        //    incluirLavadorNoServiçoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.IncluirLavadorNoServico);
        //    cancelaServiçoFinalizadoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.CancelaOrdemServico);

        //    fechamentoDeCaixaToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relCaixa);
        //    fechamentoDeCaixaPorDataToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relCaixaPorData);

        //    produtoAbaixoEstoqueToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);
        //    proudutoAbaixoEstoqueToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);
        //    produtoEmEstoqueToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.Produto);


        //    clienteToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relCliente);
        //    clientePorPlacaToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relCliente);

        //    lavagemPorLavadorToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relLavagemPorLavador);
        //    carrosNoLavajatoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.CancelaOrdemServico);
        //    serviçoPorOSToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relServicoPorOs);
        //    serviçoCanceladoToolStripMenuItem.Enabled = Convert.ToBoolean(permissao.relServicoCancelado);
        //}
    }
}
