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

using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmRelatorioFechamentoDeCaixa : Form
    {
        public frmRelatorioFechamentoDeCaixa()
        {
            InitializeComponent();
        }

        private int _usuarioID;
        private string _data;

        public frmRelatorioFechamentoDeCaixa(int usuarioID, string date)
        {
            InitializeComponent();
            _usuarioID = usuarioID;
            _data = date;
        }

        private void frmRelatorioFechamentoDeCaixa_Load(object sender, EventArgs e)
        {
            PreviewReport(GetFechamentoDeCaixa());
            this.reportViewFechamentoCaixa.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath + Resources.relFechamentoDeCaixa,
                Resources.rdlVendaPorPeriodo);
            
            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
            this.reportViewFechamentoCaixa.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsFechamentoCaixa, table);
            this.reportViewFechamentoCaixa.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetFechamentoDeCaixa()
        {
            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            SqlParameter[] parameter = GetParameters();

            var dataSet = util.byProcedure("FechamentoDeCaixa", parameter);
            dataSet.Tables.Add(table);
            var reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                var row = table.NewRow();
                row["OSInicial"] = reader.GetInt32(0);
                row["OSFinal"] = reader.GetInt32(1);
                row["QtdeOS"] = reader.GetInt32(2);
                row["OSCancelado"] = reader.GetInt32(3);
                row["TotalVendas"] = reader.GetDecimal(4);
                row["TotalCaixa"] = reader.GetDecimal(5);
                row["TotalDesconto"] = reader.GetDecimal(6);
                row["Dinheiro"] = reader.GetDecimal(7);
                row["VisaDebito"] = reader.GetDecimal(8);
                row["VisaCredito"] = reader.GetDecimal(9);
                row["MasterDebito"] = reader.GetDecimal(10);
                row["MasterCredito"] = reader.GetDecimal(11);
                row["Entrada"] = reader.GetDecimal(12);
                row["Saida"] = reader.GetDecimal(13);
                row["Vale"] = reader.GetDecimal(14);
                row["SomaTotal"] = reader.GetDecimal(15);
                row["ValeTransporte"] = reader.GetDecimal(16);
                row["DespeasNotaFiscal"] = reader.GetDecimal(17);

                table.Rows.Add(row);
            }
            return table;
        }

        private SqlParameter[] GetParameters()
        {
            SqlParameter[] parameters =new SqlParameter[2];
            parameters[0] = new SqlParameter("@data", _data);
            parameters[1] = new SqlParameter("@idUsuario", _usuarioID);
            return parameters;
        }

        private static DataColumn[] SetUpColumns()
        {
            var columns = new DataColumn[18];

            var osInicial = new DataColumn();
            osInicial.ColumnName = "OSInicial";
            columns[0] = osInicial;

            var osFinal = new DataColumn();
            osFinal.ColumnName = "OSFinal";
            columns[1] = osFinal;

            var QtdeOS = new DataColumn();
            QtdeOS.ColumnName = "QtdeOS";
            columns[2] = QtdeOS;
            
            DataColumn osCancelado = new DataColumn();
            osCancelado.ColumnName = "OSCancelado";
            columns[3] = osCancelado;

            DataColumn totalVendas = new DataColumn();
            totalVendas.ColumnName = "TotalVendas";
            columns[4] = totalVendas;

            DataColumn TotalCaixa = new DataColumn();
            TotalCaixa.ColumnName = "TotalCaixa";
            columns[5] = TotalCaixa;

            DataColumn totalDesconto = new DataColumn();
            totalDesconto.ColumnName = "TotalDesconto";
            columns[6] = totalDesconto;

            DataColumn dinheiro = new DataColumn();
            dinheiro.ColumnName = "Dinheiro";
            columns[7] = dinheiro;

            DataColumn visaDebito = new DataColumn();
            visaDebito.ColumnName = "VisaDebito";
            columns[8] = visaDebito;

            DataColumn visaCredito = new DataColumn();
            visaCredito.ColumnName = "VisaCredito";
            columns[9] = visaCredito;

            DataColumn masterDebito = new DataColumn();
            masterDebito.ColumnName = "MasterDebito";
            columns[10] = masterDebito;

            DataColumn masterCredito = new DataColumn();
            masterCredito.ColumnName = "MasterCredito";
            columns[11] = masterCredito;

            DataColumn entrada = new DataColumn();
            entrada.ColumnName = "Entrada";
            columns[12] = entrada;

            DataColumn Saida = new DataColumn();
            Saida.ColumnName = "Saida";
            columns[13] = Saida;

            DataColumn Vale = new DataColumn();
            Vale.ColumnName = "Vale";
            columns[14] = Vale;

            DataColumn SomaTotal = new DataColumn();
            SomaTotal.ColumnName = "SomaTotal";
            columns[15] = SomaTotal;

            DataColumn ValeTransporte = new DataColumn();
            ValeTransporte.ColumnName = "ValeTransporte";
            columns[16] = ValeTransporte;

            DataColumn DespeasNotaFiscal = new DataColumn();
            DespeasNotaFiscal.ColumnName = "DespeasNotaFiscal";
            columns[17] = DespeasNotaFiscal;

            return columns;
        }


    
    }
}
