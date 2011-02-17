using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmFechamentoCaixa : login
    {
        public frmFechamentoCaixa()
        {
            InitializeComponent();
        }

        private void frmFechamentoCaixa_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            frmRelatorioFechamentoDeCaixa frmFechamentoCaixa = new frmRelatorioFechamentoDeCaixa(this.Usuario.ID, Configuracao.HoraPtBR(this.dateTimePicker1.Value));
            frmFechamentoCaixa.ShowDialog();
        }
    }
}
