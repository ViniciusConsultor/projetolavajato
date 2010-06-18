using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class UsuarioBL
    {
        private UsuarioDAO usuarioDao = new UsuarioDAO();
        
        public UsuarioBL()
        {

        }

        public void Add(Usuario usuario)
        { 
        }

        public Usuario ByID(Usuario usuario)
        {
            return usuarioDao.ByID(usuario);
        }

        public void Delete(Usuario usuario)
        {
            usuarioDao.Delete(usuario);
        }

        public Usuario Insert(Usuario usuario)
        {
            return usuarioDao.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            usuarioDao.Update(usuario);
        }

        public Usuario ByLogin(Usuario usuario)
        {
            return usuarioDao.ByLogin(usuario);
        }

        public List<Usuario> ByLogin(string login)
        {
            return usuarioDao.ByLogin(login);
        }

        public List<Usuario> ByName(Usuario usuario)
        {
            return usuarioDao.ByName(usuario);
        }

        public DataSet GetAll()
        {
            return usuarioDao.GetAll();
        }

        public List<Usuario> GetUsuarioTipoLavador()
        {
            return usuarioDao.GetUsuarioTipoLavador();
        }


       
    }
}
