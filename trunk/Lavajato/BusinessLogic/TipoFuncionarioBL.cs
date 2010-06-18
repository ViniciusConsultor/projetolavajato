using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class TipoFuncionarioBL
    {
        public TipoFuncionarioDAO categoriaProdutoDAO = new TipoFuncionarioDAO();

        public TipoFuncionarioBL()
        {

        }

        public List<TipoFuncionario> GetAll()
        {
            return categoriaProdutoDAO.GetAll();
        }
    }
}
