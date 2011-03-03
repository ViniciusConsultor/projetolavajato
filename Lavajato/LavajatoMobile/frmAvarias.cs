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
        private int _indexRemove;

        public frmAvarias()
        {
            InitializeComponent();
            //metodo para carregar avarias carro exista
        }

        private void btnAvaria_Click(object sender, EventArgs e)
        {
            if (cmbAvarias.SelectedItem == null)
                return;

            lstAvarias.Items.Add(cmbAvarias.SelectedItem.ToString());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            GetAvarias(lstAvarias);
            this.Close();
            
        }

        public static ListBox GetAvarias(ListBox avarias)
        {
            return avarias.Items.Count > 0 ? avarias : new ListBox();
        }

        private void lstAvarias_SelectedIndexChanged(object sender, EventArgs e)
        {
            _indexRemove = lstAvarias.SelectedIndex;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                lstAvarias.Items.RemoveAt(_indexRemove);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Favor escolher uma avaria válida para remoção", "Atenção!");
            }
        }
    }
}