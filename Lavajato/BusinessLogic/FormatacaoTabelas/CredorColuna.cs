using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class CredorColuna
    {
        public static DataColumn[] SetUpColunas()
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
    }
}
