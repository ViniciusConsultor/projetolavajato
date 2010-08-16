﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmRelatorioFechamentoDeCaixa : Form
    {
        public frmRelatorioFechamentoDeCaixa()
        {
            InitializeComponent();
        }

        private void frmRelatorioFechamentoDeCaixa_Load(object sender, EventArgs e)
        {
            PreviewReport(GetFechamentoDeCaixa());
            this.reportViewFechamentoCaixa.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = @"C:\Projetos\Lavajato\Presentation\Relatorios\VendaPorPeriodo.rdlc";//Path.Combine(Application.StartupPath, "VendaPorPeriodo.rdlc");

            //strPathReport = strPathReport.Replace(@"bin\Debug\", "");
            this.reportViewFechamentoCaixa.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource("FechamentoCaixa_DataTable1", table);
            this.reportViewFechamentoCaixa.LocalReport.DataSources.Add(myReportDataSource);

        }

        public DataTable GetFechamentoDeCaixa()
        {
            Util util = new Util();
            string query = " select distinct min(s.servicoid) as [OSInicial], max(s.servicoid) as [OSFinal], " +
                           " (select count(servico.cancelado) from servico where  servico.cancelado = 1 and s.servicoid = servico.servicoid) as [OSCancelado], "+
                           " sum(s.Total) as [TotalVendas], sum(s.Desconto) as [TotalDesconto], "+
                           " isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 1 and s.servicoid = servico.servicoid),0) as [Dinheiro], "+
                           " isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 2 and s.servicoid = servico.servicoid),0)  as [VisaDebito], "+
                           " isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 3 and s.servicoid = servico.servicoid),0)  as [VisaCredito], "+
                           " isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 4 and s.servicoid = servico.servicoid),0) as [MasterDebito], "+
                           " isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 5 and s.servicoid = servico.servicoid),0)  as [MasterDebito], "+
                           " isnull((select sum(valor) from suprimentos where convert(varchar, s.entrada, 103) = 'parametro'), 0) as Entrada, "+
                           " isnull((select sum(valor) from retirada where convert(varchar, s.entrada, 103) = 'parametro'), 0) as Saida "+
                           " from servico s "+
                           " group by s.ServicoID, s.entrada ";


            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.GeraTabela(query);
            dataSet.Tables.Add(table);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["OSInicial"] = reader.GetInt32(0);
                row["OSFinal"] = reader.GetInt32(1);
                row["OSCancelado"] = reader.GetInt32(2);
                row["TotalVendas"] = reader.GetDecimal(3);
                row["TotalDesconto"] = reader.GetDecimal(4);
                row["Dinheiro"] = reader.GetDecimal(5);
                row["VisaDebito"] = reader.GetDecimal(5);
                row["VisaCredito"] = reader.GetDecimal(7);
                row["MasterDebito"] = reader.GetDecimal(8);
                row["MasterCredito"] = reader.GetDecimal(9);
                row["Entrada"] = reader.GetDecimal(10);
                row["Saida"] = reader.GetDecimal(11);

                table.Rows.Add(row);
            }
            return table;
        }

        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[12];

            DataColumn osInicial = new DataColumn();
            osInicial.ColumnName = "OSInicial";
            columns[0] = osInicial;

            DataColumn osFinal = new DataColumn();
            osFinal.ColumnName = "OSFinal";
            columns[1] = osFinal;

            DataColumn osCancelado = new DataColumn();
            osCancelado.ColumnName = "OSCancelado";
            columns[2] = osCancelado;

            DataColumn totalVendas = new DataColumn();
            totalVendas.ColumnName = "TotalVendas";
            columns[3] = totalVendas;

            DataColumn totalDesconto = new DataColumn();
            totalDesconto.ColumnName = "TotalDesconto";
            columns[4] = totalDesconto;

            DataColumn dinheiro = new DataColumn();
            dinheiro.ColumnName = "Dinheiro";
            columns[5] = dinheiro;

            DataColumn visaDebito = new DataColumn();
            visaDebito.ColumnName = "VisaDebito";
            columns[6] = visaDebito;

            DataColumn visaCredito = new DataColumn();
            visaCredito.ColumnName = "VisaCredito";
            columns[7] = visaCredito;

            DataColumn masterDebito = new DataColumn();
            masterDebito.ColumnName = "MasterDebito";
            columns[8] = masterDebito;

            DataColumn masterCredito = new DataColumn();
            masterCredito.ColumnName = "MasterCredito";
            columns[9] = masterCredito;

            DataColumn entrada = new DataColumn();
            entrada.ColumnName = "Entrada";
            columns[10] = entrada;

            DataColumn saida = new DataColumn();
            saida.ColumnName = "Saida";
            columns[11] = saida;

            return columns;
        }


    
    }
}