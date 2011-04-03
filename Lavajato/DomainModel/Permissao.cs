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
        public int cliente { get; set; }
        public int Usuario { get; set; }
        public int Produto { get; set; }
        public int Convenio { get; set; }
        public int Credor { get; set; }
        public int Servico { get; set; }
        public int OrdemServico { get; set; }
        public int OrdemAberto { get; set; }
        public int IncluirLavadorNoServico { get; set; }
        public int CancelaOrdemServico { get; set; }
        public int relCaixa { get; set; }
        public int relCaixaPorData { get; set; }
        public int relEstoque { get; set; }
        public int relCliente { get; set; }
        public int relLavagemPorLavador { get; set; }
        public int relCarrosNoLavajato { get; set; }
        public int relServicoPorOs { get; set; }
        public int relServicoCancelado { get; set; }

    }
}
