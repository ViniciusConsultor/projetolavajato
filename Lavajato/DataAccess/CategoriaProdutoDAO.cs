using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class CategoriaProdutoDAO : DataAccessBase
    {
        private const string sql = " SELECT [CategoriaProdutoID],[Descricao] FROM [CategoriaProduto]";

        public CategoriaProdutoDAO()
        {

        }

        public CategoriaProduto Add(CategoriaProduto categoriaProduto)
        {
            string query = " INSERT INTO [CategoriaProduto]" +
                           " ([Descricao])" +
                           " VALUES" +
                           " ('"+categoriaProduto.Descricao+"')";

            categoriaProduto.ID = UltimoInserido();
            return categoriaProduto;
        }

        public CategoriaProduto ByID(CategoriaProduto categoriaProduto)
        {
            string query = "where [CategoriaProdutoID] = " + categoriaProduto.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);

            return  SetUpField(dataSet);
        }

        public CategoriaProduto ByName(CategoriaProduto categoriaProduto)
        {
            string query = sql + " where [Descricao] like('%" + categoriaProduto.Descricao + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dataSet);
        }

        public void Update(CategoriaProduto categoriaProduto)
        {
            string query = " UPDATE [CategoriaProduto] " +
                           " SET [Descricao] = '" + categoriaProduto.Descricao + "' " +
                         " WHERE  [CategoriaProdutoID] = " + categoriaProduto.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public List<CategoriaProduto> GetAll()
        {
            DataBaseHelper dataBaseHelper = new DataBaseHelper(sql);
            DataTableReader reader = dataBaseHelper.Run(this.ConnectionString).CreateDataReader();
            List<CategoriaProduto> categoriaProdutos = new List<CategoriaProduto>();
            while (reader.Read())
            {
                CategoriaProduto categoriaProduto = new CategoriaProduto();
                categoriaProduto.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                categoriaProduto.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
                categoriaProdutos.Add(categoriaProduto);
            }
            return categoriaProdutos;
        }

        private CategoriaProduto SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            CategoriaProduto catProd = new CategoriaProduto();
            if (reader.Read())
            {
                catProd.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                catProd.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
                return catProd;
            }
            return catProd;
        }

        private int UltimoInserido()
        {
            string query = " SELECT [CategoriaProdutoID] FROM [CategoriaProduto] ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
        }
    }
}
