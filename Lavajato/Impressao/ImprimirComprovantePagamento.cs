using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Drawing.Printing;
using System.Drawing;
using HenryCorporation.Lavajato.Operacional;

using System.Text;
using System.IO;

namespace Impressao
{
    public class ImprimirComprovantePagamento : Imprimir, IImprimir
    {
        private Servico _servico { get; set; }
        private PrintDocument recibo { get; set; }
        private const string enter = "\n";

        public ImprimirComprovantePagamento()
        {

        }

        public ImprimirComprovantePagamento(Servico servico)
        {
            _servico = servico;
        }

        #region IImprimir Members

        public void Imprimir(Servico servico)
        {
            _servico = servico;
            if (_servico.ID == 0)
                throw new Exception("Nenhum Servico encontrado");

           
            recibo = new PrintDocument();
            recibo.PrintPage += new PrintPageEventHandler(this.recibo_PrintPage);
            recibo.Print();
        }

        public void recibo_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string strRecibo = "";

            strRecibo += MontaCorpoRecibo(_servico);
            strRecibo += ExibeReciboFormatado(_servico);
            

            Pen myPen = new Pen(Brushes.Black); 
            Font myFont1 = new Font("Arial", 8);

            ev.Graphics.DrawString(strRecibo, myFont1, Brushes.Black, 25, 30);
            ev.HasMorePages = false;
        }

        #endregion
    }
}
