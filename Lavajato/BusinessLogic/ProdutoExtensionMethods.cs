using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ProdutoExtensionMethods
    {
        //colocar isso aqui num extension metodos
        public static DataTable GetProdutos(this List<Produto> produtos)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(GetColumns());

            foreach (Produto prod in produtos)
            {
                DataRow row = table.NewRow();
                row["ID"] = prod.ID;
                row["Descricao"] = prod.Descricao;
                row["Estoque"] = prod.Estoque.Quantidade;
                row["Preço"] = prod.ValorUnitario.ToString("C");
                table.Rows.Add(row);
            }
            return table;
        }

        //colocar isso aqui num extension metodos
        private static DataColumn[] GetColumns()
        {
            DataColumn[] columns = new DataColumn[4];

            DataColumn id = new DataColumn();
            id.ColumnName = "ID";
            columns[0] = id;

            DataColumn desc = new DataColumn();
            desc.ColumnName = "Descricao";
            columns[1] = desc;

            DataColumn estq = new DataColumn();
            estq.ColumnName = "Estoque";
            columns[2] = estq;

            DataColumn valorVenda = new DataColumn();
            valorVenda.ColumnName = "Preço";
            columns[3] = valorVenda;

            return columns;
        }


    }
}
