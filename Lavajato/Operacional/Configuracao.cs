using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HenryCorporation.Lavajato.Operacional
{
    public static class Configuracao
    {
        static Configuracao()
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


    }
}
