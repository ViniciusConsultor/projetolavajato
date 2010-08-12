using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LavajatoMobile
{
    public class Configuracao
    {
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
    }
}
