using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string Cnpj { get; set; }
        public string InsEstadual { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
     
        public Pessoa()
        {
        }
    }
}
