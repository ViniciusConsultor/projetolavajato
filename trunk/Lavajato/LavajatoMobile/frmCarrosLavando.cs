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
    public partial class frmCarrosLavando : Form
    {
        WSLavajato.Service wsLavajato = new LavajatoMobile.WSLavajato.Service();

        public frmCarrosLavando()
        {
            InitializeComponent();
        }

        private void frmCarrosLavando_Load(object sender, EventArgs e)
        {
            dataGrid1.DataSource = wsLavajato.CriaGridCarrosLavano();
        }
    }
}