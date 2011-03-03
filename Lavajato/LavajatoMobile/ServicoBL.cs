using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using LavajatoMobile.WSLavajato;

namespace LavajatoMobile
{
    public static class ServicoBL
    {
        public static DataGridTableStyle SetUpStyleGrid(DataSet dst )
        {
            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = dst.Tables[0].TableName;

            DataGridColumnStyle id = new DataGridTextBoxColumn();
            id.MappingName = "ID";
            id.Width = -1;
            ts1.GridColumnStyles.Add(id);

            DataGridColumnStyle desc = new DataGridTextBoxColumn();
            desc.MappingName = "Descricao";
            desc.HeaderText = "Desc.";
            desc.Width = 75;
            ts1.GridColumnStyles.Add(desc);

            DataGridColumnStyle qtde = new DataGridTextBoxColumn();
            qtde.MappingName = "Quantidade";
            qtde.HeaderText = "Qt";
            qtde.Width = 22;
            ts1.GridColumnStyles.Add(qtde);

            DataGridColumnStyle val = new DataGridTextBoxColumn();
            val.MappingName = "Valor";
            val.HeaderText = "Valor";
            val.Width = 58;
            ts1.GridColumnStyles.Add(val);

            DataGridColumnStyle tot = new DataGridTextBoxColumn();
            tot.MappingName = "Total";
            tot.HeaderText = "Total";
            tot.Width = 58;
            ts1.GridColumnStyles.Add(tot);

            return ts1;
        }

        public static DataTable CriaGrid(Servico servico)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(ServicoColunas.CarregaColunasServico());

            foreach (ServicoItem si in servico.ServicoItem)
            {
                DataRow row = table.NewRow();
                row["ID"] = si.ID;
                row["Descricao"] = si.Produto.Descricao;
                row["Quantidade"] = si.Quantidade;
                row["Valor"] = si.Produto.ValorUnitario.ToString("C");
                row["Total"] = (si.Produto.ValorUnitario * si.Quantidade).ToString("C");
                table.Rows.Add(row);
            }

            return table;
        }

        public static DataGridTableStyle StyleGridCarrosLavados(DataTable table)
        {
            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = table.TableName;

            DataGridColumnStyle id = new DataGridTextBoxColumn();
            id.MappingName = "ID";
            id.Width = -1;
            ts1.GridColumnStyles.Add(id);

            DataGridColumnStyle OrdemServico = new DataGridTextBoxColumn();
            OrdemServico.MappingName = "O.S.";
            OrdemServico.HeaderText = "O.S.";
            OrdemServico.Width = 110;
            ts1.GridColumnStyles.Add(OrdemServico);

            DataGridColumnStyle Placa = new DataGridTextBoxColumn();
            Placa.MappingName = "Placa";
            Placa.HeaderText = "Placa";
            Placa.Width = 60;
            ts1.GridColumnStyles.Add(Placa);

            DataGridColumnStyle Lavado = new DataGridTextBoxColumn();
            Lavado.MappingName = "Lavado";
            Lavado.HeaderText = "Lavado";
            Lavado.Width = 80;
            ts1.GridColumnStyles.Add(Lavado);

            DataGridColumnStyle HoraPrevista = new DataGridTextBoxColumn();
            HoraPrevista.MappingName = "Hora Prevista de Saida";
            HoraPrevista.HeaderText = "Hora Saida";
            HoraPrevista.Width = 130;
            ts1.GridColumnStyles.Add(HoraPrevista);

            return ts1;
        }
    }
}
