using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class SuprimentoBL
    {
        private SuprimentoDAO suprimentoDAO = new SuprimentoDAO();

        public SuprimentoBL()
        {

        }

        public Suprimento Insert(Suprimento suprimento)
        {
            return suprimentoDAO.Insert(suprimento);
        }

        public Suprimento ByID(Suprimento suprimento)
        {
            return suprimentoDAO.ByID(suprimento);
        }


    }
}
