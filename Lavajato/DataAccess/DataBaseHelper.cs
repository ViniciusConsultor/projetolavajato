using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class DataBaseHelper : DataAccessBase
    {
        private SqlParameter[] _sqlParameters;

        public DataBaseHelper(string sql)
        {
            Sql = sql;
        }
        
        public SqlParameter[] Parameters
        {
            get { return _sqlParameters; }
            set { _sqlParameters = value; }
        }

        public void Run(SqlTransaction transaction)
        {
            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, Sql, Parameters);
        }

        public void Run(SqlTransaction sqlTransaction, SqlParameter[] parameters)
        {
            SqlHelper.ExecuteNonQuery(sqlTransaction, CommandType.Text, Sql, parameters);
        }

        public DataSet Run(string connectionString, SqlParameter[] parameters)
        {
            DataSet ds;
            ds = SqlHelper.ExecuteDataset(connectionString, Sql, parameters);
            return ds;
        }

        public object RunScalar(string connectionString, SqlParameter[] parameters)
        {
            object obj;
            obj = SqlHelper.ExecuteScalar(connectionString, Sql, parameters);
            return obj;
        }

        public object RunScalar(SqlTransaction transaction, SqlParameter[] parameters)
        {
            object obj;
            obj = SqlHelper.ExecuteScalar(transaction, Sql, parameters);
            return obj;
        }

        public DataSet Run(string connectionString)
        {
            DataSet ds;
            ds = SqlHelper.ExecuteDataset(connectionString, CommandType.Text, this.Sql);
            return ds;
        }

        public void Run()
        {
            SqlHelper.ExecuteNonQuery(base.ConnectionString, CommandType.Text, this.Sql, this.Parameters );
        }

        public DataSet RunProcedure(string procedure)
        {
            return SqlHelper.ExecuteDataset(base.ConnectionString, procedure, this.Parameters);
        }

        public SqlDataReader Run(SqlParameter[] parameters)
        {
            SqlDataReader dr;
            dr = SqlHelper.ExecuteReader(base.ConnectionString, CommandType.Text, this.Sql, parameters);
            return dr;
        }
    }
}
