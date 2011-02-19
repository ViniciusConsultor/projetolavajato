using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ContaPagarTabela
    {
        public static DataTable PesquisaPorDataETipo(IList<ContaPagar> contasPaga)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(ContaPagaColuna.ColunaContaPagar());

            foreach (ContaPagar cp in contasPaga)
            {
                DataRow row = table.NewRow();
                row["ID"] = cp.ID;
                row["Documento"] = cp.Documento;
                row["Emissao"] = cp.DataDocomento.ToShortDateString();
                row["Credor"] = cp.Credor.RazaoSocial;
                row["Vencimento"] = cp.DataVencimento.ToShortDateString();
                row["Valor"] = cp.ValorPago;

                table.Rows.Add(row);
            }

            return table;
        }
    }
}
