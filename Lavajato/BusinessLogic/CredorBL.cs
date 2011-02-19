using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class CredorBL
    {
        private CredorDAO credorDao = new CredorDAO();
        private PessoaDAO pessoaDao = new PessoaDAO();

        public CredorBL()
        {

        }

        public Credor Add(Credor credor)
        {
            credor.Pessoa = pessoaDao.Add(credor.Pessoa);
            return credorDao.Add(credor);
        }

        public void Update(Credor credor)
        {
            pessoaDao.Update(credor.Pessoa);
            credorDao.Update(credor);
        }

        public Credor ByID(Credor credor)
        {
            return credorDao.ByID(credor);
        }

        public Credor ByID(int credorID)
        {   
            return credorDao.ByID(credorID);
        }

        public DataTable GetAll()
        {
            IList<Credor> credores = credorDao.GetAll();
            DataTable table = CredorTabela.GetAll(credores);

            return table;
        }

        public DataTable ByRazaoSocial(Credor credor)
        {
            IList<Credor> credores = credorDao.ByRazaoSocial(credor);
            DataTable table = CredorTabela.ByRazaoSocial(credores);
            
            return table;
        }

        public DataTable ByNomeFantasia(Credor credor)
        {
            IList<Credor> credores = credorDao.ByNomeFantasia(credor);
            DataTable table = CredorTabela.GetAll(credores);

            return table;
        }

        public void Delete(Credor credor)
        {
            credorDao.Delete(credor);
        }
    }
}
