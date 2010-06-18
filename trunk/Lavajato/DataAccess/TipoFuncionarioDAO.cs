using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class TipoFuncionarioDAO : DataAccessBase
    {
        private const string sql = " SELECT [TipoFuncionarioID],[Descricao]  FROM [Lavajado].[dbo].[TipoFuncionario] ";
        public TipoFuncionarioDAO()
        {

        }

        public List<TipoFuncionario> GetAll()
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper(sql);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpTiposFuncionario(dataSet);
        }

        public TipoFuncionario ByID(TipoFuncionario tipoFunc)
        {
            string query = sql + " where tipofuncionarioid = " + tipoFunc.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpTipoFuncionario(dataSet);
        }

        private List<TipoFuncionario> SetUpTiposFuncionario(DataSet dataSet)
        {
            List<TipoFuncionario> tiposfunc = new List<TipoFuncionario>();

            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                TipoFuncionario tipofun = new TipoFuncionario();
                tipofun.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                tipofun.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
                tiposfunc.Add(tipofun);
            }
            return tiposfunc;
        }

        private TipoFuncionario SetUpTipoFuncionario(DataSet dataSet)
        {
            TipoFuncionario tipofun = new TipoFuncionario();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                tipofun.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                tipofun.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
            }
            return tipofun;
        }
    }
}
