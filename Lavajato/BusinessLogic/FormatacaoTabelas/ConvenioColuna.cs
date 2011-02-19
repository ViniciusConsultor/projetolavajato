using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ConvenioColuna
    {
        public static DataColumn[] GetAll()
        {
            DataColumn[] columns = new DataColumn[5];

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Nome";
            columns[1] = Descricao;

            DataColumn Telefone = new DataColumn();
            Telefone.ColumnName = "Telefone";
            columns[2] = Telefone;

            DataColumn Desconto = new DataColumn();
            Desconto.ColumnName = "Dinheiro";
            columns[3] = Desconto;

            DataColumn perce = new DataColumn();
            perce.ColumnName = "Porcentagem";
            columns[4] = perce;

            return columns;
        }
    }
}
