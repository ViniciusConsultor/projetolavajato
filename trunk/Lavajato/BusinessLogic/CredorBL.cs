using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class CredorBL
    {
        private CredorDAO credorDao = new CredorDAO();
        private PessoaDAO pessoaDao = new PessoaDAO();

        public CredorBL()
        {

        }

        public Credor Add(Credor credor)
        {
            credor.Pessoa = pessoaDao.Add(credor.Pessoa);
            return credorDao.Add(credor);
        }

        public void Update(Credor credor)
        {
            pessoaDao.Update(credor.Pessoa);
            credorDao.Update(credor);
        }

        public Credor ByID(Credor credor)
        {
            return credorDao.ByID(credor);
        }

        public Credor ByID(int credorID)
        {   
            return credorDao.ByID(credorID);
        }

        public DataTable GetAll()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColunas());
            foreach (var item in credorDao.GetAll())
            {
                DataRow row = SetUpRows(table, item);
                table.Rows.Add(row);
            }
            return table;
        }

        public DataTable ByRazaoSocial(Credor credor)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColunas());
            foreach (var item in credorDao.ByRazaoSocial(credor))
            {
                DataRow row = SetUpRows(table, item);
                table.Rows.Add(row);
            }
            return table;
        }

        public DataTable ByNomeFantasia(Credor credor)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColunas());
            foreach (var item in credorDao.ByNomeFantasia(credor))
            {
                DataRow row = SetUpRows(table, item);
                table.Rows.Add(row);
            }
            return table;
        }

        private static DataRow SetUpRows(DataTable table, Credor item)
        {
            DataRow row = table.NewRow();
            row["ID"] = item.ID;
            row["Razao Social"] = item.RazaoSocial;
            row["CNPJ"] = item.Pessoa.Cnpj;
            row["Telefone"] = item.Pessoa.Telefone;
            return row;
        }

        private static DataColumn[] SetUpColunas()
        {
            DataColumn[] columns = new DataColumn[5];

            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn RazaoSocial = new DataColumn();
            RazaoSocial.ColumnName = "Razao Social";
            columns[1] = RazaoSocial;

            DataColumn CNPJ = new DataColumn();
            CNPJ.ColumnName = "CNPJ";
            columns[2] = CNPJ;

            DataColumn Telefone = new DataColumn();
            Telefone.ColumnName = "Telefone";
            columns[3] = Telefone;
            return columns;
        }

        public void Delete(Credor credor)
        {
            credorDao.Delete(credor);
        }
    }
}
