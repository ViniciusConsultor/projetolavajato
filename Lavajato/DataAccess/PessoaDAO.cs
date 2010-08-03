using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class PessoaDAO : DataAccessBase
    {
        private const string sql = " SELECT [PessoaID],[Endereco],[Numero],[Bairro],[Cep],[UF],[Complemento],[Telefone],[Fax] " +
                       " ,[Cnpj],[InsEstadual],[Cpf],[Rg] " +
                       " FROM [Pessoa] ";


        public PessoaDAO()
        {

        }

        public Pessoa ByID(Pessoa pessoa)
        {
            string query = sql + " Where [Delete] = 0 and pessoaid = " + pessoa.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Pessoa ByID(int pessoaID)
        {
            string query = sql + " Where pessoaid = " + pessoaID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);

            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Pessoa Add(Pessoa pessoa)
        {
            string query = " INSERT INTO [Lavajado].[dbo].[Pessoa]" +
                           " ([Endereco],[Numero],[Bairro]" +
                           " ,[Cep],[UF],[Complemento]" +
                           " ,[Telefone],[Fax],[Cnpj]" +
                           " ,[InsEstadual],[Cpf],[Rg])" +
                           " VALUES " +
                           " ('" + pessoa.Endereco + "' " +
                           " ,'" + pessoa.Numero + "'  " +
                           " ,'" + pessoa.Bairro + "'  " +
                           " ,'" + pessoa.Cep + "'  " +
                           " ,'" + pessoa.UF + "'  " +
                           " ,'" + pessoa.Complemento + "'  " +
                           " ,'" + pessoa.Telefone + "'  " +
                           " ,'" + pessoa.Fax + "'  " +
                           " ,'" + pessoa.Cnpj + "'  " +
                           " ,'" + pessoa.InsEstadual + "' " +
                           " ,'" + pessoa.Cpf + "'  " +
                           " ,'" + pessoa.Rg + "' )";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
            pessoa.ID = UltimoIDInserido();
            return pessoa;
        }

        public void Update(Pessoa pessoa)
        {
            string query = " UPDATE [Pessoa] " +
                           " SET [Endereco] = '" + pessoa.Endereco + "' " +
                              " ,[Numero] = '" + pessoa.Numero + "' " +
                              " ,[Bairro] = '" + pessoa.Bairro + "' " +
                              " ,[Cep] = '" + pessoa.Cep + "' " +
                              " ,[UF] = '" + pessoa.UF + "' " +
                              " ,[Complemento] = '" + pessoa.Complemento + "' " +
                              " ,[Telefone] = '" + pessoa.Telefone + "' " +
                              " ,[Fax] = '" + pessoa.Fax + "' " +
                              " ,[Cnpj] = '" + pessoa.Cnpj + "' " +
                              " ,[InsEstadual] = '" + pessoa.InsEstadual + "' " +
                              " ,[Cpf] = '" + pessoa.Cpf + "' " +
                              " ,[Rg] = '" + pessoa.Rg + "' " +
                         " WHERE PessoaID = " + pessoa.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Delete(Pessoa pessoa)
        {
            /*string query = " UPDATE [Pessoa] " +
                               " SET [Delete] = '" + pessoa.Delete + "' " +
                             " WHERE PessoaID = " + pessoa.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run(); */
        }

        private Pessoa SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Pessoa pessoa = new Pessoa();
            if (reader.Read())
            {
                pessoa.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                pessoa.Endereco= reader.IsDBNull(1) ? "" : reader.GetString(1);
                pessoa.Numero= reader.IsDBNull(2) ? "" : reader.GetString(2);
                pessoa.Bairro= reader.IsDBNull(3) ? "" : reader.GetString(3);
                pessoa.Cep= reader.IsDBNull(4) ? "" : reader.GetString(4);
                pessoa.UF= reader.IsDBNull(5) ? "" : reader.GetString(5);
                pessoa.Complemento= reader.IsDBNull(6) ? "" : reader.GetString(6);
                pessoa.Telefone= reader.IsDBNull(7) ? "" : reader.GetString(7);
                pessoa.Fax= reader.IsDBNull(8) ? "" : reader.GetString(8);
                pessoa.Cnpj= reader.IsDBNull(9) ? "" : reader.GetString(9);
                pessoa.InsEstadual= reader.IsDBNull(10) ? "" : reader.GetString(10);
                pessoa.Cpf= reader.IsDBNull(11) ? "" : reader.GetString(11);
                pessoa.Rg= reader.IsDBNull(12) ? "" : reader.GetString(12);

                return pessoa;
            }
            return pessoa;
        }

        private List<Pessoa> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa pessoa = new Pessoa();
            if (reader.Read())
            {
                pessoa.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                pessoa.Endereco = reader.IsDBNull(1) ? "" : reader.GetString(1);
                pessoa.Numero = reader.IsDBNull(2) ? "" : reader.GetString(2);
                pessoa.Bairro = reader.IsDBNull(3) ? "" : reader.GetString(3);
                pessoa.Cep = reader.IsDBNull(4) ? "" : reader.GetString(4);
                pessoa.UF = reader.IsDBNull(5) ? "" : reader.GetString(5);
                pessoa.Complemento = reader.IsDBNull(6) ? "" : reader.GetString(6);
                pessoa.Telefone = reader.IsDBNull(7) ? "" : reader.GetString(7);
                pessoa.Fax = reader.IsDBNull(8) ? "" : reader.GetString(8);
                pessoa.Cnpj = reader.IsDBNull(9) ? "" : reader.GetString(9);
                pessoa.InsEstadual = reader.IsDBNull(10) ? "" : reader.GetString(10);
                pessoa.Cpf = reader.IsDBNull(11) ? "" : reader.GetString(11);
                pessoa.Rg = reader.IsDBNull(12) ? "" : reader.GetString(12);

                pessoas.Add(pessoa);
            }
            return pessoas;
        }

        private int UltimoIDInserido()
        {
            string query = "Select Max(PessoaID) FROM pessoa";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
        }
    }
}
