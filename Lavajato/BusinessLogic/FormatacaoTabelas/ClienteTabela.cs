using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ClienteTabela
    {
        public static DataTable CriaTabelaOrdemServico(IList<Servico> servicos)
        {
            
            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();

            dataSet.Tables.Add(table);
            table.Columns.AddRange(ClienteColuna.CriaTabelaOrdemServico());

            foreach (var serv in servicos)
            {
                DataRow row = table.NewRow();
                row["ID"] = serv.ID;
                row["Cliente"] = serv.Cliente.Nome;
                row["Placa"] = serv.Cliente.Placa;
                row["Data"] = serv.Entrada;
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
