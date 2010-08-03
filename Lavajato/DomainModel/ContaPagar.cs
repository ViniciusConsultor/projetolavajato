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
        public Credor Credor{get;set;}
        public DateTime DataVencimento{ get; set; }
        public string TipoDocumento{ get; set; }
        public string Obs{ get; set; }
        public DateTime DataPagamento{ get; set; }
        public DateTime AtrasoDias{ get; set; }
        public decimal ValorPago{ get; set; }
        public decimal SaldoAPagar { get; set; }

        public enum TipoPesquisa 
        { 
            VencendoHoje,
            DataVencimento,
            MostrarTodos,
            Pagos,
            Documento,
            RazaoSocial,
            DataDocumento,
        }

        public ContaPagar()
        {
            Credor = new Credor();
        }
    }
}
