using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;


namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ServicoBL
    {
        ServicoDAO servicoDAO = new ServicoDAO();
        ServicoFormaPagamentoDAO servicoFormaPagamentoDAO = new ServicoFormaPagamentoDAO();
        private const int qtdeMaximaDeOrdensDeServico = 1000;
        

        public ServicoBL()
        {
          
        }

        #region Metodos CRUD Servico

        public Servico ByCliente(Cliente cliente)
        {
            return servicoDAO.ByCliente(cliente);
        }

        public Servico Add(Servico servico)
        {
             return servicoDAO.Add(servico);
        }

        public void Delete(Servico servico)
        {
            servicoDAO.Delete(servico);
        }

        public Servico ID(Servico servico)
        {
            return servicoDAO.ByID(servico);
        }

        public void CarroLavado(Servico servico)
        {
            servicoDAO.CarroLavado(servico);
        }

        /// <summary>
        /// Retorna Ordem de Serviço que não foi finalizado
        /// </summary>
        /// <param name="servico">Entidade Servico com Ordem de Serviço Preenchida</param>
        /// <returns></returns>
        public Servico ByOrdemServico(Servico servico)
        {
            return servicoDAO.ByOrdemServico(servico);
        }

        public void Update(Servico servico)
        {
            servicoDAO.Update(servico);
        }

        public IList<Servico> ByServicosDoCliente(Cliente cliente)
        {
            return servicoDAO.ByServicosDoCliente(cliente);
        }

        #endregion

        #region Metodos GRUD ServicoItem

        public void ItemAdd(ServicoItem servicoItem)
        {
            servicoDAO.ItemDoServicoInsert(servicoItem);
        }

        public void ItemAdd(Servico servico)
        {
            foreach (var item in servico.ServicoItem)
            {
                item.Servico = servico;
                servicoDAO.ItemDoServicoInsert(item);
            }
        }

        public void ItemUpdate(ServicoItem servicoItem)
        {
            servicoDAO.ServicoItemUpdate(servicoItem);
        }

        public void ItemDelete(ServicoItem servicoItem)
        {
            servicoDAO.ItemDoServicoDelete(servicoItem);
        }

        public ServicoItem ItemID(ServicoItem servicoItem)
        {
            return servicoDAO.ByServicoItemID(servicoItem);
        }

        #endregion

        #region "Funcionarios do Servico"

        public void FuncionarioNoServicoAdd(Servico _servico, Produto _produto)
        {
            servicoDAO.AddFuncionarioNoServico(_servico, _produto);            
        }

        public void ServicoFuncionarioDelete(int _indexRowDelete)
        {
            servicoDAO.ServicoFuncionarioDelete(_indexRowDelete);
        }

        public DataTable ServicoFuncionariosGet(Servico servico)
        {
            return ServicoFuncionarioGet(servicoDAO.ServicoFuncionarioByServico(servico));
        }

        public DataTable ServicoFuncionarioByID(ServicoFuncionario servicoFuncionario)
        {
            return new DataTable();
        }

        private DataTable ServicoFuncionarioGet(List<ServicoFuncionario> servicoFuncionarios)
        {
            return ServicoTabela.GetServicoFuncionario(servicoFuncionarios);
        }


        /// <summary>
        /// Deleta um serviço atribuido ao funcionario
        /// </summary>
        /// <param name="servicoFuncionario">Entidade ServicoFuncionario</param>
        public void ServicoFuncionarioDelete(ServicoFuncionario servicoFuncionario)
        {
            throw new NotImplementedException("Erro: função não implementada");
        }

        #endregion

        #region Pagamento

        public void InsertPagamento(Pagamento pagamento)
        {
            servicoFormaPagamentoDAO.Insert(pagamento);
        }
        


        #endregion

        public DataTable CriaGridCarrosLavano()
        {
            IList<Servico> servicos = servicoDAO.GetCarrosLavando();
            return ServicoTabela.CriaGridCarrosLavano(servicos);
        }

        public int OrdemServicoMax()
        {
            int ordemServico = servicoDAO.OrdemServicoMax();
            if (ordemServico < qtdeMaximaDeOrdensDeServico)
                return ordemServico += 1;
            else
                return ordemServico = 1;
        }

        public DataTable CriaGrid(Servico servico)
        {
            return ServicoTabela.CriaGrid(servico);
        }

        public bool ExisteServico(Servico servico)
        {
            return servico.ID == 0 ? false : true;
        }

        public DataTable GetLavados(bool estaolavados)
        {
            IList<Servico> servicos = servicoDAO.GetAll(estaolavados);
            return ServicoTabela.GetLavados(servicos);
        }

        public DataTable GetCarrosNoLavajato()
        {
            IList<Servico> servicos = servicoDAO.GetCarrosNoLavajato();
            return ServicoTabela.GetLavados(servicos);
        }

        /// <summary>
        /// Retorna Ordens de Serviços tando finalizadas quanto não finalizados para incluir lavador
        /// no serviço
        /// </summary>
        /// <param name="servico">Entidade Servico com propriedade ordem de serviço preenchida 
        /// para pesquisa
        /// </param>
        /// <returns>Retorna um DataTable com as Ordens encontradas</returns>
        public DataTable GetOrdemServico(Servico servico)
        {
            servico = servicoDAO.ByOrdemServicoFinalizadas(servico);
            return ServicoTabela.GetOrdemServico(servico);
        }

        public string RetiraCifraoDaMoedaReal(decimal valor)
        {
            return valor.ToString("C").Replace("R$", "");
        }

        public string NomeDoUsuario(Usuario usuario)
        {
            return " Usuário " + usuario.Nome;
        }

        public static decimal ConverteParaDecimal(string str)
        {
            str = str.Trim();
            return Convert.ToDecimal(str.Length > 0 ? str: "0");
        }
    }
}
