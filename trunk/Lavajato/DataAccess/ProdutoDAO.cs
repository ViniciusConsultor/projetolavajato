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
        private const string sql = " SELECT Produto.ProdutoID, Estoque.EstoqueID, CategoriaProduto.CategoriaProdutoID, CategoriaProduto.Descricao, Produto.Descricao, " +
                                   " Produto.PrecoCompra, Produto.ValorUnitario, Produto.ExpositorID " +
                                   " FROM Produto " +
                                   " INNER JOIN CategoriaProduto ON CategoriaProduto.CategoriaProdutoID = Produto.CategoriaProdutoID " +
                                   " INNER JOIN Estoque on Estoque.EstoqueID = Produto.Estoque "+
                                   " LEFT JOIN Expositor on Produto.ExpositorID = Expositor.ExpositorID ";

        private EstoqueDAO estoqueDAO = new EstoqueDAO();
        private ExpositorDAO _expositorDAO = new ExpositorDAO();

        public ProdutoDAO()
        {

        }

        public void Add(Produto produto)
        {
            string query = " INSERT INTO [Produto] " +
                " ([Descricao],[ValorUnitario] " +
                " ,[CategoriaProdutoID],[PrecoCompra],[Delete], [Estoque], [ExpositorID]) " +
                " VALUES " +
                " ('" + produto.Descricao + "' " +
                " ,'" + produto.ValorUnitario.ToString().Replace(",", ".") + "' " +
                " ,'" + produto.CategoriaProduto.ID + "' " +
                " ,'" + produto.PrecoCompra.ToString().Replace(",", ".") + "' " +
                " ,0 "+
                " ,'"+produto.Estoque.ID+"' "+
                " ,'"+produto.Expositor.ID+"' )";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        private Produto Max()
        {
            string query = " SELECT MAX(produtoid) FROM produto ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            
            Produto prod = new Produto();
            prod.ID = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            return ByID(prod);
        }

        public void Update(Produto produto)
        {
            string query = " UPDATE [Produto] " +
                   " SET [Descricao] = '" + produto.Descricao + "' " +
                   " ,[ValorUnitario] = '" + produto.ValorUnitario.ToString().Replace(",", ".") + "' " +
                   " ,[CategoriaProdutoID] = '" + produto.CategoriaProduto.ID + "' " +
                   " ,[PrecoCompra] = '" + produto.PrecoCompra.ToString().Replace(",", ".") + "' " +
                   " ,[Delete] = 0 "+
                   " ,[Estoque]='"+produto.Estoque.ID+"' " +
                   "  WHERE ProdutoID = " + produto.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Delete(Produto produto)
        {
            string query = " UPDATE [Produto] SET [Delete] = 1 WHERE ProdutoID=" + produto.ID;
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

        public DataTable ByCategoria(int TipoProduto)
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
            DataTable table = dataBaseHelper.Run(this.ConnectionString).Tables[0];
            return table;
        }

        public List<Produto> ByName(Produto produto)
        {
            string query = sql + " Where Produto.[Delete] = 0 And Produto.Descricao like('%" + produto.Descricao.Trim() + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        /// <summary>
        /// Retorna produtos por categoria
        /// </summary>
        /// <param name="produto">Produto</param>
        /// <returns>Listagem de Produtos</returns>
        public List<Produto> ByCategoria(Produto produto)
        {
            string query = sql + " Where Produto.CategoriaProdutoID = 1 and  Produto.[Delete] = 0 " +
            " And Produto.Descricao like('%" + produto.Descricao.Trim() + "%') ";

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
                produto.Estoque = estoqueDAO.ByID(reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                produto.CategoriaProduto.ID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                produto.CategoriaProduto.Descricao = reader.IsDBNull(3) ? "" : reader.GetString(3);
                produto.Descricao = reader.IsDBNull(4) ? "" : reader.GetString(4);
                produto.PrecoCompra = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                produto.ValorUnitario = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                produto.Expositor = _expositorDAO.ByID(reader.IsDBNull(7) ? 0 : reader.GetInt32(7));
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
                produto.Estoque = estoqueDAO.ByID(reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                produto.CategoriaProduto.ID = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                produto.CategoriaProduto.Descricao = reader.IsDBNull(3) ? "" : reader.GetString(3);
                produto.Descricao = reader.IsDBNull(4) ? "" : reader.GetString(4);
                produto.PrecoCompra = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                produto.ValorUnitario = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                produto.Expositor = _expositorDAO.ByID(reader.IsDBNull(7) ? 0 : reader.GetInt32(7));
                produtos.Add(produto);
            }
            return produtos;
        }
    }
}
