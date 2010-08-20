using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ProdutoInternoDAO : DataAccessBase
    {
        private const string sql = " SELECT Produto.ProdutoID, Estoque.EstoqueID, CategoriaProduto.CategoriaProdutoID, CategoriaProduto.Descricao, Produto.Descricao, " +
                                  " Produto.PrecoCompra, Produto.ValorUnitario " +
                                  " FROM ProdutoInterno as Produto " +
                                  " INNER JOIN CategoriaProduto ON CategoriaProduto.CategoriaProdutoID = Produto.CategoriaProdutoID " +
                                  " INNER JOIN Estoque on Estoque.EstoqueID = Produto.Estoque ";

        private EstoqueDAO estoqueDAO = new EstoqueDAO();

        public ProdutoInternoDAO()
        {
 
        }

        public void Add(ProdutoInterno produto)
        {
            string query = " INSERT INTO [ProdutoInterno] " +
                " ([Descricao],[ValorUnitario] " +
                " ,[CategoriaProdutoID],[PrecoCompra],[Delete], [Estoque]) " +
                " VALUES " +
                " ('" + produto.Descricao + "' " +
                " ,'" + produto.ValorUnitario.ToString().Replace(",", ".") + "' " +
                " ,'" + produto.CategoriaProduto.ID + "' " +
                " ,'" + produto.PrecoCompra.ToString().Replace(",", ".") + "' " +
                " ,0 " +
                " ,'" + produto.Estoque.ID + "')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Update(ProdutoInterno produto)
        {
            string query = " UPDATE [ProdutoInterno] " +
                   " SET [Descricao] = '" + produto.Descricao + "' " +
                   " ,[ValorUnitario] = '" + produto.ValorUnitario.ToString().Replace(",", ".") + "' " +
                   " ,[CategoriaProdutoID] = '" + produto.CategoriaProduto.ID + "' " +
                   " ,[PrecoCompra] = '" + produto.PrecoCompra.ToString().Replace(",", ".") + "' " +
                   " ,[Delete] = 0 " +
                   " ,[Estoque]='" + produto.Estoque.ID + "' " +
                   "  WHERE ProdutoID = " + produto.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Delete(ProdutoInterno produto)
        {
            string query = " UPDATE [Produto] SET [Delete] = 1 WHERE ProdutoID=" + produto.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public ProdutoInterno ByID(ProdutoInterno produto)
        {
            string query = sql + " Where Produto.[Delete] = 0 AND Produto.ProdutoID = " + produto.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<ProdutoInterno> GetAll()
        {
            string query = sql + " Where Produto.[Delete] = 0 ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<ProdutoInterno> TipoServico(int TipoProduto)
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

        public List<ProdutoInterno> ByName(ProdutoInterno produto)
        {
            string query = sql + " Where Produto.[Delete] = 0 And Produto.Descricao like('%" + produto.Descricao.Trim() + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        private ProdutoInterno SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            ProdutoInterno produto = new ProdutoInterno();
            if (reader.Read())
            {
                produto.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                produto.Estoque = estoqueDAO.ByID(reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                produto.CategoriaProduto.ID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                produto.CategoriaProduto.Descricao = reader.IsDBNull(3) ? "" : reader.GetString(3);
                produto.Descricao = reader.IsDBNull(4) ? "" : reader.GetString(4);
                produto.PrecoCompra = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                produto.ValorUnitario = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                return produto;
            }
            return produto;
        }

        private List<ProdutoInterno> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<ProdutoInterno> produtos = new List<ProdutoInterno>();
            while (reader.Read())
            {
                ProdutoInterno produto = new ProdutoInterno();
                produto.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                produto.Estoque = estoqueDAO.ByID(reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                produto.CategoriaProduto.ID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                produto.CategoriaProduto.Descricao = reader.IsDBNull(3) ? "" : reader.GetString(3);
                produto.Descricao = reader.IsDBNull(4) ? "" : reader.GetString(4);
                produto.PrecoCompra = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                produto.ValorUnitario = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
