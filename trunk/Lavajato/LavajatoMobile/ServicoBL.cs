using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using LavajatoMobile.WSLavajato;
using System.Windows;


namespace LavajatoMobile
{
    public static class ServicoBL
    {
        private static WSLavajato.WebServiceLavajato wsService = new LavajatoMobile.WSLavajato.WebServiceLavajato();

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
            OrdemServico.MappingName = "Ordem Servico";
            OrdemServico.HeaderText = "O.S.";
            OrdemServico.Width = 30;
            ts1.GridColumnStyles.Add(OrdemServico);

            DataGridColumnStyle Placa = new DataGridTextBoxColumn();
            Placa.MappingName = "Placa";
            Placa.HeaderText = "Placa";
            Placa.Width = 60;
            ts1.GridColumnStyles.Add(Placa);

            DataGridColumnStyle Lavado = new DataGridTextBoxColumn();
            Lavado.MappingName = "Lavado";
            Lavado.HeaderText = "Lavado";
            Lavado.Width = 75;
            ts1.GridColumnStyles.Add(Lavado);

            DataGridColumnStyle HoraPrevista = new DataGridTextBoxColumn();
            HoraPrevista.MappingName = "Hora Prevista de Saida";
            HoraPrevista.HeaderText = "H. Saida";
            HoraPrevista.Width = 135;
            ts1.GridColumnStyles.Add(HoraPrevista);

            return ts1;
        }

        public static bool PlacaValida(string placa)
        {
            if (placa.Length == 0)
                return false;

            if (placa.Length > 8)
            {
                MessageBox.Show("Placa deve conter 7 digitos", "Atenção");
                return false;
            }

            return true;
        }

        public static string PlacaFormata(string placa)
        {
            string placaBackup = placa;

            int index = placaBackup.IndexOfAny(new char[] { '-', '.', ',', '_' });
            if (index > -1)
                placaBackup = placaBackup.Remove(index, 1);

            if (placaBackup.Length > 7)
                placaBackup = placaBackup.Remove(7, placaBackup.Length - 7);

            string letras = "";
            string numeros = "";

            if (placaBackup.Length >= 3)
                letras = placaBackup.Substring(0, 3);

            if (placaBackup.Length > 3 && placaBackup.Length >= 7)
                numeros = placaBackup.Substring(3, placaBackup.Length - 3);

            if (numeros.Length > 0)
                placa = letras + "-" + numeros;
            else
                placa = placaBackup.ToUpper();

            return placa;
        }

        /// <summary>
        /// Seta hora que o carro está ficara pronto no lavajato
        /// </summary>
        /// <returns>Retorana DateTime com hora de saida</returns>
        public static DateTime SetHoraMinutoDeSaidaDoCarro(string hora, string minuto)
        {
            var h = ((hora == null || hora.Length == 0) ? "0" : hora);
            var m = ((minuto == null || minuto.Length == 0) ? "0" : minuto);

            return DateTime.Now
                .AddHours(double.Parse(h))
                .AddMinutes(double.Parse(m));
        }

        /// <summary>
        /// Verifica se hora e minutos são validos, caso ambos estejão desmarcados será
        /// retornado gero.
        /// </summary>
        /// <returns>Returna true se hora for válida</returns>
        public static bool HoraMinutoValidos(string hora, string minutos)
        {
            double m = double.Parse((minutos == null||minutos.Length == 0) ? "0" : minutos);
            double h = double.Parse((hora == null || hora.Length == 0) ? "0" : hora);
            return (m == 0 && h == 0);
        }

        /// <summary>
        /// Caso caso já esteja finalizado será retornado um novo serviço! Caso contrario
        /// retorna o serviço atual
        /// </summary>
        /// <param name="servico">Recebe serviço com parametro</param>
        /// <returns>Retorna Serviço</returns>
        public static Servico ServicoCarrega(Servico servico)
        {
            servico = wsService.ServicoByID(servico);
            if (servico.Finalizado == 0)
                return servico;
            else
                return new Servico();
        }

        /// <summary>
        /// Caso caso já esteja finalizado será retornado um novo serviço! Caso contrario
        /// retorna o serviço atual
        /// </summary>
        /// <param name="Cliente">Cliente</param>
        /// <returns>Retorna Serviço</returns>
        public static Servico ServicoCarrega(Cliente cliente)
        {
            Servico servico = wsService.ByCliente(cliente);
            if (servico.Finalizado == 0)
                return servico;
            else
                return new Servico();
        }

        public static void ImprimeNumeroOrdemServico(Servico _servico)
        {
            if (_servico.Finalizado == 0 && _servico.ID > 0)
                MessageBox.Show("Número da Ordem Serviço: " + _servico.OrdemServico, "Atenção");
        }

        public static void ImprimeMensagemParaCarroJaLavado(Servico _servico)
        {
            if (_servico.Lavado > 0)
                MessageBox.Show("Carro já lavado", "Atenção");
        }

        public static void ImpressaoDeRecibo(Servico _servico)
        {
            wsService.EmiteRecibo(_servico, "");

            DialogResult result = MessageBox.Show("Deseja Imprimir outra copia?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                wsService.EmiteRecibo(_servico, "");

        }

        public static Servico ServicoSalva(Servico servico)
        {
            if (servico.ID == 0)
                return wsService.ServicoAdd(NovoServico(servico));
            else
            {
                wsService.ServicoUpdate(servico);
                return servico;
            }
        }

        private static Servico NovoServico(Servico servico)
        {
            Servico servicoSalva = new Servico();
            servicoSalva.Cliente = servico.Cliente;
            servicoSalva.Total = servico.Total;
            servicoSalva.SubTotal = servico.Total;
            servicoSalva.Desconto = 0;
            servicoSalva.Entrada = DateTime.Now;

            servicoSalva.Saida = servico.Saida;

            servicoSalva.FormaPagamento = new FormaPagamento();
            servicoSalva.FormaPagamento.ID = 1;

            servicoSalva.Usuario = new Usuario();
            servicoSalva.Usuario.ID = 26;

            servicoSalva.Cancelado = 0;
            servicoSalva.Delete = 0;
            servicoSalva.Finalizado = 0;
            servicoSalva.Lavado = 0;

            return servicoSalva;
        }


    }
}
