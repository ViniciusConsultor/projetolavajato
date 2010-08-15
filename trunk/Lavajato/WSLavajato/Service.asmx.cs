using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Text;

namespace WSLavajato
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {

        #region Service

        private ServicoDAO servicoDao = new ServicoDAO();
        private ClienteDAO clienteDao = new ClienteDAO();
        private ProdutoDAO produtoDao = new ProdutoDAO();
        
        [WebMethod]
        public Servico ServicoAdd(Servico servico)
        {
            return servicoDao.Add(servico);
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
        public DataTable ServicoCriaGrid(Servico servico)
        {
            ServicoBL servicobl = new ServicoBL();
            return servicobl.CriaGrid(servico);
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

        #endregion

        #region Configuracao

        [WebMethod]
        public int EmiteRecibo(HenryCorporation.Lavajato.DomainModel.Servico servico)
        {
            HenryCorporation.Lavajato.Operacional.Configuracao confi = new HenryCorporation.Lavajato.Operacional.Configuracao();
            return confi.EmiteRecibo(servico);
        }
        
        #endregion
    }
}
