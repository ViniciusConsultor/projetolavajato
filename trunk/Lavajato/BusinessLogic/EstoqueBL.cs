using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{    
    public class EstoqueBL
    {
        private EstoqueDAO estoqueDAO = new EstoqueDAO();

        public EstoqueBL()
        {
        
        }

        public void Update(Estoque estoque)
        {
            estoqueDAO.Update(estoque);
        }


        public void Add(Estoque estoque)
        {
            estoqueDAO.Add(estoque);
        }
    }
    
}
