using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class RetiradaDAO : DataAccessBase
    {
        private const string sql = " SELECT [RetiradaID],[UsuarioID],[Descricao],[Valor],[Data], [Vale], [UsuarioVale]  FROM [Retirada] ";

        public RetiradaDAO()
        {

        }

        public Retirada Add(Retirada retirada)
        {
            string query = " INSERT INTO [Retirada] (" +
                           "  [UsuarioID] " +
                           "  ,[Descricao] " +
                           "  ,[Valor] " +
                           "  ,[Data] " +
                           "  ,[Vale] " +
                           "  ,[UsuarioVale] ) " +
                           "   VALUES " +
                           "  (" + retirada.Usuario.ID + " " +
                           "  ,'" + retirada.Descricao + "' " +
                           "  ,'" + retirada.Valor.ToString().Replace(",", ".") + "' " +
                           "  ,GetDate() " +
                           "  ,'" + retirada.Vale.isVale + "' " +
                           "  ,'" + retirada.Vale.Usuario.ID + "' )";


            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return UltimaRetirada();
        }

        public void Update(Retirada retirada)
        {

            string query = " UPDATE [Lavajato].[dbo].[Retirada] " +
            "SET " +
             "  [Descricao] = '" + retirada.Descricao + "'" +
             "  ,[Valor] = '" + retirada.Valor.ToString().Replace(",", ".") + "' " +
             " WHERE retiradaID =" + retirada.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        private Retirada UltimaRetirada()
        {
            string query = " SELECT MAX([RetiradaID])  FROM [Retirada] ";
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
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Retirada> ByDate(DateTime date)
        {
            string query = sql + " where convert(varchar, Data, 103) = '" + ConvertDataFormatoPTBR(date) + "'";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run(this.ConnectionString);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Retirada> GetAll()
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper(sql);
            dataBaseHelper.Run(this.ConnectionString);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        private static string ConvertDataFormatoPTBR(DateTime date)
        {
            string mes = date.Month > 1 ? "0" + date.Month.ToString() : date.Month.ToString();
            string dia = date.Day.ToString().Length == 1 ? "0" + date.Day.ToString() : date.Day.ToString();
            string ano = date.Year.ToString();

            return dia + "/" + mes + "/" + ano;
        }

        private Retirada SetUpField(DataSet dataSet)
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
                retirada.Vale.isVale = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                retirada.Vale.Usuario.ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                
                return retirada;
            }
            return retirada;
        }

        private List<Retirada> SetUpFields(DataSet dataSet)
        {
            List<Retirada> retiradas = new List<Retirada>();
            Retirada retirada;
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                retirada = new Retirada();
                retirada.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                retirada.Usuario.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                retirada.Descricao = reader.IsDBNull(2) ? "" : reader.GetString(2);
                retirada.Valor = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                retirada.Data = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                retirada.Vale.isVale = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                retirada.Vale.Usuario.ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                retiradas.Add(retirada);
            }

            return retiradas;
        }

       
    }
}
