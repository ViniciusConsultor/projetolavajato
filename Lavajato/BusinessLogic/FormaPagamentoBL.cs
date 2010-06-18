using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class FormaPagamentoBL
    {
        private FormaPagamentoDAO forPagamentoDAO = new FormaPagamentoDAO();

        public FormaPagamentoBL()
        {

        }

        public List<FormaPagamento> GetAll()
        {
            return forPagamentoDAO.GetAll();
        }
    }
}
