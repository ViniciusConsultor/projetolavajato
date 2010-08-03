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
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColunas());
            
            foreach (ContaPagar cp in contaPagarDAO.PesquisaPorDataETipo(tipoPesquisa, documento, data))
            {
                DataRow row = SetUpRows(table, cp);
                table.Rows.Add(row);   
            }

            return table;
        }

        private static DataRow SetUpRows(DataTable table, ContaPagar cp )
        {
            DataRow row = table.NewRow();
            row["ID"] = cp.ID;
            row["Documento"] = cp.Documento;
            row["Emissao"] = cp.DataDocomento;
            row["Credor"] = cp.Credor.RazaoSocial;
            row["Vencimento"] = cp.DataVencimento;
            row["Valor"] = cp.ValorPago;
            return row;
        }

        private static DataColumn[] SetUpColunas()
        {
            DataColumn[] columns = new DataColumn[5];

            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Documento = new DataColumn();
            Documento.ColumnName = "Documento";
            columns[1] = Documento;

            DataColumn Emissao = new DataColumn();
            Emissao.ColumnName = "Emissao";
            columns[2] = Emissao;

            DataColumn Credor = new DataColumn();
            Credor.ColumnName = "Credor";
            columns[3] = Credor;

            DataColumn Vencimento = new DataColumn();
            Vencimento.ColumnName = "Vencimento";
            columns[4] = Vencimento;
            
            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Valor";
            columns[4] = Valor;

            return columns;
        }
    }
}
