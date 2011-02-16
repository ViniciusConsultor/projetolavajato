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
    public partial class frmVendasDiarias : Form
    {
        public frmVendasDiarias()
        {
            InitializeComponent();
        }

        private void frmVendasDiarias_Load(object sender, EventArgs e)
        {

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioDeVendas frmRelatorio = new frmRelatorioDeVendas(dateTimePicker1.Value);
            frmRelatorio.ShowDialog();
        }
    }
}
