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
    public partial class frmRelatorioDeVendas : Form
    {
        private DateTime date;

        public frmRelatorioDeVendas()
        {
            InitializeComponent();
        }

        public frmRelatorioDeVendas(DateTime date)
        {
            this.date = date;
            InitializeComponent();
        }

        private void frmRelatorioDeVendas_Load(object sender, EventArgs e)
        {
            PreviewReport(GetFechamentoDeCaixa());
            this.reportViewer1.RefreshReport();
        }

        private void PreviewReport(DataTable table)
        {
            string strPathReport = Path.Combine(Application.StartupPath + "\\Relatorios\\", "relRelatorioDeVendas.rdlc");
            strPathReport = strPathReport.Replace(@"bin\Debug\", "");
            this.reportViewer1.LocalReport.ReportPath = strPathReport;

            ReportDataSource myReportDataSource = new ReportDataSource("relVendasDiarias_VendasDiarias", table);
            this.reportViewer1.LocalReport.DataSources.Add(myReportDataSource);
        }

        public DataTable GetFechamentoDeCaixa()
        {
            Util util = new Util();
            string query = " select xx.Nome, min(xx.[O.S. Inicial]) [OSInicial], max(xx.[O.S. Final]) as [OSFinal], sum(xx.totalvendas) as TotalVendas, sum(xx.OSCancelado) as OSCancelado , sum(xx.[TotalVendas]) TotalVendas, sum(xx.[TotalDesconto]) as TotalDesconto, " +
                           " sum(xx.[Dinheiro]) as [Dinheiro], sum(xx.[VisaDebito]) as [VisaDebito], sum(xx.[VisaCredito]) as [VisaCredito],  " +
                           " sum(xx.[MasterDebito]) as [MasterDebito], sum(xx.[MasterCredito]), xx.Entrada, xx.Saida " +
                           " from ( " +
                           " select distinct u.nome, min(s.servicoid) as [O.S. Inicial], max(s.servicoid) as [O.S. Final], " +
                           " (select count(servico.cancelado) from servico where  servico.cancelado = 1 and s.servicoid = servico.servicoid) as [OSCancelado],   " +
                           " sum(convert(smallmoney,s.total,2)) as [TotalVendas],  " +
                           " sum(s.Desconto) as [TotalDesconto],  " +
                           " isnull(( select sum( convert(smallmoney, servico.total,2)) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 1 and s.servicoid = servico.servicoid),0) as [Dinheiro],   " +
                           " isnull(( select sum( convert(smallmoney, servico.total,2)) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 2 and s.servicoid = servico.servicoid),0)  as [VisaDebito],   " +
                           " isnull(( select sum( convert(smallmoney, servico.total,2)) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 3 and s.servicoid = servico.servicoid),0)  as [VisaCredito],  " +
                           " isnull(( select sum( convert(smallmoney, servico.total,2)) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 4 and s.servicoid = servico.servicoid),0) as [MasterDebito],  " +
                           " isnull(( select sum( convert(smallmoney, servico.total,2)) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 5 and s.servicoid = servico.servicoid),0)  as [MasterCredito] ,  " +
                           " isnull(sum(convert(smallmoney, su.valor,2)), 0) as Entrada, " +
                           " isnull(sum(convert(smallmoney, re.valor,2)), 0) as Saida, " +
                           " ((isnull(sum(convert(smallmoney, su.valor,2)), 0) + sum(convert(smallmoney,s.total,2))) - isnull(sum(convert(smallmoney, re.valor,2)), 0)) as SomaTotal " +
                           " from servico s   " +
                           " inner join usuarios u on s.usuarioid = u.usuarioid " +
                           " inner join suprimentos su on su.usuarioid = u.usuarioid  " +
                           " inner join retirada re on re.usuarioid = u.usuarioid  " +
                           " group by u.nome, s.ServicoID, s.entrada  " +
                           " ) as xx " +
                           " group by xx.nome,xx.Entrada, xx.Saida";


            DataTable table = new DataTable();
            table.Columns.AddRange(SetUpColumns());

            DataSet dataSet = util.GeraTabela(query);
            dataSet.Tables.Add(table);
            DataTableReader reader = dataSet.Tables[0].CreateDataReader();
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                row["Nome"] = reader.GetString(0);
                row["OSInicial"] = reader.GetInt32(1);
                row["OSFinal"] = reader.GetInt32(2);
                row["OSCancelado"] = reader.GetDecimal(3);
                row["TotalVendas"] = reader.GetInt32(4);
                row["TotalDesconto"] = reader.GetDecimal(5);
                row["Dinheiro"] = reader.GetDecimal(6);
                row["VisaDebito"] = reader.GetDecimal(7);
                row["VisaCredito"] = reader.GetDecimal(8);
                row["MasterDebito"] = reader.GetDecimal(9);
                row["MasterCredito"] = reader.GetDecimal(10);
                row["Entrada"] = reader.GetDecimal(11);
                row["Saida"] = reader.GetDecimal(12);

                table.Rows.Add(row);
            }
            return table;
        }

        private DataColumn[] SetUpColumns()
        {
            DataColumn[] columns = new DataColumn[13];

            DataColumn nome = new DataColumn();
            nome.ColumnName = "Nome";
            columns[0] = nome;

            DataColumn osInicial = new DataColumn();
            osInicial.ColumnName = "OSInicial";
            columns[1] = osInicial;

            DataColumn osFinal = new DataColumn();
            osFinal.ColumnName = "OSFinal";
            columns[2] = osFinal;

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

            return columns;
        }

    }
}
