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
    public partial class frmClientesPorPlaca : Form
    {
        private string _placa;

        public frmClientesPorPlaca()
        {
            InitializeComponent();
        }

        public frmClientesPorPlaca(string placa)
        {
            InitializeComponent();
            _placa = placa;

            PreviewReport(GetServicoClientes());
            this.reportViewer1.RefreshReport();
        }

        private void frmClientesPorPlaca_Load(object sender, EventArgs e)
        {
         
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath +
                Resources.pathClientePorPlaca, Resources.rdlClientePorPlaca);

            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
            this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsCientePorPlaca, table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetServicoClientes()
        {
            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            SqlParameter[] parameter = GetParameters();

            var dataSet = util.byProcedure("procHistoricoCliente", parameter);
            dataSet.Tables.Add(table);
            var reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["ServicoID"] = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                row["Descricao"] = reader.IsDBNull(1) ? "" : reader.GetString(1);
                row["DataServico"] = reader.IsDBNull(2) ? "" : reader.GetString(2);
                row["OrdemServico"] = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                table.Rows.Add(row);
            }
            return table;
        }

        private SqlParameter[] GetParameters()
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@placa", _placa);
            
            return parameters;
        }

        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[4];

            DataColumn servicoID = new DataColumn();
            servicoID.ColumnName = "ServicoID";
            columns[0] = servicoID;

            DataColumn descricao = new DataColumn();
            descricao.ColumnName = "Descricao";
            columns[1] = descricao;

            DataColumn dataServico = new DataColumn();
            dataServico.ColumnName = "DataServico";
            columns[2] = dataServico;

            DataColumn dataServ = new DataColumn();
            dataServ.ColumnName = "OrdemServico";
            columns[3] = dataServ;

            return columns;
        }

       

        private void reportViewer1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Hyperlink(object sender, HyperlinkEventArgs e)
        {

        }

     


        //private DataColumn[] SetUpColumns()
        //{
        //    DataColumn[] columns = new DataColumn[4];

        //    DataColumn cli = new DataColumn();
        //    cli.ColumnName = "Cliente";
        //    columns[0] = cli;

        //    DataColumn prod = new DataColumn();
        //    prod.ColumnName = "Produto";
        //    columns[1] = prod;

        //    DataColumn qtde = new DataColumn();
        //    qtde.ColumnName = "Quantidade";
        //    columns[2] = qtde;

        //    DataColumn vauni = new DataColumn();
        //    vauni.ColumnName = "ValorUnitario";
        //    columns[3] = vauni;


        //    return columns;
        //}
    }
}
