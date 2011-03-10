using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class Dinheiro
    {
        public static decimal Subtrai(string valor1, string valor2)
        {
            if(valor1.Length > 0 && valor2.Length >0)
            {
                var val1 = ConverteParaDecimal(valor1);
                var val2 = ConverteParaDecimal(valor2);
                return decimal.Subtract(val1, val2);
            }

            return 0;
        }

        public static string RetiraCifraoDaMoedaReal(decimal valor)
        {
            return valor.ToString("C").Replace("R$", "");
        }

        public static decimal RetiraCifraoDaMoedaReal(string valor)
        {
            if(valor.Length > 0)
            return decimal.Parse( valor.Replace("R$", ""));

            return 0;
        }


        public static decimal ConverteParaDecimal(string str)
        {
            str = str.Trim();
            return Convert.ToDecimal(str.Length > 0 ? str : "0");
        }
    }
}
