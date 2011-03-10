using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{
    public class Vale
    {
        public Usuario Usuario { get; set; }
        public int isVale { get; set; }

        public Vale()
        {
            Usuario = new Usuario();
        }
    }
}
