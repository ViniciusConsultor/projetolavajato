using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class CredorDAO : DataAccessBase
    {
        private const string sql = " SELECT [CredorID],[PessoaID],[RazaoSocial],[NomeFantasia],[Representante],[Email],[Site],[Delete], [TipoPessoa] " + 
            " FROM [Credor] ";
        private PessoaDAO pessoaDAO;

        public CredorDAO()
        {
            pessoaDAO = new PessoaDAO();
        }

        public Credor ByID(Credor credor)
        {
            string query = sql + " where [Delete] = 0 and credorid =" + credor.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Credor ByID(int credorID)
        {
            string query = sql + " where [Delete] = 0 and credorid =" + credorID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Credor> ByRazaoSocial(Credor credor)
        {
            string query = sql + " where [Delete] = 0 AND RazaoSocial like('%" + credor.RazaoSocial + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Credor> ByNomeFantasia(Credor credor)
        {
            string query = sql + " where [Delete] = 0 AND NomeFantasia like('%" + credor.RazaoSocial + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Credor> GetAll()
        {
            string query = sql + " where [Delete] = 0 ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public Credor Add(Credor credor)
        {
            string query = " INSERT INTO [Lavajado].[dbo].[Credor] " +
                           " ([PessoaID] "+
                           " ,[RazaoSocial]" +
                           " ,[NomeFantasia]" +
                           " ,[Representante]" +
                           " ,[Email]" +
                           " ,[Site]"+
                           " ,[TipoPessoa])" +
                           " VALUES" +
                           " ('"+credor.Pessoa.ID+"' "+
                           " ,'"+credor.RazaoSocial+"' " +
                           " ,'"+credor.NomeFantasia+"'" +
                           " ,'"+credor.Representante+"'" +
                           " ,'"+credor.Email+"'" +
                           " ,'"+credor.Site+"' "+
                           " ,'"+credor.TipoPessoa+"')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
            credor.ID = UltimoIDInserido();
            return credor;
        }

        public void Update(Credor credor)
        {
            string query = " UPDATE [Credor] " +
                           "SET [PessoaID] = '" + credor.Pessoa.ID + "' " +
                           " ,[RazaoSocial] = '" + credor.RazaoSocial + "' " +
                           " ,[NomeFantasia] = '" + credor.NomeFantasia + "' " +
                           " ,[Representante] = '" + credor.Representante + "' " +
                           " ,[Email] = '" + credor.Email + "' " +
                           " ,[Site] = '" + credor.Site + "' " +
                           " ,[TipoPessoa] = '" + credor.TipoPessoa + "' " +
                           " ,[Delete] = 0 " +
                         " WHERE CredorID = " + credor.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Delete(Credor credor)
        {
            string query = " UPDATE [Credor] " +
                           " SET [Delete] = 1" +
                           " WHERE CredorID = " + credor.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        private int UltimoIDInserido()
        {
            string query = "Select max(credorid) from credor";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
        }

        private Credor SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Credor credor = new Credor();
            if (reader.Read())
            {
                credor.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                credor.Pessoa = pessoaDAO.ByID(reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                credor.RazaoSocial = reader.IsDBNull(2) ? "" : reader.GetString(2);
                credor.NomeFantasia = reader.IsDBNull(3) ? "" : reader.GetString(3);
                credor.Representante = reader.IsDBNull(4) ? "" : reader.GetString(4);
                credor.Email = reader.IsDBNull(5) ? "" : reader.GetString(5);
                credor.Site = reader.IsDBNull(6) ? "" : reader.GetString(6);
                credor.Delete = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                credor.TipoPessoa = reader.IsDBNull(8) ? "" : reader.GetString(8);
                
                return credor;
            }
            return credor;
        }

        private List<Credor> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Credor> credores = new List<Credor>();
            Credor credor = new Credor();
            while (reader.Read())
            {
                credor = new Credor();
                credor.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                credor.Pessoa = pessoaDAO.ByID(reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                credor.RazaoSocial = reader.IsDBNull(2) ? "" : reader.GetString(2);
                credor.NomeFantasia = reader.IsDBNull(3) ? "" : reader.GetString(3);
                credor.Representante = reader.IsDBNull(4) ? "" : reader.GetString(4);
                credor.Email = reader.IsDBNull(5) ? "" : reader.GetString(5);
                credor.Site = reader.IsDBNull(6) ? "" : reader.GetString(6);
                credor.Delete = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                credor.TipoPessoa = reader.IsDBNull(8) ? "" : reader.GetString(8);
                credores.Add(credor);
            }
            return credores;
        }


        
    }
}
