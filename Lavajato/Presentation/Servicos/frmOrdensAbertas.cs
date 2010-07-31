using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmOrdensAbertas : Form
    {
        public frmOrdensAbertas()
        {
            InitializeComponent();
        }

        private void frmOrdensAbertas_Load(object sender, EventArgs e)
        {
            grdOrdensAbertas.DataSource = new ServicoBL().GetLavados(true);
        }
    }
}
