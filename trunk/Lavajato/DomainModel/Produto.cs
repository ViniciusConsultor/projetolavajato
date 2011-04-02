using System;
using System.Collections.Generic;
using System.Text;


namespace HenryCorporation.Lavajato.DomainModel
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal ValorUnitario { get; set; }
        private CategoriaProduto _categoriaProduto;
        public  Estoque Estoque {get;set;}
        public Expositor Expositor {get;set;}

        public Produto()
        {
            Expositor = new Expositor();
            Estoque = new Estoque();

        }
        
        public virtual CategoriaProduto CategoriaProduto
        {
            get
            {
                if (_categoriaProduto == null)
                    return _categoriaProduto = new CategoriaProduto();
                return _categoriaProduto;
            }
            set { _categoriaProduto = value; }
        }
    }
}
