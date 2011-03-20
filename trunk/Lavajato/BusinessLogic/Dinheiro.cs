using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class Dinheiro
    {
        public static decimal Subtract(string valor1, string valor2)
        {
            if(valor1.Length > 0 && valor2.Length >0)
            {
                var val1 = ForDecimal(valor1);
                var val2 = ForDecimal(valor2);
                return decimal.Subtract(val1, val2);
            }

            return 0;
        }

        public static string Subtract(decimal valor1, decimal valor2)
        {
            if (valor1 > 0 && valor2 > 0)
            {
                var val1 = valor1;
                var val2 = valor2;
                return decimal.Subtract(val1, val2).ToString();
            }

            return "";
        }

        public static string WithdrawDollar(string valor)
        {
            if (valor.Length > 0)
                return valor.ToString().Replace("R$", "");

            return string.Empty;
        }

        public static string WithDollar(decimal valor)
        {
            if (valor > 0)
                return valor.ToString("C");

            return string.Empty;
        }

        public static decimal WithdrawDollar(decimal valor)
        {
            if(valor > 0)
                return  decimal.Parse( valor.ToString().Replace("R$", ""));

            return 0;
        }

        public static decimal ForDecimal(string str)
        {
            str = WithdrawDollar( str.Trim());
            return Convert.ToDecimal(str.Length > 0 ? str : "0");
        }
    }
}
