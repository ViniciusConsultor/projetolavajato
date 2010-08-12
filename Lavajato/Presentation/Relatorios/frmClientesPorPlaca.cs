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

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmClientesPorPlaca : Form
    {
        private string placa;

        public frmClientesPorPlaca()
        {
            InitializeComponent();
        }

        public frmClientesPorPlaca(string placa)
        {
            InitializeComponent();
            this.placa = placa;
            PreviewReport(GetClientePorPlaca());
            this.reportViewer1.RefreshReport();
        }

        private void frmClientesPorPlaca_Load(object sender, EventArgs e)
        {
            
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath + "\\Relatorios\\", "frmClientePorPlaca.rdlc");

            strPathReport = strPathReport.Replace(@"bin\Debug\", "");
            this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource("clientePorPlaca_Servico", table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetClientePorPlaca()
        {
            Util util = new Util();
            string query = " SELECT Servico.ServicoID, convert(varchar, Servico.Entrada, 103) DataServico, Servico.OrdemServico" +
                           " FROM Clientes " +
                           " INNER JOIN Servico ON Clientes.ClienteID = Servico.ClienteID  " +
                           " INNER JOIN ServicoItens ON Servico.ServicoID = ServicoItens.ServicoID " +
                           " INNER JOIN Produto ON ServicoItens.ProdutoID = Produto.ProdutoID  " +
                           " WHERE clientes.placa = '" + placa + "' and clientes.[delete] = 0" +
                           " GROUP BY Servico.ServicoID, convert(varchar, Servico.Entrada, 103), Servico.OrdemServico";
            
            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.GeraTabela(query);
            dataSet.Tables.Add(table);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["ServicoID"] = reader.IsDBNull(0) ? 0 :  reader.GetInt32(0);
                row["DataServico"] = reader.IsDBNull(1) ? "" : reader.GetString(1);
                row["OrdemServico"] = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                table.Rows.Add(row);
            }
            return table;
        }


        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[3];

            DataColumn servicoID = new DataColumn();
            servicoID.ColumnName = "ServicoID";
            columns[0] = servicoID;

            DataColumn dataServico = new DataColumn();
            dataServico.ColumnName = "DataServico";
            columns[1] = dataServico;

            DataColumn dataServ = new DataColumn();
            dataServ.ColumnName = "OrdemServico";
            columns[2] = dataServ;

            return columns;
        }

       

        private void reportViewer1_Click(object sender, EventArgs e)
        {
            string teste = "";
        }

        private void reportViewer1_Hyperlink(object sender, HyperlinkEventArgs e)
        {
            string teste= "";
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
