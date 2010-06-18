using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            usuario.Login = "teste";

            UsuarioDAO produtodao = new UsuarioDAO();
            usuario = produtodao.ByLogin(usuario);
            //usuario = new ProdutoDAO().ByLogin(

        }
    }
}
