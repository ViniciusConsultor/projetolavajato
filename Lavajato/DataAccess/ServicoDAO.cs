using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ServicoDAO : DataAccessBase
    {
        internal FormaPagamentoDAO formaPagamentoDAO;
        internal ClienteDAO clienteDAO;
        internal ServicoItemDAO servicoItemDAO;

        string sql = " SELECT [ServicoID], [ClienteID], [Total], [SubTotal], [Desconto], [Saida], [Entrada] " +
                     " ,[OrdemServico], [FormaPagamentoID], [Delete], [Cancelado], [Lavado], [Finalizado], [UsuarioID], [Pago],[LavadorID]  " +
                     " FROM [Servico] ";

        public ServicoDAO()
        {
            formaPagamentoDAO = new FormaPagamentoDAO();
            clienteDAO = new ClienteDAO();
            servicoItemDAO = new ServicoItemDAO();
        }

        #region Servico

        public Servico Add(Servico servico)
        {
            string query = " INSERT INTO [Servico]([ClienteID],[Total],[SubTotal], " +
                           " [Desconto],[Saida],[Entrada],[OrdemServico],[FormaPagamentoID],[Delete]," +
                           " [Cancelado],[Lavado],[Finalizado], [UsuarioID], [Pago])" +
                           " VALUES('" + servico.Cliente.ID + "' " +
                           " ,'" + servico.Total.ToString().Replace(",", ".") + "' " +
                           " ,'" + servico.SubTotal.ToString().Replace(",", ".") + "' " +
                           " ,'" + servico.Desconto + "' " +
                           " , '" + Configuracao.HoraSaida(servico.Saida) + "' " +
                           " , '" + Configuracao.HoraEntrada(servico.Entrada) + "' " +
                           " ,'" + servico.OrdemServico + "' " +
                           " ,'" + servico.FormaPagamento.ID + "' " +
                           " ,'" + servico.Delete + "' " +
                           " ,'" + servico.Cancelado + "' " +
                           " ,'" + servico.Lavado + "' " +
                           " ,'" + servico.Finalizado + "' " +
                           " ,'" + servico.Usuario.ID + "' " +
                           " ,'" + servico.Pago + "')";

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return ServicoInserido();
        }

        public List<Servico> GetCarrosLavando()
        {
            var query = sql + " Where [Delete] = 0 and [Pago] = 0  And [Cancelado] = 0 and [Lavado] = 0 order by  ordemservico asc  ";
            var dataBaseHelper = new DataBaseHelper(this.sql);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public void Delete(Servico servico)
        {
            var query = " UPDATE [Servico] " +
                           " SET [Delete] = 1 " +
                           " WHERE ServicoID = " + servico.ID;

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void CarroLavado(Servico servico)
        {
            var query = " UPDATE [Servico] " +
                           " SET [Lavado] = '" + servico.Lavado + "' " +
                           " WHERE ServicoID = " + servico.ID;

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void AcertoFuturo(Servico servico)
        {
            var query = " UPDATE [Servico] " +
                           " SET [AcertoFuturo] = 1 " +
                           " WHERE ServicoID = " + servico.ID;

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Update(Servico servico)
        {
            var query = " UPDATE [Servico] " +
                           " SET [ClienteID] = '" + servico.Cliente.ID.ToString().Trim() + "' " +
                           " ,[Total] = '" + servico.Total.ToString().Replace(",", ".") + "' " +
                           " ,[SubTotal] = '" + servico.SubTotal.ToString().Replace(",", ".") + "' " +
                           " ,[Desconto] = '" + servico.Desconto.ToString().Replace(",", ".") + "' " +
                           " ,[Saida] = getdate()" +
                           " ,[Entrada] = getdate() " +
                           " ,[OrdemServico] = '" + servico.OrdemServico + "' " +
                           " ,[FormaPagamentoID] = '" + servico.FormaPagamento.ID + "' " +
                           " ,[Delete] = '" + servico.Delete + "' " +
                           " ,[Cancelado] = '" + servico.Cancelado + "' " +
                           " ,[Lavado] = '" + servico.Lavado + "' " +
                           " ,[Finalizado] = '" + servico.Finalizado + "' " +
                           " ,[UsuarioID] = '" + servico.Usuario.ID + "' " +
                           " ,[Pago] = '" + servico.Pago + "' " +
                           " ,[LavadorID] = '" + servico.Lavador + "' " +
                           " WHERE [ServicoID] = " + servico.ID;

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public Servico ByID(Servico servico)
        {
            var query = sql + "Where [Delete] = 0 And [Cancelado] = 0  And [ServicoID] =" + servico.ID;
            var dataBaseHelper = new DataBaseHelper(query);
            var dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public Servico ByID(int servico)
        {
            var query = sql + "Where [Delete] = 0 And [Cancelado] = 0  And [ServicoID] =" + servico;
            var dataBaseHelper = new DataBaseHelper(query);
            var dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public Servico ByCliente(Cliente cliente)
        {
            var query = sql + "Where [Delete] = 0 And [Cancelado] = 0 And ClienteID = " + cliente.ID;
            var dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public IList<Servico> ByServicosDoCliente(Cliente cliente)
        {
            var query = sql + "Where [Delete] = 0 And [Cancelado] = 0 And ClienteID = " + cliente.ID;
            var dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }



        public int OrdemServicoMax()
        {
            var query = "select top 1 ordemservico from servico order by servicoid desc";
            var dataBaseHelper = new DataBaseHelper(query);
            int index = dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows.Count;
            return index > 0 ? int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString()) : 0;
        }

        #endregion

        #region ServicoItem

        public void ItemDoServicoInsert(ServicoItem servicoItem)
        {
            servicoItemDAO.Add(servicoItem);
        }

        public void ServicoItemUpdate(ServicoItem servicoItem)
        {
            servicoItemDAO.Update(servicoItem);
        }

        public void ItemDoServicoDelete(ServicoItem servicoItem)
        {
            servicoItemDAO.Delete(servicoItem);
        }

        public ServicoItem ByServicoItemID(ServicoItem servicoItem)
        {
            return servicoItemDAO.ByID(servicoItem);
        }

        public Servico ByOrdemServicoFinalizadas(Servico servico)
        {
            //somente pesquisar ordem de serviço que não foram finalizadas
            var query = sql + "Where [Delete] = 0 And [OrdemServico] =" + servico.OrdemServico;
            var dataBaseHelper = new DataBaseHelper(query);
            var dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public Servico ByOrdemServico(Servico servico)
        {
            //somente pesquisar ordem de serviço que não foram finalizadas
            var query = sql + "Where [Delete] = 0 And Finalizado = 0 And [Cancelado] = 0 And [OrdemServico] =" + servico.OrdemServico;
            var dataBaseHelper = new DataBaseHelper(query);
            var dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public List<Servico> GetAll(bool isLavados)
        {
            string condicao = " Where [Delete] = 0 And [Cancelado] = 0 And Finalizado = 1 ";
            var dataBaseHelper = isLavados
                ? new DataBaseHelper(this.sql + condicao + " And OrdemServico <> 0 order by OrdemServico Asc  ") 
                : new DataBaseHelper(this.sql + condicao);
            var dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpFields(dataSet);
        }

        public List<Servico> GetCarrosNoLavajato()
        {
            string condicao = " Where [Delete] = 0 And Finalizado = 0 And [Cancelado] = 0 "+
            " And OrdemServico <> 0 order by OrdemServico Asc  ";

            var dataBaseHelper =  new DataBaseHelper(this.sql + condicao);
            var dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpFields(dataSet);
        }

        #endregion

        #region MetodosAuxiliares

        private Servico SetUpField(DataSet dataSet)
        {
            Servico servico = new Servico();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            if (reader.Read())
            {
                servico.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                servico.Cliente = ClienteByID(reader.GetInt32(1));
                servico.Total = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                servico.SubTotal = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                servico.Desconto = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                servico.Saida = reader.IsDBNull(5) ? DateTime.Now : reader.GetDateTime(5);
                servico.Entrada = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6);
                servico.OrdemServico = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                servico.FormaPagamento = FormaPagamentoByID(reader.GetInt32(8));
                servico.Delete = reader.IsDBNull(9) ? 0 : Convert.ToInt32(reader.GetByte(9));
                servico.Cancelado = reader.IsDBNull(10) ? 0 : Convert.ToInt32(reader.GetByte(10));
                servico.Lavado = reader.IsDBNull(11) ? 0 : Convert.ToInt32(reader.GetByte(11));
                servico.Finalizado = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetByte(12));
                servico.Usuario = SetUpUsuario(reader.IsDBNull(13) ? 0 : reader.GetInt32(13));
                servico.Pago = reader.IsDBNull(14) ? 0 : reader.GetInt32(14);
                servico.Lavador = reader.IsDBNull(15) ? 0 : reader.GetInt32(15);
                servico.ServicoItem = servicoItemDAO.ItensByID(servico);
                return servico;
            }
            return servico;
        }

        private Servico ServicoInserido()
        {
            string query = " SELECT MAX(SERVICOID) FROM SERVICO ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            Servico servico = new Servico();
            servico.ID = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            return ByID(servico);
        }

        private Usuario SetUpUsuario(int p)
        {
            Usuario user = new Usuario();
            user.ID = p;
            UsuarioDAO userDao = new UsuarioDAO();
            return userDao.ByID(user);
        }

        private List<Servico> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Servico> servicos = new List<Servico>();
            while (reader.Read())
            {
                Servico servico = new Servico();
                servico.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                servico.Cliente = ClienteByID(reader.GetInt32(1));
                servico.Total = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                servico.SubTotal = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                servico.Desconto = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                servico.Saida = reader.IsDBNull(5) ? DateTime.Now : reader.GetDateTime(5);
                servico.Entrada = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6);
                servico.OrdemServico = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                servico.FormaPagamento = FormaPagamentoByID(reader.GetInt32(8));
                servico.Delete = reader.IsDBNull(9) ? 0 : Convert.ToInt32(reader.GetByte(9));
                servico.Cancelado = reader.IsDBNull(10) ? 0 : Convert.ToInt32(reader.GetByte(10));
                servico.Lavado = reader.IsDBNull(11) ? 0 : Convert.ToInt32(reader.GetByte(11));
                servico.Finalizado = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetByte(12));
                servico.Usuario = SetUpUsuario(reader.IsDBNull(13) ? 0 : reader.GetInt32(13));
                servico.Pago = reader.IsDBNull(14) ? 0 : reader.GetInt32(14);
                servico.Pago = reader.IsDBNull(15) ? 0 : reader.GetInt32(15);
                servico.ServicoItem = servicoItemDAO.ItensByID(servico);
                servicos.Add(servico);
            }
            return servicos;
        }

        private FormaPagamento FormaPagamentoByID(int p)
        {
            FormaPagamento forPagamento = new FormaPagamento();
            forPagamento.ID = p;
            return formaPagamentoDAO.ByID(forPagamento);
        }

        private Cliente ClienteByID(int p)
        {
            Cliente cli = new Cliente();
            cli.ID = p;
            return clienteDAO.ByID(cli);
        }

        #endregion

        #region

        public void AddFuncionarioNoServico(Servico _servico, Produto _produto)
        {
            string query = " INSERT INTO [Lavajato].[dbo].[ServicoFuncionario] ([ServicoID], [ProdutoID], "+
                " [LavadorID],[Del])VALUES ('" + _servico.ID + "','" + _produto.ID + "','"+_servico.Usuario.ID+"', 0 )";

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

        }

        public void ServicoFuncionarioDelete(int _indexRowDelete)
        {
            string query = " UPDATE [Lavajato].[dbo].[ServicoFuncionario] SET [Del] = 1  WHERE ID = '" + _indexRowDelete + "' ";
            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public ServicoFuncionario ServicoFuncionarioGet(ServicoFuncionario servicoFuncionario)
        {
            string query = " SELECT [ID],[ServicoID],[ProdutoID],[LavadorID],[Del] FROM [Lavajato].[dbo].[ServicoFuncionario] WHERE [Del] = 0 and ID = " + servicoFuncionario.ID;
            var dataBaseHelper = new DataBaseHelper(query);
            return SetUpFieldServicoFuncionario(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<ServicoFuncionario> ServicoFuncionarioByServico(Servico servico)
        {
            string query = " SELECT [ID], [ServicoID], [ProdutoID], [LavadorID], [Del] FROM [Lavajato].[dbo].[ServicoFuncionario] WHERE [Del] = 0 and ServicoID = " + servico.ID;
            var dataBaseHelper = new DataBaseHelper(query);
            return SetUpFieldServicoFuncionarios(dataBaseHelper.Run(this.ConnectionString));
        }

        public ServicoFuncionario ServicoFuncionarioByID(ServicoFuncionario servicoFuncionario)
        {
            string query = " SELECT [ID], [ServicoID], [ProdutoID], [LavadorID], [Del] "+
            " FROM [ServicoFuncionario] WHERE [Del] = 0 and ServicoID = " + servicoFuncionario.ID;
            var dataBaseHelper = new DataBaseHelper(query);
            return SetUpFieldServicoFuncionario(dataBaseHelper.Run(this.ConnectionString));
        }

        private ServicoFuncionario SetUpFieldServicoFuncionario(DataSet dataSet)
        {
            ProdutoDAO produtodao = new ProdutoDAO();
            UsuarioDAO usuariodao = new UsuarioDAO();
            ServicoFuncionario servicoFuncionario = new ServicoFuncionario();

            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            if (reader.Read())
            {
                Produto produto = new Produto();
                Usuario usuario = new Usuario();

                servicoFuncionario.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                servicoFuncionario.Servico = reader.IsDBNull(1) ? new Servico() : this.ByID(reader.GetInt32(1));
                
                produto.ID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                servicoFuncionario.Produto = produtodao.ByID(produto);
                
                usuario.ID = reader.IsDBNull(3) ? 0: reader.GetInt32(3);
                servicoFuncionario.Lavador = usuariodao.ByID(usuario);

            }
            return servicoFuncionario;
        }

        private List<ServicoFuncionario> SetUpFieldServicoFuncionarios(DataSet dataSet)
        {
            ProdutoDAO produtodao = new ProdutoDAO();
            UsuarioDAO usuariodao = new UsuarioDAO();

            List<ServicoFuncionario> servicoFuncionarios = new List<ServicoFuncionario>();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                ServicoFuncionario servicoFuncionario = new ServicoFuncionario();

                Produto produto = new Produto();
                Usuario usuario = new Usuario();
                
                servicoFuncionario.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                servicoFuncionario.Servico = reader.IsDBNull(1) ? new Servico() : this.ByID(reader.GetInt32(1));
                produto.ID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                servicoFuncionario.Produto = produtodao.ByID(produto);
                
                usuario.ID = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                servicoFuncionario.Lavador = usuariodao.ByID(usuario);
                
                servicoFuncionarios.Add(servicoFuncionario);
            }

            return servicoFuncionarios;
        }


        #endregion

    }
}
