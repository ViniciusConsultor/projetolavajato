using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ServicoFormaPagamentoDAO : DataAccessBase
    {
        public ServicoFormaPagamentoDAO()
        {

        }

        public void Insert(Pagamento pagamento)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" INSERT INTO [Lavajato].[dbo].[ServicoFormaPagamento] ");
            query.Append("([ServicoID],[Total],[SubTotal] ");
            query.Append(",[Desconto],[Dinheiro]");
            query.Append(",[UsuarioDesc],[VisaDebito] ");
            query.Append(",[VisaCredito],[MasterDebito],[MasterCredito])");
            query.Append(" VALUES ");
            query.Append("('" + pagamento.Servico.ID + "' ");
            query.Append(", '" + pagamento.Total.ToString().Replace(",", ".") + "' ");
            query.Append(", '" + pagamento.SubTotal.ToString().Replace(",", ".") + "' ");
            query.Append(", '" + pagamento.Desconto.ToString().Replace(",", ".") + "' ");
            query.Append(", '" + pagamento.Dinheiro.ToString().Replace(",", ".") + "' ");
            query.Append(", '" + pagamento.UsuarioDesconto.ID + "' ");
            query.Append("," + (pagamento.FormaPagamento.ID == 2 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
            query.Append("," + (pagamento.FormaPagamento.ID == 3 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
            query.Append("," + (pagamento.FormaPagamento.ID == 4 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
            query.Append("," + (pagamento.FormaPagamento.ID == 5 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
            query.Append(")");

            var dataBaseHelper = new DataBaseHelper(query.ToString());
            dataBaseHelper.Run();

        }

        public void Update(Pagamento pagamento)
        {
            StringBuilder query = new StringBuilder();
                query.Append("  UPDATE [Lavajato].[dbo].[ServicoFormaPagamento]");
                   query.Append("SET ");
                      query.Append("[Total] = " + pagamento.Total);
                      query.Append(",[SubTotal] = " + pagamento.SubTotal);
                      query.Append(",[Desconto] = " + pagamento.Desconto);
                      query.Append(",[Dinheiro] = " + pagamento.Dinheiro);
                      query.Append(",[UsuarioDesc] ="+pagamento.UsuarioDesconto);
                      query.Append(",[VisaDebito] ="+ (pagamento.FormaPagamento.ID == 2 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
                      query.Append(",[VisaCredito] ="+ (pagamento.FormaPagamento.ID == 3 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
                      query.Append(",[MasterDebito] ="+ (pagamento.FormaPagamento.ID == 4 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
                        query.Append(",[MasterCredito] ="+ (pagamento.FormaPagamento.ID == 5 ? pagamento.Cartao : 0).ToString().Replace(",", "."));
                 query.Append("WHERE ServicoID = " + pagamento.Servico.ID);

            


            var dataBaseHelper = new DataBaseHelper(query.ToString());
            dataBaseHelper.Run();

        }

        public Pagamento FindByServico(Pagamento pagamento)
        {
            StringBuilder query = new StringBuilder();
            query.Append(" SELECT [FormaPagamentoID]");
                         query.Append( " ,[ServicoID]");
                          query.Append(" ,[Total]");
                          query.Append(" ,[SubTotal]");
                          query.Append(" ,[Desconto]");
                          query.Append(" ,[Dinheiro]");
                          query.Append(" ,[UsuarioDesc]");
                          query.Append(" ,[VisaDebito]");
                          query.Append(" ,[VisaCredito]");
                          query.Append(" ,[MasterDebito]");
                          query.Append( ",[MasterCredito]");
                          query.Append(" FROM [Lavajato].[dbo].[ServicoFormaPagamento]");
                          query.Append("Where ServicoID = " + pagamento.Servico.ID);


            var dataBaseHelper = new DataBaseHelper(query.ToString());
            DataSet dst = dataBaseHelper.Run(this.ConnectionString);
            return SetUpField(dst);

        }

        private Pagamento SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            Pagamento pagamento = new Pagamento();
            if (reader.Read())
            {
                pagamento.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                pagamento.Servico.ID = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                pagamento.Total = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);
                pagamento.SubTotal = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3);
                pagamento.Desconto = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                pagamento.Dinheiro = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                pagamento.FormaPagamento.ID = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                pagamento.UsuarioDesconto.ID = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                pagamento.Cartao = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8);
                pagamento.Cartao = reader.IsDBNull(9) ? 0 : reader.GetDecimal(9);
                pagamento.Cartao = reader.IsDBNull(10) ? 0 : reader.GetDecimal(10);
                
                return pagamento;
            }
            return pagamento;
        }
    }
}
