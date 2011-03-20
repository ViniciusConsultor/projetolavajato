using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Pagamento
    {
        public int ID{get;set;}
        public decimal Total { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Cartao { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Usuario UsuarioDesconto { get; set; }

        public Servico Servico { get; set; }
        

        public Pagamento()
        {
            Servico = new Servico();
            UsuarioDesconto = new Usuario();
            FormaPagamento = new FormaPagamento();
        }



       
    }
}
