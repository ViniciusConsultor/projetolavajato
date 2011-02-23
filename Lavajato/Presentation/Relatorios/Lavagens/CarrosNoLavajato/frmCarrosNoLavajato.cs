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
    public partial class frmCarrosNoLavajato : Form
    {
        public frmCarrosNoLavajato()
        {
            InitializeComponent();
        }

        private void frmCarrosNoLavajato_Load(object sender, EventArgs e)
        {
            PreviewReport(GetCarrosNoLavajato());
            this.reportViewer1.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath +
                Resources.pathCarroNoLavajato, Resources.rdlCarroNoLavajato);

            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
           this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsCarroNoLavajato,
                table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetCarrosNoLavajato()
        {
            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.byQuery("procCarrosNoLavajato");
            dataSet.Tables.Add(table);
            var reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["ServicoID"] = reader.GetInt32(0);
                row["OrdemServico"] = reader.GetInt32(1);
                row["Placa"] = reader.GetString(2);
                row["Lavado"] = reader.GetByte(3) == 0 ? "Não Lavado" : "Lavado";
                row["HoraPrevistadeSaida"] = reader.GetDateTime(4);

                table.Rows.Add(row);
            }
            return table;
        }

        private static DataColumn[] SetUpColumns()
        {
            var columns = new DataColumn[5];

            DataColumn ServicoID = new DataColumn();
            ServicoID.ColumnName = "ServicoID";
            columns[0] = ServicoID;

            DataColumn OrdemServico = new DataColumn();
            OrdemServico.ColumnName = "OrdemServico";
            columns[1] = OrdemServico;

            DataColumn Placa = new DataColumn();
            Placa.ColumnName = "Placa";
            columns[2] = Placa;

            DataColumn Lavado = new DataColumn();
            Lavado.ColumnName = "Lavado";
            columns[3] = Lavado;
            
            DataColumn HoraPrevistadeSaida = new DataColumn();
            HoraPrevistadeSaida.ColumnName = "HoraPrevistadeSaida";
            columns[4] = HoraPrevistadeSaida;

            return columns;
        }

    }
}
