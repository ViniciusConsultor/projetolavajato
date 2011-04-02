using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ServicoItemDAO : DataAccessBase
    {
        private const string sql = " SELECT [ServicoItensID],[ServicoID],[ProdutoID],[Quantidade] " +
                              " FROM [ServicoItens]";


        public ServicoItemDAO()
        {

        }

        public ServicoItem Add(ServicoItem servicoItem)
        {
            string sql = "Insert into ServicoItens(ServicoID, ProdutoID, Quantidade) " +
            " values('" + servicoItem.Servico.ID + "','" + servicoItem.Produto.ID + "','" + servicoItem.Quantidade + "')";

            DataBaseHelper dataBaseHelper = new DataBaseHelper(sql);
            dataBaseHelper.Run();

            return ServicoItemInserido();
        }

        private ServicoItem ServicoItemInserido()
        {
            string query = " SELECT MAX(SERVICOITENSID) FROM SERVICOITENS ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.ID = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            return ByID(servicoItem);
        }

        public void Delete(ServicoItem servicoItem, Usuario usuario)
        {
            var query = " UPDATE [ServicoItens] " +
                        " SET [DelUser] = " + usuario.ID +
                        " ,[DelDate] = getdate()" +
                        " ,[Del] = 1 " +
                        " WHERE [ServicoItensID] = " + servicoItem.ID;

            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public void Update(ServicoItem servicoItem)
        {
            string query = " UPDATE [ServicoItens] " +
                           " SET [ServicoID] = " + servicoItem.Servico.ID + " " +
                           " ,[ProdutoID] = " + servicoItem.Produto.ID + " " +
                           " ,[Quantidade] = " + servicoItem.Quantidade + " " +
                           "  WHERE ServicoItensID = " + servicoItem.ID;

            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();
        }

        public ServicoItem ByID(ServicoItem servicoItem)
        {
            string query = sql + "Where ([Del] is null or [Del] = 0) and [ServicoItensID] =" + servicoItem.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpServicoItem(dataSet);
        }

        private List<ServicoItem> SetUpServicoItens(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<ServicoItem> servicos = new List<ServicoItem>();

            while (reader.Read())
            {
                ServicoItem serIte = new ServicoItem();
                serIte.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                serIte.Servico.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                serIte.Produto = ProdutoByID(reader.GetInt32(2));
                serIte.Quantidade = reader.IsDBNull(3) ? 0 : Convert.ToDecimal(reader.GetString(3));
                servicos.Add(serIte);
            }

            return servicos;
        }

        public List<ServicoItem> ItensByID(Servico servico)
        {
            string query = sql + " Where ([Del] is null or [Del] = 0) and [ServicoID] = " + servico.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            return SetUpServicoItens(dataSet);
        }

        private ServicoItem SetUpServicoItem(DataSet dataSet)
        {
            System.Data.DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            ServicoItem serIte = new ServicoItem();
            if (reader.Read())
            {
                serIte.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                serIte.Produto = ProdutoByID(reader.GetInt32(2));
                serIte.Servico.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                serIte.Quantidade = reader.IsDBNull(0) ? 0 : Convert.ToDecimal(reader.GetString(3));
                return serIte;
            }

            return serIte;
        }

        private Produto ProdutoByID(int p)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            Produto prod = new Produto();
            prod.ID = p;
            return produtoDAO.ByID(prod);
        }

    }
}
