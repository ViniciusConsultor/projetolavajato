using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace LavajatoMobile
{
    public static class ServicoColunas
    {
        public static DataColumn[] CarregaColunasServico()
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
    }
}
