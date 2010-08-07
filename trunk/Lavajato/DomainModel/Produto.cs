using System;
using System.Collections.Generic;
using System.Text;


namespace HenryCorporation.Lavajato.DomainModel
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int Minimo { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal ValorUnitario { get; set; }
        private CategoriaProduto _categoriaProduto;
        private Estoque estoque = new Estoque();

        public Produto()
        {
            
        }
        
        public Estoque Estoque
        {
            get { return estoque; }
            set { estoque = value; }
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
