using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Credor
    {
        public int ID { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Representante { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string TipoPessoa { get; set; }
        private Pessoa pessoa = new Pessoa();
        public int Delete { get; set; }

        public Credor()
        {

        }

        public Pessoa Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }
    }
}
