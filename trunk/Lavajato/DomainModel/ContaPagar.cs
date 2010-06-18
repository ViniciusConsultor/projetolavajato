using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class ContaPagar
    {
        public int ID { get; set; } 
        public string NF { get; set; }
        public string Serie{ get; set; }
        public string Documento{ get; set; }
        public DateTime DataDocomento{ get; set; }
        public Cliente Cliente{ get; set; }
        public DateTime DataVencimento{ get; set; }
        public string TipoDocumento{ get; set; }
        public string Obs{ get; set; }
        public DateTime DataPagamento{ get; set; }
        public DateTime AtrasoDias{ get; set; }
        public string ValorPago{ get; set; }
        public string SaldoAPagar { get; set; }

        public ContaPagar()
        {
            Cliente = new Cliente();
        }
    }
}
