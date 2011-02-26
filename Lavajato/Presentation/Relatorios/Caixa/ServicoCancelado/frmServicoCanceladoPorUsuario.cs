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

using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmServicoCanceladoPorUsuario : Form
    {
        public frmServicoCanceladoPorUsuario()
        {
            InitializeComponent();
        }

        private void frmServicoCancelado_Load(object sender, EventArgs e)
        {
            PreviewReport(GetServicoCancelado());
            this.reportServicosCancelados.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath +
                Resources.pathServicoCancelado, Resources.rdlServicoCancelado);
            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
            this.reportServicosCancelados.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsServicoCancelado, table);
            this.reportServicosCancelados.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetServicoCancelado()
        {
            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            var dataSet = util.byQuery("procServicoCancelado");
            dataSet.Tables.Add(table);
            var reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                var row = table.NewRow();
                row["Nome"] = reader.GetString(0);
                row["ServicoID"] = reader.GetInt32(1);
                row["Total"] = reader.GetDecimal(2);
                row["Entrada"] = reader.GetDateTime(3);
                row["Produto"] = reader.GetString(4);
         
                table.Rows.Add(row);
            }
            return table;
        }

        private static DataColumn[] SetUpColumns()
        {
            var columns = new DataColumn[5];

            var Nome = new DataColumn();
            Nome.ColumnName = "Nome";
            columns[0] = Nome;

            var ServicoID = new DataColumn();
            ServicoID.ColumnName = "ServicoID";
            columns[1] = ServicoID;

            DataColumn Total = new DataColumn();
            Total.ColumnName = "Total";
            columns[2] = Total;

            DataColumn Entrada = new DataColumn();
            Entrada.ColumnName = "Entrada";
            columns[3] = Entrada;

            DataColumn Produto = new DataColumn();
            Produto.ColumnName = "Produto";
            columns[4] = Produto;

            return columns;
        }
    }
}
