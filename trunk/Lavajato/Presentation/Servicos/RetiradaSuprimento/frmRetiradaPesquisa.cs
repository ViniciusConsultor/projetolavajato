using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmRetiradaPesquisa : Form
    {
        RetiradaBL retiradaBL = new RetiradaBL();

        public frmRetiradaPesquisa()
        {
            InitializeComponent();
        }

        private void frmRetiradaEdicao_Load(object sender, EventArgs e)
        {
            grdRetirada.DataSource = retiradaBL.ByDate(dateTimePicker1.Value);
            FormataGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            grdRetirada.DataSource = retiradaBL.ByDate(dateTimePicker1.Value);
            FormataGrid();
        }

        private void grdRetirada_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grdRetirada.CurrentRow == null)
                return;

            var index = grdRetirada.Rows[grdRetirada.CurrentRow.Index].Cells[0].Value;

            if (!string.IsNullOrEmpty(index.ToString()))
            {
                Retirada retirada = new Retirada();
                retirada.ID = int.Parse(index.ToString());
                retirada = retiradaBL.ByID(retirada);

                frmRetiradaEdicao frmServicoLavador = new frmRetiradaEdicao(retirada);
                frmServicoLavador.ShowDialog();
            }
            
            grdRetirada.DataSource = retiradaBL.ByDate(dateTimePicker1.Value);
            FormataGrid();

        }

        private void FormataGrid()
        {
            grdRetirada.Columns[0].Visible = false;
            grdRetirada.Columns[1].Width = 60;
            grdRetirada.Columns[2].Width = 60;
            grdRetirada.Columns[3].Width = 240;
        }
    }
}
