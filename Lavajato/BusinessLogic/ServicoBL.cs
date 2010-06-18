using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ServicoBL
    {
        ServicoDAO servicoDAO = new ServicoDAO();

        public ServicoBL()
        {
        }

        public Servico ByCliente(Cliente cliente)
        {
            return servicoDAO.ByCliente(cliente);
        }

        public Servico Add(Servico servico)
        {
             return servicoDAO.Add(servico);
        }

        public Servico ByID(Servico servico)
        {
            return servicoDAO.ByID(servico);
        }

        public Servico ByOrdemServico(Servico servico)
        {
            return servicoDAO.ByOrdemServico(servico);
        }

        public void Update(Servico servico)
        {
            servicoDAO.Update(servico);
        }

        public void ServicoItemInsert(ServicoItem servicoItem)
        {
            servicoDAO.ItemDoServicoInsert(servicoItem);
        }

        public void ServicoItemUpdate(ServicoItem servicoItem)
        {
            servicoDAO.ServicoItemUpdate(servicoItem);
        }

        public void ServicoItemDelete(ServicoItem servicoItem)
        {
            servicoDAO.ItemDoServicoDelete(servicoItem);
        }

        public ServicoItem ByServicoItemID(ServicoItem servicoItem)
        {
            return servicoDAO.ByServicoItemID(servicoItem);
        }

        public static DataTable CriaGrid(Servico servico)
        {
            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            dataSet.Tables.Add(table);
            table.Columns.AddRange(CarregaColunas());
            foreach (ServicoItem si in servico.ServicoItem)
            {
                // Declare DataColumn and DataRow variables.
                DataRow row = table.NewRow();
                row["ID"] = si.ID;
                row["Descricao"] = si.Produto.Descricao;
                row["Quantidade"] = si.Quantidade;
                row["Valor"] = si.Produto.ValorUnitario.ToString("C");
                row["Total"] = (si.Produto.ValorUnitario * si.Quantidade).ToString("C");
                table.Rows.Add(row);
            }
            return table;
        }

        private static DataColumn[] CarregaColunas()
        {
            DataColumn[] columns = new DataColumn[5];

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Descricao";
            columns[1] = Descricao;

            DataColumn Quantidade = new DataColumn();
            Quantidade.ColumnName = "Quantidade";
            columns[2] = Quantidade;

            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Valor";
            columns[3] = Valor;

            DataColumn Total = new DataColumn();
            Total.ColumnName = "Total";
            columns[4] = Total;
            return columns;
        }

        public bool ExisteServico(Servico servico)
        {
            return servico.ID == 0 ? false : true;
        }
    }
}
