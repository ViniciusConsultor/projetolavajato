using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ConvenioDAO : DataAccessBase
    {
        private const string sql = " SELECT [ConvenioID],[Desconto],[Nome],[Endereco],[Numero],[Bairro],[Cep], "+
                                   " [Cidade],[Email],[Celular] "+
                                   " ,[Cpf],[UF],[RG],[Delete], [Telefone], [Porcentagem] FROM [Convenios] ";
        
        public ConvenioDAO()
        {

        }

        public Convenio Add(Convenio convenio)
        {
            string query = " INSERT INTO [Convenios] "+
                           " ([Desconto],[Nome],[Endereco] "+
                           " ,[Numero],[Bairro],[Cep] "+
                           " ,[Cidade],[Email],[Celular] "+
                           " ,[Cpf],[UF],[RG], [Telefone], [Porcentagem]) "+
                            " VALUES ("+
                           " '"+convenio.Valor+"', '"+convenio.Nome+"', '"+convenio.Endereco+"' "+
                           " ,'"+convenio.Numero+"','"+convenio.Bairro+"' , '"+convenio.Cep+"' "+
                           " ,'"+convenio.Cidade+"' ,'"+convenio.Email+"' ,'"+convenio.Celular+"' "+
                           " ,'"+convenio.Cpf+"','"+convenio.UF+"', '"+convenio.RG+"', '"+convenio.Telefone+"', '"+convenio.PorcentagemDesconto+"') ";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return UltimoConvenio();
        }

        public Convenio ByID(Convenio convenio)
        {
            string query = sql + " WHERE Convenios.[Delete] = 0 and Convenios.ConvenioID = " + convenio.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public DataSet ByName(Convenio convenio)
        {
            string query = sql + " WHERE Convenios.[Delete] = 0 and Convenios.Nome like('%" + convenio.Nome.Trim() + "%')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return dataSet;
        }

        private Convenio UltimoConvenio()
        {
            string query = " Select max(ConvenioID) from convenios ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            Convenio convenio = new Convenio();
            convenio.ID = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            Convenio con = ByID(convenio);
            return con;
        }

        private Convenio SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Convenio convenio = new Convenio();
            if (reader.Read())
            {
                convenio.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                convenio.Valor = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                convenio.Nome = reader.IsDBNull(2) ? "" : reader.GetString(2);
                convenio.Endereco = reader.IsDBNull(3) ? "" : reader.GetString(3);
                convenio.Numero = reader.IsDBNull(4) ? "" : reader.GetString(4);
                convenio.Bairro = reader.IsDBNull(5) ? "" : reader.GetString(5);
                convenio.Cep = reader.IsDBNull(6) ? "" : reader.GetString(6);
                convenio.Cidade = reader.IsDBNull(7) ? "" : reader.GetString(7);
                convenio.Email = reader.IsDBNull(8) ? "" : reader.GetString(8);
                convenio.Celular = reader.IsDBNull(9) ? "" : reader.GetString(9);
                convenio.Cpf = reader.IsDBNull(10) ? "" : reader.GetString(10);
                convenio.UF = reader.IsDBNull(11) ? "" : reader.GetString(11);
                convenio.RG = reader.IsDBNull(12) ? "" : reader.GetString(12);
                convenio.Delete = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                convenio.Telefone = reader.IsDBNull(14) ? "" : reader.GetString(14);
                convenio.PorcentagemDesconto = reader.IsDBNull(15) ? 0 : reader.GetDecimal(15);

                return convenio;
            }
            return convenio;
        }

        private List<Convenio> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Convenio convenio = new Convenio();
            List<Convenio> convenios = new List<Convenio>();
            while (reader.Read())
            {
                convenio  = new Convenio();
                convenio.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                convenio.Valor = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                convenio.Nome = reader.IsDBNull(2) ? "" : reader.GetString(2);
                convenio.Endereco = reader.IsDBNull(3) ? "" : reader.GetString(3);
                convenio.Numero = reader.IsDBNull(4) ? "" : reader.GetString(4);
                convenio.Bairro = reader.IsDBNull(5) ? "" : reader.GetString(5);
                convenio.Cep = reader.IsDBNull(6) ? "" : reader.GetString(6);
                convenio.Cidade = reader.IsDBNull(7) ? "" : reader.GetString(7);
                convenio.Email = reader.IsDBNull(8) ? "" : reader.GetString(8);
                convenio.Celular = reader.IsDBNull(9) ? "" : reader.GetString(9);
                convenio.Cpf = reader.IsDBNull(10) ? "" : reader.GetString(10);
                convenio.UF = reader.IsDBNull(11) ? "" : reader.GetString(11);
                convenio.RG = reader.IsDBNull(12) ? "" : reader.GetString(12);
                convenio.Delete = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                convenio.Telefone = reader.IsDBNull(14) ? "" : reader.GetString(14);
                convenio.PorcentagemDesconto = reader.IsDBNull(15) ? 0 : reader.GetDecimal(15);
                convenios.Add(convenio);
            }
            return convenios;
        }

        private Cliente ClienteByID(int id)
        {
            ClienteDAO clienteDao = new ClienteDAO();
            Cliente cliente = new Cliente();
            cliente.ID = id;
            return clienteDao.ByID(cliente);
        }


        public List<Convenio> GetAll()
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper(sql + " Where [Delete] = 0 ");
            return SetUpFields( dataBaseHelper.Run(this.ConnectionString));
        }

        public void Update(Convenio convenio)
        {
            string query = " UPDATE [Convenios] " +
                           "  SET [Desconto] = '" + convenio.Valor + "' " +
                           "    ,[Nome] = '" + convenio.Nome + "' " +
                           "    ,[Endereco] = '" + convenio.Endereco + "' " +
                           "    ,[Numero] = '" + convenio.Numero + "' " +
                           "    ,[Bairro] = '" + convenio.Bairro + "' " +
                           "    ,[Cep] = '" + convenio.Cep + "' " +
                           "    ,[Cidade] = '" + convenio.Cidade + "' " +
                           "    ,[Email] = '" + convenio.Email + "' " +
                           "    ,[Celular] = '" + convenio.Celular + "' " +
                           "    ,[Cpf] = '" + convenio.Cpf + "' " +
                           "    ,[UF] = '" + convenio.UF + "' " +
                           "    ,[RG] = '" + convenio.RG + "' " +
                           "    ,[Delete] = 0 " +
                           "    ,[Telefone] = '" + convenio.Telefone + "' " +
                             "  ,[Porcentagem] = '" + convenio.PorcentagemDesconto + "' " +
                           " WHERE [ConvenioID] = " + convenio.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Delete(Convenio convenio)
        {
            string query = " UPDATE [Convenios] SET [Delete] = 1 "+
                           " WHERE [Convenios].ConvenioID = " + convenio.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }
    }
}
