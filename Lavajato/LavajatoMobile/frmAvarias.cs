using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LavajatoMobile
{
    public partial class frmAvarias : Form
    {
        public static string Avarias = "";

        public frmAvarias()
        {
            InitializeComponent();
        }

        private void btnAvaria_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            string temp = "";
            if (!lblAvaria.Text.Contains(comboBox1.SelectedItem.ToString()))
                temp += comboBox1.SelectedItem.ToString();

            lblAvaria.Text += temp + " ";
            //int index =  lblAvaria.Text.IndexOf('-');
            //if (index > -1)
            //    lblAvaria.Text = lblAvaria.Text.Remove(index, 1);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Avarias = lblAvaria.Text;
            this.Close();
        }
    }
}