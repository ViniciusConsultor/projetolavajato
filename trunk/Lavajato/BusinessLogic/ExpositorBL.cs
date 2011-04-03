using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ExpositorBL
    {
        private ExpositorDAO expositorDAO = new ExpositorDAO();

        public ExpositorBL(){ }

        public void Update(Expositor expositor)
        {
            expositorDAO.Update(expositor);
        }

    }
}
