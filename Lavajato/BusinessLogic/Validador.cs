using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class Validador
    {
        public static int RetornaValorSelecionadoNoGrid(object obj)
        {
            return (obj == null ? 0 : ((DataGridViewRow)obj).Index);
        }
    }
}
