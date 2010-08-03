using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using System.Data;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.DataAccess
{
    public class ContaAPagarDAO : DataAccessBase
    {
        private const string sql = " SELECT [ContasPagaID],[NF],[Serie],[Documento],[DataDocomento],[ClienteID],[DataVencimento],[TipoDocumento],[Obs] " +
                                   " ,[DataPagamento],[AtrasoDias],[ValorPago],[SaldoAPagar] " +
                                   " FROM [Lavajado].[dbo].[ContasAPagar] ";

        public ContaAPagarDAO()
        {

        }

        public ContaPagar Insert(ContaPagar contarPagar)
        {
            string query = " INSERT INTO [Lavajado].[dbo].[ContasAPagar] " +
                     " ([NF],[Serie],[Documento],[DataDocomento] " +
                     " ,[ClienteID],[DataVencimento],[TipoDocumento],[Obs] " +
                     " ,[DataPagamento],[AtrasoDias],[ValorPago],[SaldoAPagar]) " +
                     " VALUES " +
                     " ( '" + contarPagar.NF + "' " +
                     " , '" + contarPagar.Serie + "' " +
                     " , '" + contarPagar.Documento + "' " +
                     " , '" + Configuracao.HoraEntrada( contarPagar.DataDocomento) + "' " +
                     " , '" + contarPagar.Credor.ID + "' " +
                     " , '" + Configuracao.HoraEntrada( contarPagar.DataVencimento) + "' " +
                     " , '" + contarPagar.TipoDocumento + "' " +
                     " , '" + contarPagar.Obs + "' " +
                     " , '" + Configuracao.HoraEntrada( contarPagar.DataPagamento) + "' " +
                     " , '" + Configuracao.HoraEntrada( contarPagar.AtrasoDias) + "' " +
                     " , '" + contarPagar.ValorPago + "' " +
                     " , '" + contarPagar.SaldoAPagar + "' ) ";

            DataBaseHelper baseHelper = new DataBaseHelper(query);
            baseHelper.Run(this.ConnectionString);

            return ByID(Max());
        }

        public ContaPagar ByID(ContaPagar contarPagar)
        {
            string query = sql + " where [ContasPagaID] = " + contarPagar.ID;
            DataBaseHelper baseHelper = new DataBaseHelper(query);
            DataSet dst = baseHelper.Run(this.ConnectionString);
            return SetUpField(dst);
        }

        public ContaPagar ByID(int contarPagarID)
        {
            string query = sql + " where [ContasPagaID] = " + contarPagarID;
            DataBaseHelper baseHelper = new DataBaseHelper(query);
            DataSet dst = baseHelper.Run(this.ConnectionString);
            return SetUpField(dst);
        }

        public void Delete(ContaPagar contarPagar)
        {
            string query = " DELETE FROM [Lavajado].[dbo].[ContasAPagar]   WHERE [ContasPagaID] = " + contarPagar.ID;
            DataBaseHelper baseHelper = new DataBaseHelper(query);
            baseHelper.Run();
        }

        public ContaPagar Update(ContaPagar contarPagar)
        {
            string query = " UPDATE [Lavajado].[dbo].[ContasAPagar] " +
               " SET [NF] = '" + contarPagar.NF + "' " +
               ",[Serie] = '" + contarPagar.Serie + "' " +
               ",[Documento] ='" + contarPagar.Documento + "' " +
               ",[DataDocomento] = '" + Configuracao.HoraEntrada( contarPagar.DataDocomento) + "' " +
               ",[ClienteID] = '" + contarPagar.Credor.ID + "' " +
               ",[DataVencimento] = '" + Configuracao.HoraEntrada( contarPagar.DataVencimento) + "' " +
               ",[TipoDocumento] = '" + contarPagar.TipoDocumento + "' " +
               ",[Obs] = '" + contarPagar.Obs + "' " +
               ",[DataPagamento] = '" + Configuracao.HoraEntrada( contarPagar.DataPagamento) + "' " +
               ",[AtrasoDias] = '" + contarPagar.AtrasoDias + "' " +
               ",[ValorPago] = '" + contarPagar.ValorPago + "' " +
               ",[SaldoAPagar] = '" + contarPagar.SaldoAPagar + "' " +
               "WHERE [ContasPagaID] = " + contarPagar.ID;
            DataBaseHelper baseHelper = new DataBaseHelper(query);
            baseHelper.Run();
            return ByID(contarPagar);
        }

        public List<ContaPagar> GetAll()
        {
            DataBaseHelper baseHelper = new DataBaseHelper(sql);
            DataSet dst = baseHelper.Run(this.ConnectionString);
            return SetUpFields(dst);
        }

        public List<ContaPagar> PesquisaPorDataETipo(string tipoPesquisa, string documento, DateTime data)
        {
            string query = sql + " INNER JOIN Credor c on cp.[ClienteID] = c.[CredorID] ";
            switch (tipoPesquisa)
            {
                case "MostrarTodos":
                    query += " ORDER BY C.RAZAOSOCIAL ";
                    break;
                case "Pagos":
                    query += " WHERE cp.[ValorPago] = cp.[ValorTitulo] ORDER BY C.RAZAOSOCIAL ";
                    break;
                case "Documento":
                    query += " WHERE cp.[Documento] = '" + documento + "' ORDER BY C.RAZAOSOCIAL ";
                    break;
                case "RazaoSocial":
                    query += " WHERE C.[RazaoSocial] like('%"+documento+"%') ORDER BY C.RAZAOSOCIAL ";
                    break;
                case "VencendoHoje":
                    query += " WHERE CONVERT(VARCHAR, cp.[DataDocumento], 103) = '" + Configuracao.HoraPtBR(data) + "' ORDER BY C.RAZAOSOCIAL ";
                    break;
                
                
            }
    
            DataBaseHelper baseHelper = new DataBaseHelper(query);
            DataSet dst = baseHelper.Run(this.ConnectionString);
            return SetUpFields(dst);
        }

        private ContaPagar SetUpField(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            ContaPagar cp = new ContaPagar();
            if (reader.Read())
            {
                cp.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                cp.NF = reader.IsDBNull(1) ? "" : reader.GetString(1);
                cp.Serie = reader.IsDBNull(2) ? "" : reader.GetString(2);
                cp.Documento = reader.IsDBNull(3) ? "" : reader.GetString(3);
                cp.DataDocomento = reader.IsDBNull(4) ? new DateTime(1900, 01,01) : reader.GetDateTime(4);
                cp.Credor.ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                cp.DataVencimento = reader.IsDBNull(6) ? new DateTime(1900, 01, 01) : reader.GetDateTime(6);
                cp.TipoDocumento = reader.IsDBNull(7) ? "" : reader.GetString(7);
                cp.Obs = reader.IsDBNull(8) ? "" : reader.GetString(8);
                cp.DataPagamento = reader.IsDBNull(9) ? new DateTime(1900, 01, 01) : reader.GetDateTime(9);
                cp.AtrasoDias = reader.IsDBNull(10) ? new DateTime(1900, 01, 01) : reader.GetDateTime(10);
                cp.ValorPago = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
                cp.SaldoAPagar = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
            }

            return cp;
        }

        private int Max()
        {
            string query = " SELECT MAX([ContasPagaID]) FROM [Lavajado].[dbo].[ContasAPagar] ";
            DataBaseHelper baseHelper = new DataBaseHelper(query);
            return int.Parse( baseHelper.Run(this.ConnectionString).Tables[0].Rows[0][0].ToString());
        }

        private List<ContaPagar> SetUpFields(DataSet dataSet)
        {
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            List<ContaPagar> cps = new List<ContaPagar>();
            while (reader.Read())
            {
                ContaPagar cp = new ContaPagar();
                cp.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                cp.NF = reader.IsDBNull(1) ? "" : reader.GetString(1);
                cp.Serie = reader.IsDBNull(2) ? "" : reader.GetString(2);
                cp.Documento = reader.IsDBNull(3) ? "" : reader.GetString(3);
                cp.DataDocomento = reader.IsDBNull(4) ? new DateTime(1900, 01, 01) : reader.GetDateTime(4);
                cp.Credor.ID = reader.IsDBNull(5) ? 0 : reader.GetInt32(6);
                cp.DataVencimento = reader.IsDBNull(6) ? new DateTime(1900, 01, 01) : reader.GetDateTime(6);
                cp.TipoDocumento = reader.IsDBNull(7) ? "" : reader.GetString(7);
                cp.Obs = reader.IsDBNull(8) ? "" : reader.GetString(8);
                cp.DataPagamento = reader.IsDBNull(9) ? new DateTime(1900, 01, 01) : reader.GetDateTime(9);
                cp.AtrasoDias = reader.IsDBNull(10) ? new DateTime(1900, 01, 01) : reader.GetDateTime(10);
                cp.ValorPago = reader.IsDBNull(11) ? 0 : reader.GetDecimal(11);
                cp.SaldoAPagar = reader.IsDBNull(12) ? 0 : reader.GetDecimal(12);
            }

            return cps;
        }



    }
}
