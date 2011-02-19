using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class CredorTabela
    {
        public static DataTable ByRazaoSocial(IList<Credor> credores)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(CredorColuna.SetUpColunas());
            foreach (var item in credores)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.ID;
                row["Razao Social"] = item.RazaoSocial;
                row["CNPJ"] = item.Pessoa.Cnpj;
                row["Telefone"] = item.Pessoa.Telefone;

                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable GetAll(IList<Credor> credores)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(CredorColuna.SetUpColunas());
            foreach (var item in credores)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.ID;
                row["Razao Social"] = item.RazaoSocial;
                row["CNPJ"] = item.Pessoa.Cnpj;
                row["Telefone"] = item.Pessoa.Telefone;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable ByNomeFantasia(IList<Credor> credores)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(CredorColuna.SetUpColunas());
            foreach (var item in credores)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.ID;
                row["Razao Social"] = item.RazaoSocial;
                row["CNPJ"] = item.Pessoa.Cnpj;
                row["Telefone"] = item.Pessoa.Telefone;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
