using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class DataAccessBase
    {
        
        public DataAccessBase()
        { 
        }

        protected string Sql { get; set; }
        protected string ConnectionString
        {
            get 
            {
                return ConfigurationManager.ConnectionStrings["SQLCONN"].ToString();
            }
        }
    }
}
