using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ContaPagarBL
    {
        private ContaAPagarDAO contaPagarDAO = new ContaAPagarDAO();

        public ContaPagarBL()
        {

        }

        public ContaPagar Add(ContaPagar contaPagar)
        {
            return contaPagarDAO.Insert(contaPagar);
        }

        public void Delete(ContaPagar contaPagar)
        {
           // contaPagarDAO.Delete(contaPagarDAO);
        }

        public ContaPagar Update(ContaPagar contaPagar)
        {
            return contaPagarDAO.Insert(contaPagar);
        }

        public DataTable PesquisaPorDataETipo(string tipoPesquisa, string documento, DateTime data)
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

            DataTable table = new DataTable();
            table.Columns.AddRange(columns);
            
            foreach (ContaPagar cp in contaPagarDAO.PesquisaPorDataETipo(tipoPesquisa, documento, data))
            {
                DataRow row = SetUpRows(table, cp);
                table.Rows.Add(row);   
            }

            return table;
        }

        private DataRow SetUpRows(DataTable table, ContaPagar cp )
        {
            DataRow row = table.NewRow();
            row["ID"] = cp.ID;
            row["Documento"] = cp.Documento;
            row["Emissao"] = cp.DataDocomento.ToShortDateString();
            row["Credor"] = cp.Credor.RazaoSocial;
            row["Vencimento"] = cp.DataVencimento.ToShortDateString();
            row["Valor"] = cp.ValorPago;
            return row;
        }

        
    }
}
