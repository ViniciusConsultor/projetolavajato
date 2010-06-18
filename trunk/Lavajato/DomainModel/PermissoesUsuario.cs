using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.DomainModel
{

    public class PermissoesUsuario
    {
        public int ID { get; set; }
        private Usuario usuario;
        private Permissao permissao;

        public PermissoesUsuario()
        {
            usuario = new Usuario();
            permissao = new Permissao();
        }
        
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Permissao Permissao
        {
            get { return permissao; }
            set { permissao = value; }
        }        

    }
}
