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
        private const string sql = " SELECT [SuprimentoID],[UsuarioID],[Valor],[Descricao],[Data]  FROM [Suprimentos] ";
        
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
                           " ,'" + suprimento.Valor.ToString().Replace(",", ".") + "' " +
                           " ,'"+suprimento.Descricao+"' " +
                           " ,getdate() )";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            return UltimoSuprimento();
        }

        private Suprimento UltimoSuprimento()
        {
            string query = " SELECT MAX([suprimentoid])  FROM [suprimentos] ";
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
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Suprimento> ByDate(DateTime date)
        {
            string query = sql + " where convert(varchar, data, 103) = '" + ConvertDataFormatoPTBR(date) + "'";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
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

        private Suprimento SetUpField(DataSet dataSet)
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

        private List<Suprimento> SetUpFields(DataSet dataSet)
        {
            List<Suprimento> suprimentos = new List<Suprimento>();
            
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                Suprimento suprimento = new Suprimento();
                suprimento.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                suprimento.Usuario.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                suprimento.Valor = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                suprimento.Descricao = reader.IsDBNull(3) ? "" : reader.GetString(3);
                suprimento.Data = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4);
                suprimentos.Add(suprimento);
            }
            return suprimentos;
        }

        public void Update(Suprimento _suprimento)
        {
            string query = " UPDATE [Lavajato].[dbo].[Suprimentos] " +
                           "SET " +
                           "   [Valor] = " + _suprimento.Valor.ToString().Replace(",", ".") +
                           "   ,[Descricao] = '"+_suprimento.Descricao+"' " +
                           " WHERE suprimentoid = " + _suprimento.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }
    }

     
}
