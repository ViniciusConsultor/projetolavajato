using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class UsuarioDAO : DataAccessBase
    {
        private TipoFuncionarioDAO tipoFunDAO;

        private const string sql = " SELECT [UsuarioID],[Login],[Password],[Endereco],[Numero],[Bairro],[Cep],[Cidade] "+
                            " ,[UF],[Email],[Celular],[Cpf],[RG],[Delete], [Nome],[Fone], [TipoFuncionarioID] " +
                            " FROM [Usuarios]";


        private const string sqlPermissao = " SELECT " +
                                           "  [Permissao].[PermissaoID]" +
                                           " ,[Permissao].[cliente]" +
                                           " ,[Permissao].[Usuario]" +
                                           " ,[Permissao].[Produto]" +
                                           " ,[Permissao].[Convenio]" +
                                           " ,[Permissao].[Credor]" +
                                           " ,[Permissao].[Servico]" +
                                           " ,[Permissao].[OrdemServico]" +
                                           " ,[Permissao].[OrdemAberto]" +
                                           " ,[Permissao].[IncluirLavadorNoServico]" +
                                           " ,[Permissao].[CancelaOrdemServico]" +
                                           " ,[Permissao].[relCaixa]" +
                                           " ,[Permissao].[relCaixaPorData]" +
                                           " ,[Permissao].[relEstoque]" +
                                           " ,[Permissao].[relCliente]" +
                                           " ,[Permissao].[relLavagemPorLavador]" +
                                           " ,[Permissao].[relCarrosNoLavajato]" +
                                           " ,[Permissao].[relServicoPorOs]" +
                                           " ,[Permissao].[relServicoCancelado]" +
                                           "   FROM [Permissao]" +
                                           "   INNER JOIN  PermissaoUsuario ON Permissao.PermissaoID = Permissaousuario.PermissaoID " +
                                           "   INNER JOIN  Usuarios ON PermissaoUsuario.UsuarioID = Usuarios.UsuarioID ";

        
        public UsuarioDAO()
        {
            tipoFunDAO = new TipoFuncionarioDAO();
        }

        public Usuario ByID(Usuario ususario)
        {
            string query = sql + "Where [Delete] = 0 And UsuarioID = " + ususario.ID;
               DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
              return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Usuario Add(Usuario ususario)
        {
            string query = " INSERT INTO [Usuarios] " +
                          " ([Login],[Password],[Endereco],[Numero],[Bairro],[Cep],[Cidade]" +
                          " ,[UF],[Email],[Fone],[Celular],[Cpf],[RG],[Delete], [Nome], [TipoFuncionarioID] ) VALUES" +
                          "('" + ususario.Login.Trim() + "','" + ususario.Password.Trim() + "','" + ususario.Endereco.Trim() + "','" + ususario.Numero.Trim() + "', " +
                          " '" + ususario.Bairro.Trim() + "','" + ususario.Cep.Trim() + "','" + ususario.Cidade.Trim() + "','" + ususario.UF.Trim() + "','" + ususario.Email.Trim() + "', " +
                          " '"+ususario.Telefone.Trim()+"', '" + ususario.Celular.Trim() + "','" + ususario.Cpf.Trim() + "','" + ususario.RG.Trim() + "','" + Convert.ToInt32(ususario.Delete) + "', " +
                          " '" + ususario.Nome.Trim() + "', '"+ususario.TipoFuncionario.ID+"' )";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

            InsertPermissao(ususario);
            InsertPermissaoUsuario();

            return UltimoUsuarioInserido();
        }

        private void InsertPermissao(Usuario usuario)
        {
            string query = " INSERT INTO [Lavajato].[dbo].[Permissao] " +
           " ([cliente]" +
           " ,[Usuario]" +
           " ,[Produto]" +
           " ,[Convenio]" +
           " ,[Credor]" +
           " ,[Servico]" +
           " ,[OrdemServico]" +
           " ,[OrdemAberto]" +
           " ,[IncluirLavadorNoServico]" +
           " ,[CancelaOrdemServico]" +
           " ,[relCaixa]" +
           " ,[relCaixaPorData]" +
           " ,[relEstoque]" +
           " ,[relCliente]" +
           " ,[relLavagemPorLavador]" +
           " ,[relCarrosNoLavajato]" +
           " ,[relServicoPorOs]" +
           " ,[relServicoCancelado])" +
     " VALUES " +
           "('" + usuario.Permissao.cliente + "' " +
           ",'" + usuario.Permissao.Usuario + "' " +
           ",'" + usuario.Permissao.Produto + "' " +
           ", '" + usuario.Permissao.Convenio + "' " +
           ", '" + usuario.Permissao.Credor + "' " +
           ",  '" + usuario.Permissao.Servico + "' " +
           ",'" + usuario.Permissao.OrdemServico + "' " +
           ",'" + usuario.Permissao.OrdemAberto + "' " +
           ",'" + usuario.Permissao.IncluirLavadorNoServico + "' " +
           ",'" + usuario.Permissao.CancelaOrdemServico + "' " +
           ",'" + usuario.Permissao.relCaixa + "' " +
           ",'" + usuario.Permissao.relCaixaPorData + "' " +
           ",'" + usuario.Permissao.relEstoque + "' " +
           ",'" + usuario.Permissao.relCliente + "' " +
           ",'" + usuario.Permissao.relLavagemPorLavador + "' " +
           ",'" + usuario.Permissao.relCarrosNoLavajato + "' " +
           ",'" + usuario.Permissao.relServicoPorOs + "' " +
           ", '" + usuario.Permissao.relServicoCancelado + "')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        private void InsertPermissaoUsuario()
        {
            Usuario usuario = UltimoUsuarioInserido();

            Permissao permissao = UltimaPermissaoInserida();

            string query2 = "INSERT INTO PermissaoUsuario (UsuarioID, PermissaoID) " +
            " VALUES('" + usuario.ID + "','" + permissao.ID + "')";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query2);
            dataBaseHelper.Run();
        }

        private Permissao UltimaPermissaoInserida()
        {
            string query1 = "select max(permissaoid) from permissao";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query1);
            Permissao permissao = new Permissao();
            permissao.ID = int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
            return permissao;
        }

        private Usuario UltimoUsuarioInserido()
        {
            string query = "select max(usuarioid) from usuarios";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            Usuario usuario = new Usuario();
            usuario.ID = int.Parse(dataBaseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
            return this.ByID(usuario);
        }

        public void Update(Usuario ususario)
        {
           string query = " UPDATE [Usuarios] " +
            " SET [Login] = '"+ususario.Login.Trim()+"' " +
            " ,[Password] = '" + ususario.Password.Trim() + "' " +
            " ,[Endereco] = '" + ususario.Endereco.Trim() + "' " +
            " ,[Numero] = '" + ususario.Numero.Trim() + "' " +
            " ,[Bairro] = '" + ususario.Bairro.Trim() + "' " +
            " ,[Cep] = '" + ususario.Cep.Trim() + "' " +
            " ,[Cidade] = '" + ususario.Cidade.Trim() + "'" +
            " ,[UF] = '" + ususario.UF.Trim() + "' " +
            " ,[Email] = '" + ususario.Email.Trim() + "' " +
            " ,[Fone] = '" + ususario.Telefone.Trim() + "'  " +
            " ,[Celular] = '" + ususario.Celular.Trim() + "'  " +
            " ,[Cpf] = '" + ususario.Cpf.Trim() + "' " +
            " ,[RG] = '" + ususario.RG.Trim() + "' " +
            " ,[Delete] = '"+Convert.ToInt32( ususario.Delete)+"' " +
            " ,[Nome] = '" + ususario.Nome.Trim() + "' " +
            " ,[TipoFuncionarioID] = '" + ususario.TipoFuncionario.ID.ToString().Trim() + "' " +
            " WHERE UsuarioID = " + ususario.ID;
           DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
           dataBaseHelper.Run();

           UpdatePermissoes(ususario.Permissao);
        }

        private void UpdatePermissoes(Permissao permissao)
        {
            string query2 = " UPDATE [Lavajato].[dbo].[Permissao] " +
                               " SET [cliente] = '" + permissao.cliente + "' " +
                                  " ,[Usuario] = '" + permissao.Usuario + "' " +
                                  " ,[Produto] = '" + permissao.Produto + "' " +
                                  " ,[Convenio] = '" + permissao.Convenio + "' " +
                                  " ,[Credor] = '" + permissao.Credor + "' " +
                                  " ,[Servico] = '" + permissao.Servico + "' " +
                                  " ,[OrdemServico] = '" + permissao.OrdemServico + "' " +
                                  " ,[OrdemAberto] = '" + permissao.OrdemAberto + "' " +
                                  " ,[IncluirLavadorNoServico] = '" + permissao.IncluirLavadorNoServico + "' " +
                                  " ,[CancelaOrdemServico] = '" + permissao.CancelaOrdemServico + "' " +
                                  " ,[relCaixa] = '" + permissao.relCaixa + "' " +
                                  " ,[relCaixaPorData] = '" + permissao.relCaixaPorData + "' " +
                                  " ,[relEstoque] = '" + permissao.relEstoque + "' " +
                                  " ,[relCliente] = '" + permissao.relCliente + "' " +
                                  " ,[relLavagemPorLavador] = '" + permissao.relLavagemPorLavador + "' " +
                                  " ,[relCarrosNoLavajato] = '" + permissao.relCarrosNoLavajato + "' " +
                                  " ,[relServicoPorOs] = '" + permissao.relServicoPorOs + "' " +
                                  " ,[relServicoCancelado] = '" + permissao.relServicoCancelado + "' " +
                             " WHERE [PermissaoID] = " + permissao.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query2);
            dataBaseHelper.Run();
        }

        public void Delete(Usuario ususario)
        {
            string query = " UPDATE [Usuarios] " +
            " SET [Delete] = 1 " +
            " WHERE UsuarioID = " + ususario.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public List<Usuario> ByName(Usuario usuario)
        {
            string query = sql + "Where [Delete] = 0 And [Nome] like('%"+usuario.Nome.Trim()+"%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public List<Usuario> ByLogin(string login)
        {
            string query = sql + "Where [Delete] = 0 And [Login] like('%" + login.Trim() + "%') ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields(dataBaseHelper.Run(this.ConnectionString));
        }

        public Usuario ByLogin(Usuario usuario)
        {
            string query = sql + "Where [Delete] = 0 And [Login] = '" + usuario.Login + "' ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }

        public Usuario ByLoginAndPassword(Usuario usuario)
        {
            string query = sql + "Where [Delete] = 0 And [Login] = '" + usuario.Login + "' and [Password] = '" + usuario.Password + "' ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpField(dataBaseHelper.Run(this.ConnectionString));
        }


        private Usuario SetUpField(DataSet dataSet)
        {
            Usuario usuario = new Usuario();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            if (reader.Read())
            {
                usuario.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                usuario.Login = reader.IsDBNull(1) ? "" : reader.GetString(1);
                usuario.Password = reader.IsDBNull(2) ? "" : reader.GetString(2);
                usuario.Endereco = reader.IsDBNull(3) ? "" : reader.GetString(3);
                usuario.Numero = reader.IsDBNull(4) ? "" : reader.GetString(4);
                usuario.Bairro = reader.IsDBNull(5) ? "" : reader.GetString(5);
                usuario.Cep = reader.IsDBNull(6) ? "" : reader.GetString(6);
                usuario.Cidade = reader.IsDBNull(7) ? "" : reader.GetString(7);
                usuario.UF = reader.IsDBNull(8) ? "" : reader.GetString(8);
                usuario.Email = reader.IsDBNull(9) ? "" : reader.GetString(9);
                usuario.Celular = reader.IsDBNull(10) ? "" : reader.GetString(10);
                usuario.Cpf = reader.IsDBNull(11) ? "" : reader.GetString(11);
                usuario.RG = reader.IsDBNull(12) ? "" : reader.GetString(12);
                usuario.Delete = reader.IsDBNull(13) ? false : Convert.ToBoolean( reader.GetByte(13));
                usuario.Nome= reader.IsDBNull(14) ? "" : reader.GetString(14);
                usuario.Telefone = reader.IsDBNull(15) ? "" : reader.GetString(15);
                usuario.TipoFuncionario = SetUpTipoFuncionario(reader.GetInt32(16));
                usuario.Permissao = SetFieldPermissao(usuario);
                return usuario;
            }
            return usuario;
        }

        public List<Usuario> GetUsuarioTipoLavador()
        {
            string query = " SELECT USUARIOS.[UsuarioID],USUARIOS.[Login],USUARIOS.[Password],USUARIOS.[Endereco],USUARIOS.[Numero], " +
                           " USUARIOS.[Bairro],USUARIOS.[Cep],USUARIOS.[Cidade] " +
                           " ,USUARIOS.[UF],USUARIOS.[Email],USUARIOS.[Celular],USUARIOS.[Cpf],USUARIOS.[RG],USUARIOS.[Delete], USUARIOS.[Nome], " +
                           " USUARIOS.[Fone], USUARIOS.[TipoFuncionarioID] " +
                           " FROM [Usuarios] " +
                           " INNER JOIN TIPOFUNCIONARIO TP ON USUARIOS.TipoFuncionarioID = TP.TipoFuncionarioID "+
                           " WHERE USUARIOS.TipoFuncionarioID = 3 ";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            return SetUpFields( dataBaseHelper.Run(this.ConnectionString));

        }

        private TipoFuncionario SetUpTipoFuncionario(int p)
        {
            TipoFuncionario tipoFuncionario = new TipoFuncionario();
            tipoFuncionario.ID = p;
            return tipoFunDAO.ByID(tipoFuncionario);
        }

        private List<Usuario> SetUpFields(DataSet dataSet)
        {
            List<Usuario> usuarios = new List<Usuario>();
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                usuario.Login = reader.IsDBNull(1) ? "" : reader.GetString(1);
                usuario.Password = reader.IsDBNull(2) ? "" : reader.GetString(2);
                usuario.Endereco = reader.IsDBNull(3) ? "" : reader.GetString(3);
                usuario.Numero = reader.IsDBNull(4) ? "" : reader.GetString(4);
                usuario.Bairro = reader.IsDBNull(5) ? "" : reader.GetString(5);
                usuario.Cep = reader.IsDBNull(6) ? "" : reader.GetString(6);
                usuario.Cidade = reader.IsDBNull(7) ? "" : reader.GetString(7);
                usuario.UF = reader.IsDBNull(8) ? "" : reader.GetString(8);
                usuario.Email = reader.IsDBNull(9) ? "" : reader.GetString(9);
                usuario.Celular = reader.IsDBNull(10) ? "" : reader.GetString(10);
                usuario.Cpf = reader.IsDBNull(11) ? "" : reader.GetString(11);
                usuario.RG = reader.IsDBNull(12) ? "" : reader.GetString(12);
                usuario.Delete = reader.IsDBNull(13) ? false : Convert.ToBoolean(reader.GetByte(13));
                usuario.Nome = reader.IsDBNull(14) ? "" : reader.GetString(14);
                usuario.Telefone= reader.IsDBNull(15) ? "" : reader.GetString(15);
                usuario.TipoFuncionario = SetUpTipoFuncionario(reader.GetInt32(16));
                usuario.Permissao = SetFieldPermissao(usuario);
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public DataSet GetAll()
        {
            string query = "SELECT Usuarios.UsuarioID, Usuarios.Nome, Usuarios.Login, " +
                           " [Permissao].[cliente]" +
                           " ,[Permissao].[Usuario]" +
                           " ,[Permissao].[Produto]" +
                           " ,[Permissao].[Convenio]" +
                           " ,[Permissao].[Credor]" +
                           " ,[Permissao].[Servico]" +
                           " ,[Permissao].[OrdemServico]" +
                           " ,[Permissao].[OrdemAberto]" +
                           " ,[Permissao].[IncluirLavadorNoServico]" +
                           " ,[Permissao].[CancelaOrdemServico]" +
                           " ,[Permissao].[relCaixa]" +
                           " ,[Permissao].[relCaixaPorData]" +
                           " ,[Permissao].[relEstoque]" +
                           " ,[Permissao].[relCliente]" +
                           " ,[Permissao].[relLavagemPorLavador]" +
                           " ,[Permissao].[relCarrosNoLavajato]" +
                           " ,[Permissao].[relServicoPorOs]" +
                           " ,[Permissao].[relServicoCancelado]" +
                           "  FROM Usuarios INNER JOIN " +
                           "  PermissaoUsuario ON Usuarios.UsuarioID = PermissaoUsuario.UsuarioID INNER JOIN " +
                           " Permissao ON Permissaousuario.PermissaoID = Permissao.PermissaoID Where Usuarios.[Delete] = 0";


            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
           return dataBaseHelper.Run(this.ConnectionString);
        }

        private Permissao SetFieldPermissao(Usuario usuario)
        {
            string query = sqlPermissao + "WHERE (PermissaoUsuario.UsuarioID = " + usuario.ID + ")" ;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Permissao permissao = new Permissao();
            if (reader.Read())
            {

                permissao.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                permissao.cliente = permissao.cliente = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                permissao.Usuario = permissao.Usuario = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                permissao.Produto = permissao.Produto = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                permissao.Convenio = permissao.Convenio = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                permissao.Credor = permissao.Credor = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                permissao.Servico = permissao.Servico = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                permissao.OrdemServico = permissao.OrdemServico = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                permissao.OrdemAberto = permissao.OrdemAberto = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                permissao.IncluirLavadorNoServico = permissao.IncluirLavadorNoServico = reader.IsDBNull(9) ? 0 : reader.GetInt32(9);
                permissao.CancelaOrdemServico = permissao.CancelaOrdemServico = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);
                permissao.relCaixa = permissao.relCaixa = reader.IsDBNull(11) ? 0 : Convert.ToInt32(reader.GetString(11));
                permissao.relCaixaPorData = permissao.relCaixaPorData = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetString(12));
                permissao.relEstoque = permissao.relEstoque = reader.IsDBNull(13) ? 0 : Convert.ToInt32(reader.GetString(13));
                permissao.relCliente = permissao.relCliente = reader.IsDBNull(14) ? 0 : Convert.ToInt32(reader.GetString(14));
                permissao.relLavagemPorLavador = permissao.relLavagemPorLavador = reader.IsDBNull(15) ? 0 :Convert.ToInt32( reader.GetString(15));
                permissao.relCarrosNoLavajato = permissao.relCarrosNoLavajato = reader.IsDBNull(16) ? 0 :Convert.ToInt32( reader.GetString(16));
                permissao.relServicoPorOs = permissao.relServicoPorOs = reader.IsDBNull(17) ? 0 :Convert.ToInt32( reader.GetString(17));
                permissao.relServicoCancelado = permissao.relServicoCancelado = reader.IsDBNull(18) ? 0 : Convert.ToInt32(reader.GetString(18));
                return permissao;
            }
            return permissao;
        }

    }
}
