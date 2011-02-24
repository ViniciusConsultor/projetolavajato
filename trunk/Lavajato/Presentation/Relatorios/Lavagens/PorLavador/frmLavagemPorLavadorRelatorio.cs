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

using HenryCorporation.Lavajato.Operacional;
using HenryCorporation.Lavajato.Presentation.Properties;
using System.Data.SqlClient;


namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmLavagemPorLavadorRelatorio : Form
    {
        private string _dataInicial;
        private string _dataFinal;
        private int _usuarioID;

        public frmLavagemPorLavadorRelatorio()
        {
            InitializeComponent();
        }

        public frmLavagemPorLavadorRelatorio(string dataInicial, string dataFinal, int usuarioID)
        {
            InitializeComponent();
            _dataInicial = dataInicial;
            _dataFinal = dataFinal;
            _usuarioID = usuarioID;
        }

        private void frmLavagemPorLavadorRelatorio_Load(object sender, EventArgs e)
        {
            PreviewReport(GetFechamentoDeCaixa());
            this.reportViewer1.RefreshReport();
        }

        private void frmRelatorioFechamentoDeCaixa_Load(object sender, EventArgs e)
        {
            PreviewReport(GetFechamentoDeCaixa());
            this.reportViewer1.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath +
                Resources.pathServicoPorLavador, Resources.rdlServicoPorLavador);
            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
            this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsServicoPorLavador, table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetFechamentoDeCaixa()
        {
            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            SqlParameter[] parameter = GetParameters();

            var dataSet = util.byProcedure("procServicoPorLavador", parameter);
            dataSet.Tables.Add(table);
            var reader = dataSet.Tables[0].CreateDataReader();
            
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Nome"] = reader.GetString(0);
                row["Descricao"] = reader.GetString(1);
                row["TotalServicos"] = reader.GetInt32(2);
                row["DataInicial"] = reader.GetString(3);
                row["DataFinal"] = reader.GetString(4);
                table.Rows.Add(row);
            }
            return table;
        }

        private SqlParameter[] GetParameters()
        {
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@dataInicial", _dataInicial);
            parameters[1] = new SqlParameter("@dataFinal", _dataFinal);
            parameters[2] = new SqlParameter("@usuarioID", _usuarioID);
            return parameters;
        }
 
        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[5];

            DataColumn nome = new DataColumn();
            nome.ColumnName = "Nome";
            columns[0] = nome;

            DataColumn desc = new DataColumn();
            desc.ColumnName = "Descricao";
            columns[1] = desc;
                      
            DataColumn totServ = new DataColumn();
            totServ.ColumnName = "TotalServicos";
            columns[2] = totServ;

            DataColumn entrada = new DataColumn();
            entrada.ColumnName = "DataInicial";
            columns[3] = entrada;

            DataColumn saida = new DataColumn();
            saida.ColumnName = "DataFinal";
            columns[4] = saida;

            return columns;
        }
    }
}
