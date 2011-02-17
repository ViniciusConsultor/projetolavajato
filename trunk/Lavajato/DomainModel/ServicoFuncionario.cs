using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class ServicoFuncionario
    {
        public int ID { get; set; }
        public Servico Servico { get; set; }
        public Produto Produto { get; set; }

        public ServicoFuncionario()
        {
            Servico = new Servico();
            Produto = new Produto();
        }


    }
}
