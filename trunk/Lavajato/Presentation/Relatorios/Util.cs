using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DataAccess;
using System.Data.SqlClient;

namespace HenryCorporation.Lavajato.Presentation
{
    public class Util : DataAccess.DataAccessBase
    {
        
        public Util()
        {

        }

        public DataSet byQuery(string query)
        {

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return dataBaseHelper.Run(this.ConnectionString);

        }

        public DataSet byProcedure(string query, SqlParameter[] parameter)
        {
            
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Parameters = parameter;
            return dataBaseHelper.RunProcedure(query);

        }
    }
}
