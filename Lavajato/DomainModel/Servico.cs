using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{

    public class Servico
    {

        public int ID { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Desconto { get; set; }
        public decimal Total { get; set; }
        public string Cor { get; set; }
        public int OrdemServico { get; set; }
        private List<ServicoItem> _servicoItem;
        private FormaPagamento _formaPagamentoID;
        private Cliente cliente = new Cliente();
        private Usuario usuario = new Usuario();
        public int Delete { get; set; }
        public int Cancelado { get; set; }
        public int Lavado { get; set; }
        public int Finalizado { get; set; }

        public Servico()
        {

        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public virtual List<ServicoItem> ServicoItem
        {
            get
            {
                if (_servicoItem == null)
                    return _servicoItem = new List<ServicoItem>();
                return _servicoItem;
            }
            set { _servicoItem = value; }

        }

        public virtual FormaPagamento FormaPagamento
        {
            get
            {
                if (_formaPagamentoID == null)
                    return _formaPagamentoID = new FormaPagamento();
                return _formaPagamentoID;
            }
            set { _formaPagamentoID = value; }
        }
    }
}
