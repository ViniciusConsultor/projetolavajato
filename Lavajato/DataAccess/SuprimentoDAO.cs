using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class SuprimentoDAO : DataAccessBase
    {
        private const string sql = " SELECT [SuprimentoID],[UsuarioID],[Valor],[Descricao],[Data]  FROM [Lavajado].[dbo].[Suprimentos] ";
        
        public SuprimentoDAO()
        { 
        
        }

        public Suprimento Insert(Suprimento suprimento)
        {
            string query = " INSERT INTO [Suprimentos] "+
                           " ([UsuarioID] "+
                           " ,[Valor] "+
                           " ,[Descricao] "+
                           " ,[Data]) "+
                           " VALUES "+
                           " ('"+suprimento.Usuario.ID+"' "+
                           " ,'"+suprimento.Valor+"' "+
                           " ,'"+suprimento.Descricao+"' " +
                           " ,getdate() )";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return UltimoSuprimento();
        }

        private Suprimento UltimoSuprimento()
        {
            string query = " SELECT MAX([suprimentoid])  FROM [Lavajado].[dbo].[suprimentos] ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
            Suprimento suprimento = new Suprimento();
            suprimento.ID = int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
            return ByID(suprimento);
        }

        public Suprimento ByID(Suprimento suprimento)
        {
            string query = sql + " where suprimentoid = " + suprimento.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run(this.ConnectionString);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        private Suprimento SetUpFields(DataSet dataSet)
        {
            Suprimento retirada = new Suprimento();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            if (reader.Read())
            {
                retirada.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                retirada.Usuario.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                retirada.Valor = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                retirada.Descricao = reader.IsDBNull(3) ? "" : reader.GetString(3);
                retirada.Data = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4); 
            }
            return retirada;
        }
    }

     
}
