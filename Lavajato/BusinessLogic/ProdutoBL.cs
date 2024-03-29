﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Interface;
using System.Windows.Forms;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ProdutoBL : IProdutoRepositorio, IEstoque
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private EstoqueBL estoqueDAO = new EstoqueBL();
        private ExpositorDAO expositorDAO = new ExpositorDAO();

        #region

        public ProdutoBL()
        {

        }

        #region Produto

        Produto IGeneric<Produto>.Add(Produto obj)
        {
            estoqueDAO.Add(obj.Estoque);
            expositorDAO.Add(obj.Expositor);
            produtoDAO.Add(obj);
            return obj;
        }

        Produto IGeneric<Produto>.Update(Produto obj)
        {
            estoqueDAO.Update(obj.Estoque);
            expositorDAO.Update(obj.Expositor);
            produtoDAO.Update(obj);
            return obj;
        }

        List<Produto> IGeneric<Produto>.GetAll()
        {
            return  produtoDAO.GetAll();
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
            expositorDAO.Update(produto.Expositor);
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
            return produtoDAO.ByCategoria(TipoProduto);
        }

        public IList<Produto> Categoria(int categoria)
        {
            return produtoDAO.TipoServico(categoria);
        }


        public List<Produto> ByCategoria(Produto produto)
        {
            return produtoDAO.ByCategoria(produto);
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
