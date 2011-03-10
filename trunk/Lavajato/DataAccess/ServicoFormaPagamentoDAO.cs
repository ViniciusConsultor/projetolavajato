using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;

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
    }
}
