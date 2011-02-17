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

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmLavagemPorLavadorRelatorio : Form
    {
        public frmLavagemPorLavadorRelatorio()
        {
            InitializeComponent();
        }

        private DateTime dataInicial;
        private DateTime dataFinal;
        private int usuarioID;
        public frmLavagemPorLavadorRelatorio(DateTime dataInicial, DateTime dataFinal, int usuarioID)
        {
            InitializeComponent();
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.usuarioID = usuarioID;
        }

        private void frmLavagemPorLavadorRelatorio_Load(object sender, EventArgs e)
        {
            PreviewReport(GetFechamentoDeCaixa());
            this.reportViewer1.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath + "\\Relatorios\\", "rptLavagemPorLavador.rdlc");
            strPathReport = strPathReport.Replace(@"bin\Debug\", "");
             this.reportViewer1.LocalReport.ReportPath = strPathReport;

             ReportDataSource myReportDataSource = new ReportDataSource("dsLavagemPorLavador_DataTable1", table);
             this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetFechamentoDeCaixa()
        {
            Util util = new Util();
            string query =  " SELECT" +
                            " U.NOME, " +
                            " P.DESCRICAO, " +
                            " COUNT(SI.SERVICOITENSID) TOTALSERVICOS  " +
                            " FROM SERVICO S" +
                            "    INNER JOIN SERVICOITENS SI ON S.SERVICOID = SI.SERVICOID" +
                            "   INNER JOIN PRODUTO P ON SI.PRODUTOID = P.PRODUTOID" +
                            "  INNER JOIN USUARIOS U ON S.LAVADORID = U.USUARIOID" +
                            " INNER JOIN TIPOFUNCIONARIO TF ON U.TIPOFUNCIONARIOID = U.TIPOFUNCIONARIOID" +
                            " WHERE TF.TIPOFUNCIONARIOID = 3 AND P.CATEGORIAPRODUTOID = 2 AND S.LAVADORID = " + this.usuarioID + " " +
                            " AND CONVERT(VARCHAR, S.ENTRADA, 103) >= '" + Configuracao.HoraPtBR(this.dataInicial) + "' AND CONVERT(VARCHAR, S.ENTRADA, 103) <= '" + Configuracao.HoraPtBR(this.dataFinal) + "'" +
                            " GROUP BY U.NOME, P.DESCRICAO";


            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.byQuery(query);
            dataSet.Tables.Add(table);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Nome"] = reader.GetString(0);
                row["Descricao"] = reader.GetString(1);
                row["TotalServicos"] = reader.GetInt32(2);

                table.Rows.Add(row);
            }
            return table;
        }

        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[3];

            DataColumn nome = new DataColumn();
            nome.ColumnName = "Nome";
            columns[0] = nome;

            DataColumn desc = new DataColumn();
            desc.ColumnName = "Descricao";
            columns[1] = desc;

          
            DataColumn totServ = new DataColumn();
            totServ.ColumnName = "TotalServicos";
            columns[2] = totServ;

            return columns;
        }
    }
}
