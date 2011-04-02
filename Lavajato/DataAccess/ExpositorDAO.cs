using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ExpositorDAO : DataAccessBase
    {
        private const string sql = " SELECT [ExpositorID],[Minimo],[Quantidade] " +
                                " ,[DataInsercao]  FROM [Expositor] ";

        public ExpositorDAO()
        {
            
        }

        public Expositor Add(Expositor expositor)
        {
            string query = " INSERT INTO [Expositor]" +
                           "([Minimo]" +
                           ",[Quantidade]" +
                           ",[DataInsercao])" +
                           " VALUES" +
                           "('" + expositor.Minimo + "' " +
                           ",'" + expositor.Quantidade + "' " +
                           ",'" + Configuracao.HoraEntrada(expositor.Data) + "')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
            expositor.ID = RetornaUltimoInserido();
            return expositor;
        }

        public Expositor ByID(Expositor expositor)
        {
            string query = sql + " Where [ExpositorID] = " + expositor.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Expositor ByID(int ExpositorID)
        {
            string query = sql + " Where [ExpositorID] = " + ExpositorID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public void Update(Expositor expositor)
        {
            string query = " UPDATE [Expositor]" +
                           " SET [Minimo] = '" + expositor.Minimo + "'" +
                              ",[Quantidade] = '" + expositor.Quantidade + "'" +
                              ",[DataInsercao] = '" + expositor.Data + "'" +
                         " WHERE ExpositorID = " + expositor.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        private Expositor SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Expositor expositor = new Expositor();
            if (reader.Read())
            {
                expositor.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                //expositor.Produto = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                expositor.Minimo = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                expositor.Quantidade = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                expositor.Data = reader.IsDBNull(3) ? new DateTime(1900,01,01) : reader.GetDateTime(3);
                return expositor;
            }
            return expositor;
        }

        private List<Expositor> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Expositor> expositors = new List<Expositor>();
            Expositor expositor = new Expositor();
            if (reader.Read())
            {
                expositor = new Expositor();
                expositor.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                //expositor.Produto = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                expositor.Minimo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                expositor.Quantidade = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                expositor.Data = reader.IsDBNull(0) ? new DateTime(1900, 01, 01) : reader.GetDateTime(0);
                expositors.Add(expositor);
            }
            return expositors;
        }

        private int RetornaUltimoInserido()
        {
            string query = "select max(ExpositorID) from expositor";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            int id = int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
            return id;
        }


    }
}
