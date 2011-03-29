using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Collections.Generic;
using Impressao;

namespace WSLavajato
{
    /// <summary>
    /// Summary description for WebServiceLavajato
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceLavajato : System.Web.Services.WebService
    {

        #region Service

        private ServicoDAO servicoDao = new ServicoDAO();
        private ClienteDAO clienteDao = new ClienteDAO();
        private ProdutoDAO produtoDao = new ProdutoDAO();
        private ServicoBL servicoBL = new ServicoBL();

        private const int qtdeMaximaDeOrdensDeServico = 1000;

        [WebMethod]
        public Servico ServicoAdd(Servico servico)
        {

            servico.OrdemServico = GetOrdemServico();
            return servicoDao.Add(servico);
        }

        private int GetOrdemServico()
        {
            int ordemServico = servicoDao.OrdemServicoMax();
            if (ordemServico < qtdeMaximaDeOrdensDeServico)
                return ordemServico += 1;
            else
                return ordemServico = 1;
        }

        [WebMethod]
        public void ServicoUpdate(Servico servico)
        {
            servicoDao.Update(servico);
        }

        [WebMethod]
        public Servico ServicoByCliente(Cliente cliente)
        {
            return servicoDao.ByCliente(cliente);
        }

        [WebMethod]
        public Servico ServicoByID(Servico servico)
        {
            return servicoDao.ByID(servico);
        }

        [WebMethod]
        public DataTable CriaGridCarrosLavano()
        {
            return servicoBL.CriaGridCarrosLavano();
        }

        #endregion

        #region ServiceItem

        [WebMethod]
        public void ServicoItemDelete(ServicoItem servicoItem)
        {
            servicoDao.ItemDoServicoDelete(servicoItem);
        }

        [WebMethod]
        public void ServicoItemAdd(ServicoItem servicoItem)
        {
            servicoDao.ItemDoServicoInsert(servicoItem);
        }


        #endregion

        #region Produto

        [WebMethod]
        public List<Produto> ProdutoTipo(int categoriaProduto)
        {
            return produtoDao.TipoServico(categoriaProduto);
        }

        [WebMethod]
        public DataTable ByCategoria(int categoriaProduto)
        {
            return produtoDao.ByCategoria(categoriaProduto);
        }

        [WebMethod]
        public Produto ProdutoByID(Produto produto)
        {
            return produtoDao.ByID(produto);
        }

        #endregion

        #region Cliente

        [WebMethod]
        public Cliente ClienteByPlaca(Cliente cliente)
        {
            return clienteDao.ByPlaca(cliente);
        }

        [WebMethod]
        public Cliente ClienteAdd(Cliente cliente)
        {
            return clienteDao.Add(cliente);
        }
        
        [WebMethod]
        public Servico ByCliente(Cliente cliente)
        {
            return servicoDao.ByCliente(cliente);
        }

        [WebMethod]
        public void ClienteUpdate(Cliente cliente)
        {
            clienteDao.Update(cliente);
        }

        [WebMethod]
        public bool ClienteExiste(Cliente cliente)
        {
            return clienteDao.Existe(cliente);
        }


        #endregion

        #region Configuracao

        [WebMethod]
        public int EmiteRecibo(HenryCorporation.Lavajato.DomainModel.Servico servico, string avaria)
        {

            IImprimir print = new ImprimirComprovantePagamento();
            print.Imprimir(servico);
            return 0;
        }
        #endregion
    }
}
