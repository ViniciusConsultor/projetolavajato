﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Telefone { get; set; }
        public string Veiculo { get; set; }

        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public string RG { get; set; }
        public bool Delete { get; set; }

        private Convenio convenio = new Convenio();

        public Convenio Convenio
        {
            get { return convenio; }
            set { convenio = value; }
        }
    }
}
