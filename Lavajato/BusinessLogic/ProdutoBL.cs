using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Interface;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ProdutoBL : IProdutoRepositorio, IEstoque
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private EstoqueBL estoqueDAO = new EstoqueBL();

        #region

        public ProdutoBL()
        {

        }

        #region Produto

        Produto IGeneric<Produto>.Add(Produto obj)
        {
            estoqueDAO.Add(obj.Estoque);
            produtoDAO.Add(obj);
            return obj;
        }

        Produto IGeneric<Produto>.Update(Produto obj)
        {
            estoqueDAO.Update(obj.Estoque);
            produtoDAO.Update(obj);
            return obj;
        }

        List<Produto> IGeneric<Produto>.GetAll()
        {
            return produtoDAO.GetAll();
        }

        public DataTable GetAll(List<Produto> produtos)
        {
            return produtos.GetProdutos();
        }

        public DataTable GetProdutos(List<Produto> produtos)
        {
            return produtos.GetProdutos();
        }

        public int LastInserted()
        {
            throw new NotImplementedException();
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

        #endregion


        #region Estoque

        public Estoque Add(Estoque obj)
        {
            estoqueDAO.Add(obj);
            return obj;
        }

        public void Delete(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public Estoque ByID(Estoque obj)
        {
            throw new NotImplementedException();
        }

        public Estoque Update(Estoque obj)
        {
            estoqueDAO.Update(obj);
            return obj;
        }

        List<Estoque> IGeneric<Estoque>.GetAll()
        {
            throw new NotImplementedException();
        }

        #endregion

    
        #endregion


       
    }
}
