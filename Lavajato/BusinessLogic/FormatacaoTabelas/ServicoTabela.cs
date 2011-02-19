using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.DataAccess;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ServicoTabela
    {
        
        public static DataTable GetOrdemServico(Servico servico)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(ServicoColunas.CarregaColunasOrdemServico());

            DataRow row = table.NewRow();
            row["ID"] = servico.ID;
            row["Cliente"] = servico.Cliente.Nome;
            row["Placa"] = servico.Cliente.Placa;
            table.Rows.Add(row);

            return table;
        }

        public static DataTable GetLavados(IList<Servico> servicos)
        {
            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            dataSet.Tables.Add(table);
            table.Columns.AddRange(ServicoColunas.GetLavados());

            foreach (Servico serv in servicos)
            {
                // Declare DataColumn and DataRow variables.
                DataRow row = table.NewRow();
                row["ID"] = serv.ID;
                row["Cliente"] = serv.Cliente.Nome;
                row["Placa"] = serv.Cliente.Placa;
                row["Lavado"] = serv.Lavado == 0 ? "Não Lavado" : "Lavado";
                table.Rows.Add(row);
            }

            return table;
        }

        public static DataTable CriaGrid(Servico servico)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(ServicoColunas.CarregaColunasOrdemServico());

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

        public static DataTable CriaGridCarrosLavano(IList<Servico> servicos )
        {
            var dataSet = new DataSet();
            var table = new DataTable();
            dataSet.Tables.Add(table);
            table.Columns.AddRange(ServicoColunas.ColunasCarroLavando());

            foreach (Servico si in servicos)
            {
                DataRow row = table.NewRow();
                row["Placa"] = si.Cliente.Placa;
                row["Carro"] = si.Cliente.Veiculo;
                row["Saida"] = si.Saida.ToShortTimeString();
                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable GetServicoFuncionario(List<ServicoFuncionario> servicoFuncionarios)
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(ServicoColunas.GetColumns());

            foreach (ServicoFuncionario sf in servicoFuncionarios)
            {
                DataRow row = table.NewRow();
                row["ID"] = sf.ID;
                row["Servico"] = sf.Produto.Descricao;
                table.Rows.Add(row);
            }
            return table;
        }
        
    }
}
