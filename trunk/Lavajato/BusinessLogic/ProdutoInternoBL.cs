using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ProdutoInternoBL
    {
        EstoqueBL estoqueDAO = new EstoqueBL();
        ProdutoInternoDAO produtoDAO = new ProdutoInternoDAO();

        public ProdutoInternoBL()
        { 
        
        }
        public void Add(ProdutoInterno produto)
        {
            
            estoqueDAO.Add(produto.Estoque);
            produtoDAO.Add(produto);
        }

        public void Delete(ProdutoInterno produto)
        {
            produtoDAO.Delete(produto);
        }

        public void Update(ProdutoInterno produto)
        {
            estoqueDAO.Update(produto.Estoque);
            produtoDAO.Update(produto);
        }

        public ProdutoInterno ByID(ProdutoInterno produto)
        {
            return produtoDAO.ByID(produto);
        }

        public DataTable GetAll()
        {
            return GetProdutos(produtoDAO.GetAll());
        }

        public DataTable ByName(ProdutoInterno produto)
        {
            return GetProdutos(produtoDAO.ByName(produto));
        }

        public DataTable TipoServico(int TipoProduto)
        {
            return GetProdutos(produtoDAO.TipoServico(TipoProduto));
        }


        public DataTable GetProdutos(List<ProdutoInterno> produtos)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(GetColumns());

            foreach (ProdutoInterno prod in produtos)
            {
                DataRow row = table.NewRow();
                row["ID"] = prod.ID;
                row["Descricao"] = prod.Descricao;
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
            desc.ColumnName = "Descricao";
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
