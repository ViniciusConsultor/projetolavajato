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

        #region Metodos Casas Decimais e Inteiros

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

        #endregion

        #region Trabalha com hora e dada

        public static object[] CarregaHora()
        {
            object[] h = new object[25];
            int j = 0;
            for (int i = 0; i <= 24; i++)
            {
                h[j] = i;
                j++;
            }
            return h;
        }

        public static object[] CarregaMinuto()
        {
            object[] m = new object[13];
            int j = 0;
            for (int i = 0; i <= 60; i += 5)
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

        #endregion

        #region Impressão Palm

        private Servico servico;
        private  PrintDocument recibo;
        private string avarias;
        public int EmiteRecibo(Servico servico, string avarias)
        {
            this.servico =  servico;
            this.avarias = avarias;
            if (this.servico.ID == 0)
                return 0;

            recibo = new PrintDocument();
            recibo.PrintPage += new PrintPageEventHandler(this.recibo_PrintPage);
            recibo.Print();

            return 1;
        }
        
        private void recibo_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string[] avariasTemp = null;
            if (avarias.Length > 0)
                avariasTemp = avarias.Split(new string[] { " " }, StringSplitOptions.None);

            string enter = "\n";
            Pen myPen = new Pen(Brushes.Black);
            Point pt1 = new Point(30, 53);
            Font myFont1 = new Font("Arial", 9);

            string hora = servico.Entrada.Hour.ToString().Length == 1 ? "0" + servico.Entrada.Hour.ToString() : servico.Entrada.Hour.ToString();
            string minuto =  servico.Entrada.Minute.ToString().Length == 1 ? "0" + servico.Entrada.Minute.ToString() : servico.Entrada.Minute.ToString();
            string entrada =  servico.Entrada.ToShortDateString()+ " " + hora+":"+minuto;
            decimal somaTotal = 0;
            StringBuilder strCabecalho = new StringBuilder();
            
            strCabecalho.Append("---------------------------------------------------------" + enter);
            strCabecalho.Append("Nº: " + this.servico.OrdemServico + enter);
            strCabecalho.Append("Placa: " + servico.Cliente.Placa + "  Veículo:" + servico.Cliente.Veiculo + "  Cor:" + servico.Cliente.Cor + "" + enter);
            strCabecalho.Append("Nome:  " + servico.Cliente.Nome + "      Fone:" + servico.Cliente.Telefone + "" + enter);
            strCabecalho.Append("Entrada:  " + entrada + "   Saida:" + servico.Saida.Hour + ":" + servico.Saida.Second + "" + enter);
            strCabecalho.Append("---------------------------------------------------------" + enter);
            strCabecalho.Append("SERVICO             QTDE.     VALOR   TOTAL" + enter);

            string desc = "";
            foreach (var item in servico.ServicoItem)
            {
                if (item.Produto.Descricao.Length > 16)
                {
                    desc = item.Produto.Descricao.Remove(16);
                }
                else if (item.Produto.Descricao.Length == 16)
                { 
                
                }
                else
                {
                    desc = item.Produto.Descricao;
                    for (int i = 0; i < 17 - item.Produto.Descricao.Length; i++)
                    {
                        desc += "  ";
                    }
                } 

                string qtde = item.Quantidade.ToString();
                string valUni = item.Produto.ValorUnitario.ToString("C").Replace("R$", "");
                string tot = (item.Produto.ValorUnitario * item.Quantidade).ToString("C").Replace("R$", "");
                somaTotal += Configuracao.ConverteParaDecimal(tot);

                if (valUni.Length == 5)
                    valUni = "              " + valUni;
                else if (valUni.Length == 4)
                    valUni = "              " + valUni;
                else if (valUni.Length == 6)
                    valUni = "              " + valUni;

                if (tot.Length == 5)
                    tot = "    " + tot;
                else if (tot.Length == 4)
                    tot = "      " + tot;
                else if (tot.Length == 6)
                    tot = "   " + tot;

                strCabecalho.Append(desc  + qtde  + valUni + tot + enter);
                
            }
            strCabecalho.Append("                                       Valor Total: " + somaTotal + enter);
            strCabecalho.Append("---------------------------------------------------------" + enter);
            strCabecalho.Append("Avarias: " + enter);
            if (avariasTemp != null)
            {
                for (int i = 0; i < avariasTemp.Length; i++)
                    strCabecalho.Append(avariasTemp[i] + " ");
            }

            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);

            strCabecalho.Append("LAVEVIP - Estetica Automotiva "+enter);
            strCabecalho.Append("Av. Pres. Carlos Luz, 3001, Caiçara" + enter);
            strCabecalho.Append("Area QVip1 2ºP" + enter);
            strCabecalho.Append("               LAVEVIP" + enter);
            strCabecalho.Append("O melhor amigo do seu veiculo" + enter);
            strCabecalho.Append("(31)3415-8085" + enter);
            strCabecalho.Append("(31)9208-9977" + enter);

            ev.Graphics.DrawString(strCabecalho.ToString(), myFont1, Brushes.Black, 30, 30);
            ev.HasMorePages = false;
        }

        #endregion

        #region PC

        private Servico servicoPC;
        private PrintDocument reciboPC;
        public int EmiteReciboPC(Servico servicoPC)
        {
            this.servicoPC = servicoPC;
            if (this.servicoPC.ID == 0)
                return 0;

            reciboPC = new PrintDocument();
            reciboPC.PrintPage += new PrintPageEventHandler(this.recibo_PrintPagePC);
            reciboPC.Print();

            return 1;
        }
        private void recibo_PrintPagePC(object sender, PrintPageEventArgs ev)
        {
            string enter = "\n";
            Pen myPen = new Pen(Brushes.Black);
            Point pt1 = new Point(30, 53);
            Font myFont1 = new Font("Arial", 9);


            string hora = servicoPC.Entrada.Hour.ToString().Length == 1 ? "0" + servicoPC.Entrada.Hour.ToString() : servicoPC.Entrada.Hour.ToString();

            string minuto = servicoPC.Entrada.Minute.ToString().Length == 1 ? "0" + servicoPC.Entrada.Minute.ToString() : servicoPC.Entrada.Minute.ToString();
            string entrada = servicoPC.Entrada.ToShortDateString() + " " + hora + ":" + minuto;
            decimal somaTotal = 0;
            StringBuilder strCabecalho = new StringBuilder();

            strCabecalho.Append("--------------------------------------------------" + enter);
            strCabecalho.Append("Nº: " + this.servico.OrdemServico + enter);
            strCabecalho.Append("Placa: " + servicoPC.Cliente.Placa + "  Veículo:" + servicoPC.Cliente.Veiculo + "  Cor:" + servicoPC.Cliente.Cor + "" + enter);
            strCabecalho.Append("Nome:  " + servicoPC.Cliente.Nome + "      Fone:" + servicoPC.Cliente.Telefone + "" + enter);
            strCabecalho.Append("Entrada:  " + entrada + "   Saida:" + servicoPC.Saida.Hour + ":" + servicoPC.Saida.Second + "" + enter);
            strCabecalho.Append("--------------------------------------------------" + enter);
            strCabecalho.Append("SERVICO             QTDE.     VALOR   TOTAL" + enter);

            string desc = "";
            foreach (var item in servicoPC.ServicoItem)
            {
                if (item.Produto.Descricao.Length > 16)
                {
                    desc = item.Produto.Descricao.Remove(16);
                }
                else if (item.Produto.Descricao.Length == 16)
                {

                }
                else
                {
                    desc = item.Produto.Descricao;
                    for (int i = 0; i < 17 - item.Produto.Descricao.Length; i++)
                    {
                        desc += "  ";
                    }
                }

                string qtde = item.Quantidade.ToString();
                string valUni = item.Produto.ValorUnitario.ToString("C").Replace("R$", "");
                string tot = (item.Produto.ValorUnitario * item.Quantidade).ToString("C").Replace("R$", "");
                somaTotal += Configuracao.ConverteParaDecimal(tot);

                if (valUni.Length == 5)
                    valUni = "              " + valUni;
                else if (valUni.Length == 4)
                    valUni = "              " + valUni;
                else if (valUni.Length == 6)
                    valUni = "              " + valUni;

                if (tot.Length == 5)
                    tot = "    " + tot;
                else if (tot.Length == 4)
                    tot = "      " + tot;
                else if (tot.Length == 6)
                    tot = "   " + tot;

                strCabecalho.Append(desc + qtde + valUni + tot + enter);

            }
            strCabecalho.Append("                                           Valor Total: " + somaTotal);
            //Image newImage = Image.FromFile("carro.jpg");
            //ev.Graphics.DrawImage(newImage, -20, ev.PageSettings.PrinterSettings.PaperSizes);

            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);
            strCabecalho.Append(enter);

            strCabecalho.Append("LAVEVIP - Estetica Automotiva " + enter);
            strCabecalho.Append("Av. Pres. Carlos Luz, 3001, Caiçara" + enter);
            strCabecalho.Append("Area QVip1 2ºP" + enter);
            strCabecalho.Append("               LAVEVIP" + enter);
            strCabecalho.Append("O melhor amigo do seu veiculo" + enter);
            strCabecalho.Append("(31)3415-8085" + enter);
            strCabecalho.Append("(31)9208-9977" + enter);

            ev.Graphics.DrawString(strCabecalho.ToString(), myFont1, Brushes.Black, 30, 30);
            ev.HasMorePages = false;
        }

        #endregion
    }
}
