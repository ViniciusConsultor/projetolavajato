using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.IO;

using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class relServicoPorOS : Form
    {
        private int _ordemServico;

        public relServicoPorOS(int ordemServico)
        {
            InitializeComponent();
            _ordemServico = ordemServico;
        }

        public relServicoPorOS()
        {
            InitializeComponent();
        }

        private void relServicoPorOS_Load(object sender, EventArgs e)
        {
            PreviewReport(GetServicoPorOS());
            this.reportViewer1.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath +
                Resources.pathServicoPorPlaca, Resources.rdlrptServicoPorOS);
            
            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
            this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsServicoPorOS, table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetServicoPorOS()
        {
            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            SqlParameter[] parameter = GetParameters();

            var dataSet = util.byProcedure("procServicoPorOrdemServico", parameter);
            dataSet.Tables.Add(table);
            var reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                var row = table.NewRow();
                row["OrdemServico"] = reader.GetInt32(0);
                row["Total"] = reader.GetDecimal(1);
                row["Produtos"] = reader.GetString(2);
                row["Lavador"] = reader.GetString(3);
                row["Desconto"] = reader.GetDecimal(4);
                row["ValorUnitario"] = reader.GetDecimal(5);
                row["Nome"] = reader.GetString(6);
                row["Placa"] = reader.GetString(7);
                row["Entrada"] = reader.GetDateTime(8);
                row["Saida"] = reader.GetDateTime(9);
                
                table.Rows.Add(row);
            }
            return table;
        }

        private SqlParameter[] GetParameters()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@data", _ordemServico);
            return parameters;
        }

        private static DataColumn[] SetUpColumns()
        {
            var columns = new DataColumn[10];

            var OrdemServico = new DataColumn();
            OrdemServico.ColumnName = "OrdemServico";
            columns[0] = OrdemServico;

            var Total = new DataColumn();
            Total.ColumnName = "Total";
            columns[1] = Total;

            DataColumn Produto = new DataColumn();
            Produto.ColumnName = "Produtos";
            columns[2] = Produto;

            DataColumn Lavador = new DataColumn();
            Lavador.ColumnName = "Lavador";
            columns[3] = Lavador;

            DataColumn Desconto = new DataColumn();
            Desconto.ColumnName = "Desconto";
            columns[4] = Desconto;

            DataColumn ValorUnitario = new DataColumn();
            ValorUnitario.ColumnName = "ValorUnitario";
            columns[5] = ValorUnitario;

            DataColumn Nome = new DataColumn();
            Nome.ColumnName = "Nome";
            columns[6] = Nome;

            DataColumn Placa = new DataColumn();
            Placa.ColumnName = "Placa";
            columns[7] = Placa;

            DataColumn Entrada = new DataColumn();
            Entrada.ColumnName = "Entrada";
            columns[8] = Entrada;

            DataColumn Saida = new DataColumn();
            Saida.ColumnName = "Saida";
            columns[9] = Saida;

            return columns;
        }
    }
}
