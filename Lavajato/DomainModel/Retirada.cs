using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Retirada
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        private Usuario usuario;

        public Retirada()
        {
            usuario = new Usuario();
            Vale = new Vale();
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public TipoRetirada TipoRetirada { get; set; }
        public Vale Vale { get; set; }
    }
}
