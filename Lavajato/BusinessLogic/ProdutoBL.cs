using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ProdutoBL
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private EstoqueDAO estoqueDAO = new EstoqueDAO();

        public ProdutoBL()
        {
        }

        public void Add(Produto produto)
        {
            estoqueDAO.Add(produto.Estoque);
            produtoDAO.Add(produto);
        }

        public void Delete(Produto produto)
        {
            produtoDAO.Delete(produto);
        }

        public void Update(Produto produto)
        {
            estoqueDAO.Update(produto.Estoque);
            produtoDAO.Update(produto);
        }

        public Produto ByID(Produto produto)
        {
            return produtoDAO.ByID(produto);
        }

        public DataTable GetAll()
        {
            return GetProdutos(produtoDAO.GetAll());
        }

        public DataTable ByName(Produto produto)
        {
            return GetProdutos(produtoDAO.ByName(produto));
        }

        public DataTable TipoServico(int TipoProduto)
        {
            return GetProdutos(produtoDAO.TipoServico(TipoProduto));
        }


        public DataTable GetProdutos(List<Produto> produtos)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(GetColumns());

            foreach (Produto prod in produtos)
            {
                DataRow row = table.NewRow();
                row["ID"] = prod.ID;
                row["Descrição"] = prod.Descricao;
                row["Estoque"] = prod.Estoque.Quantidade;
                row["Preço"] = prod.ValorUnitario.ToString("C");
                table.Rows.Add(row);
            }
            return table;
        }

        public DataColumn[] GetColumns()
        {
            DataColumn[] columns = new DataColumn[4];

            DataColumn id = new DataColumn();
            id.ColumnName = "ID";
            columns[0] = id;

            DataColumn desc = new DataColumn();
            desc.ColumnName = "Descrição";
            columns[1] = desc;

            DataColumn estq = new DataColumn();
            estq.ColumnName = "Estoque";
            columns[2] = estq;

            DataColumn valorVenda = new DataColumn();
            valorVenda.ColumnName = "Preço";
            columns[3] = valorVenda;

            return columns;
        }
    }
}
