using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Drawing.Printing;
using System.Drawing;
using HenryCorporation.Lavajato.Operacional;

namespace Impressao
{
    public class ImprimirComprovantePagamento : Imprimir, IImprimir
    {
        private Servico servico { get; set; }
        private PrintDocument recibo { get; set; }
        private const string enter = "\n";

        public ImprimirComprovantePagamento()
        {

        }

        public ImprimirComprovantePagamento(Servico servico)
        {
            this.servico = servico;
        }

        #region IImprimir Members

        public void Imprimir(Servico servico)
        {
            this.servico = servico;
            if (this.servico.ID == 0)
                throw new Exception("Nenhum Servico encontrado");

            this.recibo = new PrintDocument();
            this.recibo.PrintPage += new PrintPageEventHandler(this.recibo_PrintPage);
            this.recibo.Print();
        }

        public void recibo_PrintPage(object sender, PrintPageEventArgs ev)
        {
            StringBuilder recibo = new StringBuilder();

            recibo.Append(MontaCorpoRecibo(this.servico));
            recibo.Append(ExibeReciboFormatado(servico));

            Pen myPen = new Pen(Brushes.Black);
            Point pt1 = new Point(30, 53);
            Font myFont1 = new Font("Arial", 8);

            ev.Graphics.DrawString(recibo.ToString(), myFont1, Brushes.Black, 30, 30);
            ev.HasMorePages = false;
        }

        #endregion
    }
}
