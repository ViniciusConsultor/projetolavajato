using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace HenryCorporation.Lavajato.DomainModel
{
   
    public class ServicoItem
    {
        public int ID { get; set; }
        private Servico _servico;
        private Produto _produto;
        public int Quantidade { get; set; }

        public ServicoItem()
        { 
            
        }

        public virtual Servico Servico
        {
            get {
                if (_servico == null)
                    return _servico = new Servico();
                return _servico; }
            set { _servico = value; }
        }

        public virtual Produto Produto
        {
            get {
                if (_produto == null)
                    return _produto = new Produto();
                return _produto; }
            set { _produto = value; }
        }
    }
}
