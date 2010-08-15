using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Operacional
{
    public class Configuracao
    {
        public Configuracao()
        {

        }

        public static decimal ConverteParaDecimal(string valor)
        {
            if (valor.Length == 0)
                return 0;

            string strTemp = valor.Replace("R$", "");
            return Convert.ToDecimal(strTemp);
        }

        public static int ConverteParaInteiro(string valor)
        {
            string strTemp = valor.Replace("R$", "");
            return Convert.ToInt32(strTemp.Length > 0 ? strTemp : "0");
        }

        public static bool EInteiro(string valor, out int valorint)
        {
            string strTemp = valor;
            valorint = 0;
            bool i = int.TryParse(strTemp, out valorint);
            return i;
        }

        public static bool EDecimal(string valor, out decimal valorint)
        {
            string strTemp = valor;
            valorint = 0;
            bool i = decimal.TryParse(strTemp, out valorint);
            return i;
        }


        public static object[] CarregaHora()
        {
            object[] h = new object[24];
            int j = 0;
            for (int i = 1; i <= 24; i++)
            {
                h[j] = i;
                j++;
            }
            return h;
        }

        public static object[] CarregaMinuto()
        {
            object[] m = new object[7];
            int j = 0;
            for (int i = 0; i <= 60; i += 10)
            {
                m[j] = (i);
                j++;
            }
            return m;
        }

        public static string HoraEntrada(DateTime horaEntrada)
        {
            return horaEntrada.Year + "-" + horaEntrada.Month + "-" + horaEntrada.Day + " " + horaEntrada.Hour + ":" + horaEntrada.Minute + ":" + horaEntrada.Second;
        }

        public static string HoraSaida(DateTime horaSaida)
        {
            return horaSaida.Year + "-" + horaSaida.Month + "-" + horaSaida.Day + " " + horaSaida.Hour + ":" + horaSaida.Minute + ":" + horaSaida.Second;
        }

        public static string HoraPtBR(DateTime hora)
        {
            string dia = hora.Day.ToString().Length == 1 ? "0" + hora.Day.ToString() : hora.Day.ToString();
            string mes = hora.Month.ToString().Length == 1 ? "0" + hora.Month.ToString() : hora.Month.ToString();
            return dia + "/" + mes + "/" + hora.Year;
        }

        private Servico servico;
        private  PrintDocument recibo;
        public int EmiteRecibo(Servico servico)
        {
            this.servico = servico;
            if (this.servico.ID == 0)
                return 0;

            recibo = new PrintDocument();
            recibo.PrintPage += new PrintPageEventHandler(this.recibo_PrintPage);
            recibo.Print();

            return 1;
        }
        
        private void recibo_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string enter = "\n";
            Pen myPen = new Pen(Brushes.Black);
            Point pt1 = new Point(30, 53);
            Font myFont1 = new Font("Arial", 9);

            StringBuilder strCabecalho = new StringBuilder();
            strCabecalho.Append("LAVEVIP LAVAJATO" + enter);
            strCabecalho.Append("Rua da Bahia, 2244, Lourdes" + enter);
            strCabecalho.Append("Minas Tenis Clube-Piso 1" + enter);
            strCabecalho.Append("(31)xxxx-xxxx" + enter);
            strCabecalho.Append("----------------------------------------------" + enter);
            strCabecalho.Append("Placa: " + servico.Cliente.Placa + "  Veículo:" + servico.Cliente.Veiculo + "  Cor:" + servico.Cliente.Cor + "" + enter);
            strCabecalho.Append("Nome:  " + servico.Cliente.Nome + "      Fone:" + servico.Cliente.Telefone + "" + enter);
            strCabecalho.Append("Entrada:  " + servico.Entrada + "   Saida:" + servico.Saida.Hour.ToString() + "" + enter);
            strCabecalho.Append("----------------------------------------------" + enter);
            strCabecalho.Append("SERVICO             QTDE.     VALOR   TOTAL" + enter);

            string desc = "";
            foreach (var item in servico.ServicoItem)
            {
                if (item.Produto.Descricao.Length >= 16)
                {
                    desc = item.Produto.Descricao;
                }
                else
                {
                    for (int i = 0; i < 16 - item.Produto.Descricao.Length; i++)
                    {
                        desc += " ";
                    }
                }

                string qtde = item.Quantidade.ToString();
                string valUni = item.Produto.ValorUnitario.ToString("C").Replace("R$", "");
                string tot = (item.Produto.ValorUnitario * item.Quantidade).ToString("C").Replace("R$", "");
                strCabecalho.Append(desc + qtde + "       " + valUni + tot + enter);
            }

            ev.Graphics.DrawString(strCabecalho.ToString(), myFont1, Brushes.Black, 30, 30);
            ev.HasMorePages = false;
        }


    }
}
