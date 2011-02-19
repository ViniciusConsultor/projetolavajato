using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ConvenioBL
    {
        private ConvenioDAO convenioDao = new ConvenioDAO();
        private ClienteBL clienteBL = new ClienteBL();

        public ConvenioBL()
        {

        }

        public Convenio Add(Convenio convenio)
        {
            return convenioDao.Add(convenio);
        }

        private Cliente ClienteSalva(Cliente cliente)
        {
            return clienteBL.Insert(cliente);
        }

        public void Delete(Convenio convenio)
        {
            convenioDao.Delete(convenio);
        }

        public void Update(Convenio convenio)
        {
            convenioDao.Update(convenio);
        }

        public Convenio ByID(Convenio convenio)
        {
            return convenioDao.ByID(convenio);
        }

        public Convenio ByID(int id)
        {
            Convenio convenio = new Convenio();
            convenio.ID = id;
            return convenioDao.ByID(convenio);
        }

        public DataTable ByName(Convenio convenio)
        {
            return convenioDao.ByName(convenio).Tables[0];
        }


        public DataTable GetAll()
        {
            IList<Convenio> convenios = convenioDao.GetAll();
            DataTable table = ConvenioTabela.GetAll(convenios);

            return table;
        }
    }
}
