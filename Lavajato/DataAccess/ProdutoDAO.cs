using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ProdutoDAO : DataAccessBase
    {
        private const string sql = " SELECT Produto.ProdutoID, Produto.Descricao, Produto.Quantidade, Produto.ValorUnitario, Produto.Minimo, CategoriaProduto.CategoriaProdutoID, " +
                            " CategoriaProduto.Descricao AS CategoriaProduto, Produto.PrecoCompra " +
                            " FROM CategoriaProduto INNER JOIN " +
                            " Produto ON CategoriaProduto.CategoriaProdutoID = Produto.CategoriaProdutoID";

        public ProdutoDAO()
        {

        }

        public void Add(Produto produto)
        {
            string query = " INSERT INTO [Lavajado].[dbo].[Produto] " +
                " ([Descricao],[Quantidade],[ValorUnitario],[Minimo] " +
                " ,[CategoriaProdutoID],[PrecoCompra],[Delete]) " +
                " VALUES " +
                " ('" + produto.Descricao + "' " +
                " ,'" + produto.Quantidade + "' " +
                " ,'" + produto.ValorUnitario.ToString().Replace(",", ".") + "' " +
                " ,'" + produto.Minimo + "'" +
                " ,'" + produto.CategoriaProduto.ID + "' " +
                " ,'" + produto.PrecoCompra.ToString().Replace(",", ".") + "' " +
                " ,0)";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Update(Produto produto)
        {
            string query = " UPDATE [Lavajado].[dbo].[Produto] " +
                   " SET [Descricao] = '" + produto.Descricao + "' " +
                   " ,[Quantidade] = '" + produto.Quantidade + "' " +
                   " ,[ValorUnitario] = '" + produto.ValorUnitario.ToString().Replace(",", ".") + "' " +
                   " ,[Minimo] = '" + produto.Minimo + "' " +
                   " ,[CategoriaProdutoID] = '" + produto.CategoriaProduto.ID + "' " +
                   " ,[PrecoCompra] = '" + produto.PrecoCompra.ToString().Replace(",", ".") + "' " +
                   " ,[Delete] = 0 " +
                   "  WHERE ProdutoID = " + produto.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Delete(Produto produto)
        {
            string query = " UPDATE [Lavajado].[dbo].[Produto] SET [Delete] = 1 WHERE ProdutoID=" + produto.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public Produto ByID(Produto produto)
        {
            string query = sql + " Where Produto.[Delete] = 0 AND Produto.ProdutoID = " + produto.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Produto> GetAll()
        {
            string query = sql + " Where Produto.[Delete] = 0 ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Produto> TipoServico(int TipoProduto)
        {
            DataBaseHelper dataBaseHelper;
            if (TipoProduto == EnumCategoriaProduto.Servico)
            {
                string query = sql + " Where Produto.[Delete] = 0 And Produto.CategoriaProdutoID =" + EnumCategoriaProduto.Servico;
                dataBaseHelper = new DataBaseHelper(query);
            }
            else 
            {
                string query = sql + " Where Produto.[Delete] = 0 And Produto.CategoriaProdutoID =" + EnumCategoriaProduto.Produto;
                dataBaseHelper = new DataBaseHelper(query);
            }
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Produto> ByName(Produto produto)
        {
            string query = sql + " Where Produto.[Delete] = 0 And Produto.Descricao like('%" + produto.Descricao.Trim() + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        private Produto SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Produto produto = new Produto();
            if (reader.Read())
            {
                produto.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                produto.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
                produto.Quantidade = reader.IsDBNull(2) ? 0 : int.Parse(reader.GetString(2));
                produto.ValorUnitario = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                produto.Minimo = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                produto.CategoriaProduto.ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                produto.CategoriaProduto.Descricao = reader.IsDBNull(6) ? "" : reader.GetString(6);
                produto.PrecoCompra = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);

                return produto;
            }
            return produto;
        }

        private List<Produto> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<Produto> produtos = new List<Produto>();
            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                produto.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
                produto.Quantidade = reader.IsDBNull(2) ? 0 : int.Parse(reader.GetString(2));
                produto.ValorUnitario = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                produto.Minimo = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                produto.CategoriaProduto.ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                produto.CategoriaProduto.Descricao = reader.IsDBNull(6) ? "" : reader.GetString(6);
                produto.PrecoCompra = reader.IsDBNull(7) ? 0 : reader.GetDecimal(7);
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
