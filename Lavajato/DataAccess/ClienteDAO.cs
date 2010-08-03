using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HenryCorporation.Lavajato.DomainModel;
using System.Data;
using System.Data.SqlClient;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ClienteDAO : DataAccessBase
    {
        private const string sql = " SELECT [ClienteID],[Placa],[Nome],[Cor],[Telefone],[Veiculo],[Endereco],[Numero] " +
                             " ,[Bairro],[Cep],[Cidade],[UF],[Email],[Celular],[Cpf],[RG], [Delete], [ConvenioID]" +
                             " FROM [Lavajado].[dbo].[Clientes]";

        public ClienteDAO()
        {

        }


        public Cliente Add(Cliente cliente)
        {
            string query = " INSERT INTO [Lavajado].[dbo].[Clientes]([Placa] " +
             " ,[Nome],[Cor],[Telefone],[Veiculo],[Endereco],[Numero],[Bairro],[Cep],[Cidade] " +
             " ,[UF],[Email],[Celular],[Cpf],[RG], [ConvenioID]) VALUES " +
             " ('" + cliente.Placa + "', '" + cliente.Nome + "','" + cliente.Cor + "','" + cliente.Telefone + "', " +
             " '" + cliente.Veiculo + "','" + cliente.Endereco + "','" + cliente.Numero + "', " +
             " '" + cliente.Bairro + "','" + cliente.Cep + "','" + cliente.Cidade + "','" + cliente.UF + "','" + cliente.Email + "', " +
             " '" + cliente.Celular + "','" + cliente.Cpf + "','" + cliente.RG + "', '"+cliente.Convenio.ID+"') ";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return UltimoClienteCadastrado();

        }

        private Cliente UltimoClienteCadastrado()
        {
            string query = "Select max(clienteid) from clientes Where [Delete] = 0 ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            Cliente cliente = new Cliente();
            cliente.ID = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            Cliente cli = ByID(cliente);
            return cli;
        }

        public void Delete(Cliente cliente)
        {
            string query = " UPDATE [Lavajado].[dbo].[Clientes] SET [Delete] = 1  WHERE clienteid = @ClienteID";
            SqlParameter[] parameter = { new SqlParameter("@ClienteID", cliente.ID) };
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Parameters = parameter;
            dataBaseHelper.Run();
        }

        public void Update(Cliente cliente)
        {
            string query = " UPDATE [Lavajado].[dbo].[Clientes] " +
                         " SET [Placa] ='" + cliente.Placa + "' " +
                         " ,[Nome] ='" + cliente.Nome + "' ,[Cor] ='" + cliente.Cor + "' ,[Telefone] ='" + cliente.Telefone + "',[Veiculo] ='" + cliente.Veiculo + "' " +
                         " ,[Endereco] ='" + cliente.Endereco + "' ,[Numero] ='" + cliente.Numero + "' ,[Bairro] ='" + cliente.Bairro + "' ,[Cep] ='" + cliente.Cep + "' " +
                         " ,[Cidade] ='" + cliente.Cidade + "' ,[UF] ='" + cliente.UF + "' ,[Email] ='" + cliente.Email + "',[Celular] ='" + cliente.Celular + "' " +
                         " ,[Cpf] ='" + cliente.Cpf + "' ,[RG] ='" + cliente.RG + "' ,[ConvenioID] ='" + cliente.Convenio.ID + "' " +
                         " WHERE ClienteID = " + cliente.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public bool Existe(Cliente cliente)
        {
            return false;
        }

        public Cliente ByID(Cliente cliente)
        {
            string query = sql + " Where [Delete] = 0 and clienteid = " + cliente.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            Cliente cli = SetUpField(dataSet);
            return cli;
        }

        public Cliente ByName(Cliente cliente)
        {
            string query = sql + " Where [Delete] = 0 and nome = '" + cliente.Nome.Trim() + "'";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            Cliente cli = SetUpField(dataSet);
            return cli;
        }

        public List<Cliente> GetAll()
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper(sql + "Where [Delete] = 0");
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            List<Cliente> clientes = SetUpFields(dataSet);
            return clientes;
        }

        public List<Cliente> ByNames(Cliente cliente)
        {

            string query = sql + " Where [Delete] = 0 and nome like('%" + cliente.Nome.Trim() + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            List<Cliente> cli = SetUpFields(dataSet);
            return cli;
        }

        public List<Cliente> ByPlacas(Cliente cliente)
        {
            string query = sql + " Where [Delete] = 0 and placa like('%" + cliente.Placa.Trim() + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            List<Cliente> cli = SetUpFields(dataSet);
            return cli;
        }

        public Cliente ByPlaca(Cliente cliente)
        {
            string query = sql + " Where [Delete] = 0 and placa = '" + cliente.Placa.Trim() + "'";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            Cliente cli = SetUpField(dataSet);
            return cli;
        }

        private Cliente SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Cliente cliente = new Cliente();
            if (reader.Read())
            {
                
                cliente.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                cliente.Placa = reader.IsDBNull(1) ? "" : reader.GetString(1);
                cliente.Nome = reader.IsDBNull(2) ? "" : reader.GetString(2);
                cliente.Cor = reader.IsDBNull(3) ? "" : reader.GetString(3);
                cliente.Telefone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                cliente.Veiculo = reader.IsDBNull(5) ? "" : reader.GetString(5);
                cliente.Endereco = reader.IsDBNull(6) ? "" : reader.GetString(6);
                cliente.Numero = reader.IsDBNull(7) ? "" : reader.GetString(7);
                cliente.Bairro = reader.IsDBNull(8) ? "" : reader.GetString(8);
                cliente.Cep = reader.IsDBNull(9) ? "" : reader.GetString(9);
                cliente.Cidade = reader.IsDBNull(10) ? "" : reader.GetString(10);
                cliente.UF = reader.IsDBNull(11) ? "" : reader.GetString(11);
                cliente.Email = reader.IsDBNull(12) ? "" : reader.GetString(12);
                cliente.Celular = reader.IsDBNull(13) ? "" : reader.GetString(13);
                cliente.Cpf = reader.IsDBNull(14) ? "" : reader.GetString(14);
                cliente.RG = reader.IsDBNull(15) ? "" : reader.GetString(15);
                cliente.Delete = reader.IsDBNull(16) ? false : Convert.ToBoolean(reader.GetByte(16));
                cliente.Convenio = GetConvenio( reader.IsDBNull(17) ? 0 : reader.GetInt32(17));
                return cliente;
            }
            return cliente;
        }

        private List<Cliente> SetUpFields(DataSet dataSet)
        {
            
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                cliente.Placa = reader.IsDBNull(1) ? "" : reader.GetString(1);
                cliente.Nome = reader.IsDBNull(2) ? "" : reader.GetString(2);
                cliente.Cor = reader.IsDBNull(3) ? "" : reader.GetString(3);
                cliente.Telefone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                cliente.Veiculo = reader.IsDBNull(5) ? "" : reader.GetString(5);
                cliente.Endereco = reader.IsDBNull(6) ? "" : reader.GetString(6);
                cliente.Numero = reader.IsDBNull(7) ? "" : reader.GetString(7);
                cliente.Bairro = reader.IsDBNull(8) ? "" : reader.GetString(8);
                cliente.Cep = reader.IsDBNull(9) ? "" : reader.GetString(9);
                cliente.Cidade = reader.IsDBNull(10) ? "" : reader.GetString(10);
                cliente.UF = reader.IsDBNull(11) ? "" : reader.GetString(11);
                cliente.Email = reader.IsDBNull(12) ? "" : reader.GetString(12);
                cliente.Celular = reader.IsDBNull(13) ? "" : reader.GetString(13);
                cliente.Cpf = reader.IsDBNull(14) ? "" : reader.GetString(14);
                cliente.RG = reader.IsDBNull(15) ? "" : reader.GetString(15);
                cliente.Delete = reader.IsDBNull(16) ? false : Convert.ToBoolean( reader.GetByte(16));
                cliente.Convenio = GetConvenio(reader.IsDBNull(17) ? 0 : reader.GetInt32(17));
                clientes.Add(cliente);
            }
            return clientes;

        }

        public Convenio GetConvenio(int p)
        { 
            ConvenioDAO convenioDao = new ConvenioDAO();
            Convenio convenio = new Convenio();
            convenio.ID = p;
            return convenioDao.ByID(convenio);
        }

      
    }
}
