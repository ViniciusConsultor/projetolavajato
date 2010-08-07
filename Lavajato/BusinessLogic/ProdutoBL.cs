using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

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

        public List<Produto> GetAll()
        {
            return produtoDAO.GetAll();
        }

        public List<Produto> ByName(Produto produto)
        {
            return produtoDAO.ByName(produto);
        }

        public List<Produto> TipoServico(int TipoProduto)
        {
            return produtoDAO.TipoServico(TipoProduto);
        }
    }
}
