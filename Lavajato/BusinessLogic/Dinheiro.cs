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

        public static string RetiraCifraoDaMoedaReal(string valor)
        {
            if (valor.Length > 0)
                return valor.ToString().Replace("R$", "");

            return string.Empty;
        }

        public static decimal RetiraCifraoDaMoedaReal(decimal valor)
        {
            if(valor > 0)
                return  decimal.Parse( valor.ToString().Replace("R$", ""));

            return 0;
        }

        public static decimal ConverteParaDecimal(string str)
        {
            str = RetiraCifraoDaMoedaReal( str.Trim());
            return Convert.ToDecimal(str.Length > 0 ? str : "0");
        }
    }
}
