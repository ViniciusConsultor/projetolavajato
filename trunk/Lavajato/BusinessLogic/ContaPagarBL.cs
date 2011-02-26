using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ContaPagarBL
    {
        private ContaAPagarDAO contaPagarDAO = new ContaAPagarDAO();

        public ContaPagarBL()
        {

        }

        public ContaPagar Add(ContaPagar contaPagar)
        {
            return contaPagarDAO.Insert(contaPagar);
        }

        public void Delete(ContaPagar contaPagar)
        {
           // contaPagarDAO.Delete(contaPagarDAO);
        }

        public ContaPagar Update(ContaPagar contaPagar)
        {
            return contaPagarDAO.Insert(contaPagar);
        }

        public DataTable GetAll()
        {

            IList<ContaPagar> contasPagar = contaPagarDAO.GetAll();
            DataTable dataTable = ContaPagarTabela.PesquisaPorDataETipo(contasPagar);

            return dataTable;
        }

    }
}
