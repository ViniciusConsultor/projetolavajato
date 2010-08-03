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
        private FormaPagamentoDAO formaPagamentoDAO;
        private ClienteDAO clienteDAO;
        private ServicoItemDAO servicoItemDAO;

        string sql = " SELECT [ServicoID], [ClienteID], [Total], [SubTotal], [Desconto], [Saida], [Entrada] " +
                     " ,[OrdemServico], [FormaPagamentoID], [Delete], [Cancelado], [Lavado], [Finalizado], [UsuarioID]  " +
                     " FROM [Lavajado].[dbo].[Servico] ";

        public ServicoDAO()
        {
            formaPagamentoDAO = new FormaPagamentoDAO();
            clienteDAO = new ClienteDAO();
            servicoItemDAO = new ServicoItemDAO();
        }

        public Servico Add(Servico servico)
        {
            //string saida = servico.Saida.Year + "-" + servico.Saida.Month + "-" + servico.Saida.Day + " " + servico.Saida.Hour + ":" + servico.Saida.Minute + ":" + servico.Saida.Second;
            //string entrada = servico.Entrada.Year + "-" + servico.Entrada.Month + "-" + servico.Entrada.Day + " " + servico.Entrada.Hour + ":" + servico.Entrada.Minute + ":" + servico.Entrada.Second;
            
            string query = " INSERT INTO [Lavajado].[dbo].[Servico] ([ClienteID],[Total],[SubTotal], "+
                           " [Desconto],[Saida],[Entrada],[OrdemServico],[FormaPagamentoID],[Delete],"+
                           " [Cancelado],[Lavado],[Finalizado], [UsuarioID])" +
                           " VALUES('"+servico.Cliente.ID+"' "+
                           " ,'"+servico.Total+"' "+
                           " ,'" + servico.SubTotal + "' " +
                           " ,'" + servico.Desconto + "' " +
                           " , '"+Configuracao.HoraSaida(servico.Saida)+"' " +
                           " , '" + Configuracao.HoraEntrada(servico.Entrada) + "' " +
                            //" ,'" + servico.Saida + "' " +
                           //" ,'" + servico.Entrada + "' " +
                           " ,'" + servico.OrdemServico+ "' " +
                           " ,'" + servico.FormaPagamento.ID + "' " +
                           " ,'" + servico.Delete + "' " +
                           " ,'" + servico.Cancelado + "' " +
                           " ,'" + servico.Lavado + "' " +
                           " ,'" + servico.Finalizado + "' "+
                           " ,'" + servico.Usuario.ID + "' )";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return ServicoInserido();
        }

        private Servico ServicoInserido()
        {
            string query = " SELECT MAX(SERVICOID) FROM SERVICO ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            Servico servico = new Servico();
            servico.ID = int.Parse( dataSet.Tables[0].Rows[0][0].ToString());
            return ByID(servico);
        }

        public void ItemDoServicoInsert(ServicoItem servicoItem)
        {
            servicoItemDAO.Add(servicoItem);
        }

        public void Delete(Servico servico)
        {
            string query = " UPDATE [Lavajado].[dbo].[Servico] "+
                           " SET [Delete] = 1 " +
                           " WHERE ServicoID = " + servico.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void ItemDoServicoDelete(ServicoItem servicoItem)
        {
            servicoItemDAO.Delete(servicoItem);
        }

        public void Update(Servico servico)
        {
            string query = " UPDATE [Lavajado].[dbo].[Servico] "+
                           " SET [ClienteID] = '"+servico.Cliente.ID.ToString().Trim()+"' "+
                           " ,[Total] = '"+servico.Total.ToString().Replace(",", ".")+"' "+
                           " ,[SubTotal] = '" + servico.SubTotal.ToString().Replace(",", ".") + "' " +
                           " ,[Desconto] = '" + servico.Desconto.ToString().Replace(",", ".") + "' " +
                           " ,[Saida] = getdate()" +
                           " ,[Entrada] = getdate() " +
                           //" ,[Saida] = '"+servico.Saida+"' "+
                           //" ,[Entrada] = '"+servico.Entrada+"' "+
                           " ,[OrdemServico] = '"+servico.OrdemServico+"' "+
                           " ,[FormaPagamentoID] = '"+servico.FormaPagamento.ID+"' "+
                           " ,[Delete] = '"+servico.Desconto+"' "+
                           " ,[Cancelado] = '"+servico.Cancelado+"' "+
                           " ,[Lavado] = '"+servico.Lavado+"' "+
                           " ,[Finalizado] = '"+servico.Finalizado+"' "+
                           " ,[UsuarioID] = '" + servico.Usuario.ID + "' " +
                           " WHERE [ServicoID] = " + servico.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void ServicoItemUpdate(ServicoItem servicoItem)
        {
            servicoItemDAO.Update(servicoItem);
        }

        public Servico ByID(Servico servico)
        {
            string query = sql + "Where [Delete] = 0 And [Cancelado] = 0 And [Finalizado] = 0 And [ServicoID] =" + servico.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public ServicoItem ByServicoItemID(ServicoItem servicoItem)
        {
            return servicoItemDAO.ByID(servicoItem);
        }

        public Servico ByOrdemServico(Servico servico)
        {
            string query = sql + "Where [Delete] = 0 And [Cancelado] = 0 And [Finalizado] = 0 And [OrdemServico] =" + servico.OrdemServico;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public Servico ByCliente(Cliente cliente)
        {
            string query = sql + "Where [Delete] = 0 And [Cancelado] = 0 And [Finalizado] = 0 And ClienteID = " + cliente.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Servico> GetAll(string query)
        {
            DataBaseHelper dataBaseHelper;
            if (query.Length == 0)
                dataBaseHelper = new DataBaseHelper(this.sql);
            else
                dataBaseHelper = new DataBaseHelper(this.sql+ " Where [Delete] = 0 And [Cancelado] = 0 And [Finalizado] = 0");

            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            return SetUpFields(dataSet);
        }

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
                servico.FormaPagamento = FormaPagamentoByID( reader.GetInt32(8));
                servico.Delete = reader.IsDBNull(9) ? 0 : Convert.ToInt32( reader.GetByte(9));
                servico.Cancelado = reader.IsDBNull(10) ? 0 : Convert.ToInt32(reader.GetByte(10));
                servico.Lavado = reader.IsDBNull(11) ? 0 : Convert.ToInt32(reader.GetByte(11));
                servico.Finalizado = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetByte(12));
                servico.Usuario = SetUpUsuario(reader.IsDBNull(13) ? 0 : reader.GetInt32(13));
                servico.ServicoItem = servicoItemDAO.ItensByID(servico);
                return servico;
            }
            return servico;
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
                servico.Delete = reader.IsDBNull(9) ? 0 : Convert.ToInt32( reader.GetByte(9));
                servico.Cancelado = reader.IsDBNull(10) ? 0 : Convert.ToInt32(reader.GetByte(10));
                servico.Lavado = reader.IsDBNull(11) ? 0 : Convert.ToInt32(reader.GetByte(11));
                servico.Finalizado = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetByte(12));
                servico.Usuario = SetUpUsuario(reader.IsDBNull(13) ? 0 : reader.GetInt32(13));
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
    }
}
