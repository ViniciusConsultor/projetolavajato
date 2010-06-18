using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class RetiradaBL
    {
        private RetiradaDAO retiradaDAO = new RetiradaDAO();

        public RetiradaBL()
        {

        }

        public Retirada Insert(Retirada retirada)
        {
            return retiradaDAO.Insert(retirada);
        }
    }
}
