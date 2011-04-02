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
                new frmRelFechamentoCaixaPorData(this.dateInicial.Value, this.dateFinal.Value);
            porData.ShowDialog();
        }
    }
}
