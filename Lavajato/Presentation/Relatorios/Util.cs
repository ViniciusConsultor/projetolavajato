using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DataAccess;

namespace HenryCorporation.Lavajato.Presentation
{
    public class Util : DataAccess.DataAccessBase
    {
        
        public Util()
        {

        }

        public DataSet GeraTabela(string query)
        {
            if (query.Length == 0)
                throw new Exception("Nenhum consulta para geração de relatório encontrado");


            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return dataBaseHelper.Run(this.ConnectionString);

            
        }
    }
}
