using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmProdutoAbaixoEstoque : Form
    {
        public frmProdutoAbaixoEstoque()
        {
            InitializeComponent();
        }

        private void frmProdutoAbaixoEstoque_Load(object sender, EventArgs e)
        {
            PreviewReport(GetProdutoAbaixoEstoque());
            this.rvProdutoAbaixoEstoque.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath + "\\Relatorios\\" , "relProdutoAbaixoEstoque.rdlc");
            
            strPathReport = strPathReport.Replace(@"bin\Debug\", "");
            this.rvProdutoAbaixoEstoque.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource("relProdutoAbaixoEstoque_DataTable1", table);
            this.rvProdutoAbaixoEstoque.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetProdutoAbaixoEstoque()
        {
            Util util = new Util();
            string query = " SELECT P.DESCRICAO, P.VALORUNITARIO, E.MINIMO, E.QUANTIDADE, P.PRECOCOMPRA, CP.DESCRICAO [CATEGORIAPRODUTO] FROM PRODUTO P "+
	                       " INNER JOIN ESTOQUE E ON P.ESTOQUE = E.ESTOQUEID "+
                           " INNER JOIN CATEGORIAPRODUTO CP ON P.CATEGORIAPRODUTOID = CP.CATEGORIAPRODUTOID " +
                           " WHERE CP.CATEGORIAPRODUTOID = 1 ";


            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.byQuery(query);
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
