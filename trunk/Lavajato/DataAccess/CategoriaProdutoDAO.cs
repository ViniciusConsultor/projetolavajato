using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class CategoriaProdutoDAO : DataAccessBase
    {
        public CategoriaProdutoDAO()
        {

        }

        public List<CategoriaProduto> GetAll()
        {
            string query = " SELECT [CategoriaProdutoID],[Descricao] FROM [Lavajado].[dbo].[CategoriaProduto]";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataTableReader reader = dataBaseHelper.Run(this.ConnectionString).CreateDataReader();
            List<CategoriaProduto> categoriaProdutos = new List<CategoriaProduto>();
            while (reader.Read())
            {
                CategoriaProduto categoriaProduto = new CategoriaProduto();
                categoriaProduto.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                categoriaProduto.Descricao = reader.IsDBNull(1) ? "" : reader.GetString(1);
                categoriaProdutos.Add(categoriaProduto);
            }
            return categoriaProdutos;
        }
    }
}
