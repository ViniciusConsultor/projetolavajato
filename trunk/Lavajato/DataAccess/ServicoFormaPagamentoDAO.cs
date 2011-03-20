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
            string query = " INSERT INTO [Lavajato].[dbo].[ServicoFormaPagamento] " +
             " ([ServicoID],[Total],[SubTotal] " +
             " ,[Desconto],[CartaoValor],[Dinheiro]" +
             " ,[CartaoTipo],  [UsuarioDesc])" +
             " VALUES " +
             "('" + pagamento.Servico.ID + "' " +
             ", '" + pagamento.Total.ToString().Replace(",", ".") + "' " +
             ", '" + pagamento.SubTotal.ToString().Replace(",", ".") + "' " +
             ", '" + pagamento.Desconto.ToString().Replace(",", ".") + "' " +
             ", '" + pagamento.Cartao.ToString().Replace(",", ".") + "' " +
             ", '" + pagamento.Dinheiro.ToString().Replace(",", ".") + "' " +
             ", '" + pagamento.FormaPagamento.ID + "' " +
             ", '" + pagamento.UsuarioDesconto.ID + "') ";


            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

        }

        public void Update(Pagamento pagamento)
        {
            string query = " UPDATE [Lavajato].[dbo].[ServicoFormaPagamento] " +
              "SET "+ 
              "   [Total] = '" + pagamento.Total + "' " +
              "   ,[SubTotal] = '" + pagamento.SubTotal.ToString().Replace(",", ".") + "' " +
              "   ,[Desconto] = '" + pagamento.Desconto.ToString().Replace(",", ".") + "' " +
              "   ,[CartaoValor] = '" + pagamento.Cartao.ToString().Replace(",", ".") + "' " +
              "   ,[Dinheiro] = '" + pagamento.Dinheiro.ToString().Replace(",", ".") + "' " +
              "   ,[CartaoTipo] = '" + pagamento.FormaPagamento.ID + "' " +
              " WHERE ServicoID = " + pagamento.Servico.ID;


            var dataBaseHelper = new DataBaseHelper(query);
            dataBaseHelper.Run();

        }

        public Pagamento FindByServico(Pagamento pagamento)
        {
            string query = " SELECT [FormaPagamentoID],[ServicoID],[Total],[SubTotal], " +
                           " [Desconto],[CartaoValor],[Dinheiro],[CartaoTipo],[UsuarioDesc] " +
                      " FROM [Lavajato].[dbo].[ServicoFormaPagamento] "+
                      " WHERE ServicoID = " + pagamento.Servico.ID;

            var dataBaseHelper = new DataBaseHelper(query);
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
                pagamento.Cartao = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                pagamento.Dinheiro = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                pagamento.FormaPagamento.ID = reader.IsDBNull(7) ? 0 : reader.GetInt32(7);
                pagamento.UsuarioDesconto.ID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8);
                return pagamento;
            }
            return pagamento;
        }
    }
}
