using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class SuprimentoBL
    {
        private SuprimentoDAO suprimentoDAO = new SuprimentoDAO();

        public SuprimentoBL()
        {

        }

        public Suprimento Add(Suprimento suprimento)
        {
            return suprimentoDAO.Insert(suprimento);
        }

        public Suprimento ByID(Suprimento suprimento)
        {
            return suprimentoDAO.ByID(suprimento);
        }

        public DataTable ByDate(DateTime date)
        {
            return FormataCampos(suprimentoDAO.ByDate(date));
        }

        public DataTable FormataCampos(IList<Suprimento> suprimentos)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColunas());
            foreach (var item in suprimentos)
            {
                DataRow row = table.NewRow();
                row["ID"] = item.ID;
                row["Valor"] = item.Valor.ToString("C");
                row["Data"] = item.Data.ToShortDateString();
                row["Descricao"] = item.Descricao;
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataColumn[] SetUpColunas()
        {
            DataColumn[] columns = new DataColumn[5];

            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Valor";
            columns[1] = Valor;

            DataColumn Data = new DataColumn();
            Data.ColumnName = "Data";
            columns[2] = Data;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Descricao";
            columns[3] = Descricao;

            return columns;
        }




        public void Update(Suprimento _suprimento)
        {
            suprimentoDAO.Update(_suprimento);
        }
    }
}
