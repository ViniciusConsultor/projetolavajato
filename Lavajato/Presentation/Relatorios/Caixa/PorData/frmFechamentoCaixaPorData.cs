using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmFechamentoCaixaPorData : Form
    {
        public frmFechamentoCaixaPorData()
        {
            InitializeComponent();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmRelFechamentoCaixaPorData porData =
                new frmRelFechamentoCaixaPorData(ConvertDataFormatoPTBR(this.dateInicial.Value),
            ConvertDataFormatoPTBR(this.dateFinal.Value));
            porData.ShowDialog();
        }


        private static string ConvertDataFormatoPTBR(DateTime date)
        {
            string mes = date.Month.ToString().Length == 1 ? "0" + date.Month.ToString() : date.Month.ToString();
            string dia = date.Day.ToString().Length == 1 ? "0" + date.Day.ToString() : date.Day.ToString();
            string ano = date.Year.ToString();

            return dia + "/" + mes + "/" + ano;
        }
    }
}
