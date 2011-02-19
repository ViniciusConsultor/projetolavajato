using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ClienteColuna
    {
        public static DataColumn[] CriaTabelaOrdemServico()
        {
            DataColumn[] columns = new DataColumn[4];

            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Cliente = new DataColumn();
            Cliente.ColumnName = "Cliente";
            columns[1] = Cliente;

            DataColumn Placa = new DataColumn();
            Placa.ColumnName = "Placa";
            columns[2] = Placa;

            DataColumn Data = new DataColumn();
            Data.ColumnName = "Data";
            columns[3] = Data;

            return columns;
        }
    }
}
