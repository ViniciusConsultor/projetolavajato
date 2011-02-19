using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ContaPagaColuna
    {
        public static DataColumn[] ColunaContaPagar()
        {
            DataColumn[] columns = new DataColumn[6];

            DataColumn id = new DataColumn();
            id.ColumnName = "ID";
            columns[0] = id;

            DataColumn doc = new DataColumn();
            doc.ColumnName = "Documento";
            columns[1] = doc;

            DataColumn emi = new DataColumn();
            emi.ColumnName = "Emissao";
            columns[2] = emi;

            DataColumn cr = new DataColumn();
            cr.ColumnName = "Credor";
            columns[3] = cr;

            DataColumn venc = new DataColumn();
            venc.ColumnName = "Vencimento";
            columns[4] = venc;


            DataColumn val = new DataColumn();
            val.ColumnName = "Valor";
            columns[5] = val;

            return columns;

        }
    }
}
