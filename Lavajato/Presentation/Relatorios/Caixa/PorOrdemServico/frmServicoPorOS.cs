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
    public partial class frmServicoPorOS : Form
    {
        public frmServicoPorOS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                relServicoPorOS relServicoPorOS = new relServicoPorOS( int.Parse(textBox1.Text));
                relServicoPorOS.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Favor colocar um numero de Ordem de Serviço", "Atenção!");
            }
        }
    }
}
