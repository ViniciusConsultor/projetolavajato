using System;
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
            string strPathReport = Path.Combine(Application.StartupPath + Resources.relFechamentoDeCaixa, Resources.rdlVendaPorPeriodo);
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
                row["TotalDesconto"] = reader.GetDecimal(5);
                row["Dinheiro"] = reader.GetDecimal(6);
                row["VisaDebito"] = reader.GetDecimal(7);
                row["VisaCredito"] = reader.GetDecimal(8);
                row["MasterDebito"] = reader.GetDecimal(9);
                row["MasterCredito"] = reader.GetDecimal(10);
                row["Entrada"] = reader.GetDecimal(11);
                row["Saida"] = reader.GetDecimal(12);
                row["SomaTotal"] = reader.GetDecimal(13);

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
            var columns = new DataColumn[14];

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

            DataColumn totalDesconto = new DataColumn();
            totalDesconto.ColumnName = "TotalDesconto";
            columns[5] = totalDesconto;

            DataColumn dinheiro = new DataColumn();
            dinheiro.ColumnName = "Dinheiro";
            columns[6] = dinheiro;

            DataColumn visaDebito = new DataColumn();
            visaDebito.ColumnName = "VisaDebito";
            columns[7] = visaDebito;

            DataColumn visaCredito = new DataColumn();
            visaCredito.ColumnName = "VisaCredito";
            columns[8] = visaCredito;

            DataColumn masterDebito = new DataColumn();
            masterDebito.ColumnName = "MasterDebito";
            columns[9] = masterDebito;

            DataColumn masterCredito = new DataColumn();
            masterCredito.ColumnName = "MasterCredito";
            columns[10] = masterCredito;

            DataColumn entrada = new DataColumn();
            entrada.ColumnName = "Entrada";
            columns[11] = entrada;

            DataColumn saida = new DataColumn();
            saida.ColumnName = "Saida";
            columns[12] = saida;

            DataColumn SomaTotal = new DataColumn();
            SomaTotal.ColumnName = "SomaTotal";
            columns[13] = SomaTotal;

            return columns;
        }


    
    }
}
