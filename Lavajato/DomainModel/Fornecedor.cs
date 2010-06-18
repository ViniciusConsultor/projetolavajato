using System;
using System.Collections.Generic;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public  class Fornecedor
    {
        public int ID { get; set; }
        public string descricao { get; set; }
        public string CnpjCpf { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public DateTime _dataVenda { get; set; }
        public DateTime _dataEntrega { get; set; }
        

        public  Fornecedor()
        {

        }
    }
}
