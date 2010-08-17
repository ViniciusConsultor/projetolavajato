using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;
using System.Data;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public class ConvenioBL
    {
        private ConvenioDAO convenioDao = new ConvenioDAO();
        private ClienteBL clienteBL = new ClienteBL();

        public ConvenioBL()
        {

        }

        public Convenio Add(Convenio convenio)
        {
            return convenioDao.Add(convenio);
        }

        private Cliente ClienteSalva(Cliente cliente)
        {
            return clienteBL.Insert(cliente);
        }

        public void Delete(Convenio convenio)
        {
            convenioDao.Delete(convenio);
        }

        public void Update(Convenio convenio)
        {
            convenioDao.Update(convenio);
        }

        public Convenio ByID(Convenio convenio)
        {
            return convenioDao.ByID(convenio);
        }

        public Convenio ByID(int id)
        {
            Convenio convenio = new Convenio();
            convenio.ID = id;
            return convenioDao.ByID(convenio);
        }

        public DataTable ByName(Convenio convenio)
        {
            return convenioDao.ByName(convenio).Tables[0];
        }


        public DataTable GetAll()
        {
            DataColumn[] columns = new DataColumn[5];

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Nome";
            columns[1] = Descricao;

            DataColumn Telefone = new DataColumn();
            Telefone.ColumnName = "Telefone";
            columns[2] = Telefone;

            DataColumn Desconto = new DataColumn();
            Desconto.ColumnName = "Dinheiro";
            columns[3] = Desconto;

            DataColumn perce = new DataColumn();
            perce.ColumnName = "Porcentagem";
            columns[4] = perce;

            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            dataSet.Tables.Add(table);
            table.Columns.AddRange(columns);

            foreach (Convenio con in convenioDao.GetAll())
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
