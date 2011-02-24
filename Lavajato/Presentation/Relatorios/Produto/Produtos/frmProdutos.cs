using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using HenryCorporation.Lavajato.Presentation.Properties;
using Microsoft.Reporting.WinForms;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            PreviewReport(GetProdutoEstoque());
            this.reportViewer1.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath +
                Resources.pathRDLProdutoEstoque, Resources.rdlProdutoEstoque);
            strPathReport = strPathReport.Replace(Resources.BinDebug, "");
            this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource(Resources.dsProdutoEstoque, table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetProdutoEstoque()
        {

            Util util = new Util();
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.byQuery("procProdutoEstoque");
            dataSet.Tables.Add(table);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();

            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["DESCRICAO"] = reader.GetString(0);
                row["VALORUNITARIO"] = reader.GetDecimal(1);
                row["MINIMO"] = reader.GetInt32(2);
                row["QUANTIDADE"] = reader.GetInt32(3);
                row["PRECOCOMPRA"] = reader.GetDecimal(4);
                row["CATEGORIAPRODUTO"] = reader.GetString(5);
                table.Rows.Add(row);
            }
            return table;
        }

        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[12];

            DataColumn Desc = new DataColumn();
            Desc.ColumnName = "DESCRICAO";
            columns[0] = Desc;

            DataColumn valorUni = new DataColumn();
            valorUni.ColumnName = "VALORUNITARIO";
            columns[1] = valorUni;

            DataColumn minimo = new DataColumn();
            minimo.ColumnName = "MINIMO";
            columns[2] = minimo;

            DataColumn qtde = new DataColumn();
            qtde.ColumnName = "QUANTIDADE";
            columns[3] = qtde;

            DataColumn precoCompra = new DataColumn();
            precoCompra.ColumnName = "PRECOCOMPRA";
            columns[4] = precoCompra;

            DataColumn catProduto = new DataColumn();
            catProduto.ColumnName = "CATEGORIAPRODUTO";
            columns[5] = catProduto;
            return columns;
        }
    }
}
