using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class EstoqueDAO : DataAccessBase
    {
        private const string sql = " SELECT [EstoqueID],[Minimo],[Quantidade] " +
                                " ,[DataInsercao]  FROM [Estoque] ";

        public EstoqueDAO()
        {

        }

        public Estoque Add(Estoque estoque)
        {
            string query = " INSERT INTO [Estoque]" +
                           "([Minimo]" +
                           ",[Quantidade]" +
                           ",[DataInsercao])" +
                           " VALUES" +
                           "('" + estoque.Minimo + "' " +
                           ",'" + estoque.Quantidade + "' " +
                           ",'" + Configuracao.HoraEntrada(estoque.Data) + "')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
            estoque.ID = RetornaUltimoInserido();
            return estoque;
        }

        public Estoque ByID(Estoque estoque)
        {
            string query = sql + " Where [EstoqueID] = " + estoque.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Estoque ByID(int estoqueID)
        {
            string query = sql + " Where [EstoqueID] = " + estoqueID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public void Update(Estoque estoque)
        {
            string query = " UPDATE [Estoque]" +
                           " SET [Minimo] = '" + estoque.Minimo + "'" +
                              ",[Quantidade] = '" + estoque.Quantidade + "'" +
                              ",[DataInsercao] = '" + estoque.Data + "'" +
                         " WHERE EstoqueID = " + estoque.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        private Estoque SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Estoque estoque = new Estoque();
            if (reader.Read())
            {
                estoque.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                //estoque.Produto = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                estoque.Minimo = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                estoque.Quantidade = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                estoque.Data = reader.IsDBNull(3) ? new DateTime(1900,01,01) : reader.GetDateTime(3);
                return estoque;
            }
            return estoque;
        }

        private List<Estoque> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Estoque> estoques = new List<Estoque>();
            Estoque estoque = new Estoque();
            if (reader.Read())
            {
                estoque = new Estoque();
                estoque.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                //estoque.Produto = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                estoque.Minimo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                estoque.Quantidade = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                estoque.Data = reader.IsDBNull(0) ? new DateTime(1900, 01, 01) : reader.GetDateTime(0);
                estoques.Add(estoque);
            }
            return estoques;
        }

        private int RetornaUltimoInserido()
        {
            string query = "select max(EstoqueID) from estoque";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            int id = int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
            return id;
        }


    }
}
