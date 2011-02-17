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
    public partial class frmClientePesquisaPorPlaca : Form
    {
        public frmClientePesquisaPorPlaca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (placa.TextLength == 0)
            {
                MessageBox.Show("Favor entrar com uma placa", "Atenção");
                return;
            }

            string placaPesquisa = placa.Text;
            frmClientesPorPlaca frmclientePesquisa = new frmClientesPorPlaca(placa.Text);
            frmclientePesquisa.ShowDialog();
        }
    }
}
