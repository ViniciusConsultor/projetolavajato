using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Expositor
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public int Minimo { get; set; }
        public int Quantidade { get; set; }

        public Expositor()
        {
        }

        public Expositor(int id, DateTime data, int minimo, int quantidade)
        {
            this.ID = id;
            this.Data = data;
            this.Minimo = minimo;
            this.Quantidade = quantidade;
        }

        public override string ToString()
        {
            return this.Quantidade.ToString();
        }

        
    }
}
