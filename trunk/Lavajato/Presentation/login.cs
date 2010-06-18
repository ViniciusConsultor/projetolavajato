using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public class login : Form
    {
        private static Usuario usuario;
        private UsuarioBL usuarioBL = new UsuarioBL();
               
        private bool isAutenticado = false;

       

        public Usuario Usuario
        {
            get
            {
                return GetByName(usuario);
            }
            set { usuario = value; }
        }
      
        public bool IsAutenticado
        {
            get
            {
                if (this.Usuario.ID > 0)
                    return true;
                return false;
            }
        }

        private Usuario GetByName(Usuario usuario)
        {
            return usuarioBL.ByLogin(usuario);
        }

       

    }
}
