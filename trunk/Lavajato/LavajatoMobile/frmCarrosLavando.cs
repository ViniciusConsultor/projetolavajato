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
        WSLavajato.WebServiceLavajato wsLavajato = new LavajatoMobile.WSLavajato.WebServiceLavajato();

        public frmCarrosLavando()
        {
            InitializeComponent();

        }

        private void frmCarrosLavando_Load(object sender, EventArgs e)
        {
            DataTable table = wsLavajato.CarregaLavagens();
            grdServicos.DataSource = table;
            grdServicos.TableStyles.Clear();
            grdServicos.TableStyles.Add(ServicoBL.StyleGridCarrosLavados(table));
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            DataTable table = wsLavajato.CarregaLavagens();
            grdServicos.DataSource = table;
            grdServicos.TableStyles.Clear();
            grdServicos.TableStyles.Add(ServicoBL.StyleGridCarrosLavados(table));
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}