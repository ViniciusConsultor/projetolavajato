using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class FormaPagamentoDAO:DataAccessBase
    {
        public FormaPagamentoDAO()
        {

        }

        public FormaPagamento ByID(FormaPagamento forPagamento)
        {
            string query = "SELECT [FormaPagamentoID] ,[Descricao] FROM [Lavajado].[dbo].[FormaPagamento] Where [FormaPagamentoID] = " + forPagamento.ID;
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            FormaPagamento f = new FormaPagamento();
            if (reader.Read())
            {                
                f.ID = reader.GetInt32(0);
                f.Descricao = reader.GetString(1);
                return f;
            }
            return f;
        }

        public List<FormaPagamento> GetAll()
        {
            string query = "SELECT [FormaPagamentoID] ,[Descricao] FROM [Lavajado].[dbo].[FormaPagamento] ";
            DataBaseHelper dataBaseHelper = new DataBaseHelper(query);
            DataSet dataSet = dataBaseHelper.Run(this.ConnectionString);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<FormaPagamento> fps = new List<FormaPagamento>();
            while (reader.Read())
            {
                FormaPagamento f = new FormaPagamento();
                f.ID = reader.GetInt32(0);
                f.Descricao = reader.GetString(1);
                fps.Add(f);
            }

            return fps;
        }
    }
}
