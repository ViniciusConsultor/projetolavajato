using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ConvenioTabela
    {
        public static DataTable GetAll(IList<Convenio> convenios )
        {

            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            dataSet.Tables.Add(table);
            table.Columns.AddRange(ConvenioColuna.GetAll());

            foreach (Convenio con in convenios)
            {
                DataRow row = table.NewRow();
                row["ID"] = con.ID;
                row["Nome"] = con.Nome;
                row["Telefone"] = con.Telefone;
                row["Dinheiro"] = con.Valor.ToString("C");
                row["Porcentagem"] = con.PorcentagemDesconto;
                table.Rows.Add(row);
            }
            return table;
        }

    }
}
