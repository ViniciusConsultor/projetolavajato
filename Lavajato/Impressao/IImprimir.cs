using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Drawing.Printing;

namespace Impressao
{
    public interface IImprimir
    {
        void Imprimir(Servico servico);
        void recibo_PrintPage(object sender, PrintPageEventArgs ev);
    }
}
