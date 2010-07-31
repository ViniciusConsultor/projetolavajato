﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class RetiradaDAO : DataAccessBase
    {
        private const string sql = " SELECT [RetiradaID],[UsuarioID],[Descricao],[Valor],[Data]  FROM [Lavajado].[dbo].[Retirada] ";

        public RetiradaDAO()
        {

        }

        public Retirada Insert(Retirada retirada)
        {
            string query = " INSERT INTO [Lavajado].[dbo].[Retirada] (" +
                           "  [UsuarioID] " +
                           "  ,[Descricao] " +
                           "  ,[Valor] " +
                           "  ,[Data]) " +
                           "   VALUES " +
                           "  (" + retirada.Usuario.ID + " " +
                           "  ,'" + retirada.Descricao + "' " +
                           "  ,'" + retirada.Valor + "' " +
                           "  ,GetDate()) ";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return UltimaRetirada();
        }

        private Retirada UltimaRetirada()
        {
            string query = " SELECT MAX([RetiradaID])  FROM [Lavajado].[dbo].[Retirada] ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
            Retirada retirada = new Retirada();
            retirada.ID = int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
            return ByID(retirada);
        }

        public Retirada ByID(Retirada retirada)
        {
            string query = sql + " where retiradaid = " + retirada.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run(this.ConnectionString);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        private Retirada SetUpFields(DataSet dataSet)
        { 
            Retirada retirada = new Retirada();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            if (reader.Read())
            {
                retirada.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                retirada.Usuario.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                retirada.Descricao = reader.IsDBNull(2) ? "" : reader.GetString(2);
                retirada.Valor = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                retirada.Data = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                return retirada;
            }
            return retirada;
        }
    }
}