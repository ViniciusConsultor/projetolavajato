using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class CategoriaProdutoBL
    {
        private CategoriaProdutoDAO categoriaProdutoDAO = new CategoriaProdutoDAO();

        public CategoriaProdutoBL()
        {

        }

        public List<CategoriaProduto> GetAll()
        {
            return categoriaProdutoDAO.GetAll();
        }
    }
}
