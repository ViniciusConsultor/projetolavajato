using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class RetiradaBL
    {
        private RetiradaDAO retiradaDAO = new RetiradaDAO();

        public RetiradaBL()
        {

        }

        public Retirada Add(Retirada retirada)
        {
            return retiradaDAO.Add(retirada);
        }

        public DataTable ByDate(DateTime date)
        {
            return FormataCampos(retiradaDAO.ByDate(date));
        }

        public DataTable GetAll()
        {
            return FormataCampos(retiradaDAO.GetAll());
        }

        public Retirada ByID(Retirada retirada)
        {
            return retiradaDAO.ByID(retirada);
        }

        public DataTable FormataCampos(IList<Retirada> retiradas)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColunas());
            foreach (var item in retiradas)
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

        public void Update(Retirada _retirada)
        {
            retiradaDAO.Update(_retirada);
        }
    }


}
