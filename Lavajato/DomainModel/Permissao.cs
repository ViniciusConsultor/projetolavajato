using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Permissao
    {
        public Permissao()
        {

        }

        public int ID { get; set; }
        public int Produto { get; set; }
        public int Usuario { get; set; }
        public int OrdemServico { get; set; }
        public int Servico { get; set; }
        public int CategoriaProduto { get; set; }
        public int Relatorio { get; set; }
        public int Caixa { get; set; }
        
        
    }
}
