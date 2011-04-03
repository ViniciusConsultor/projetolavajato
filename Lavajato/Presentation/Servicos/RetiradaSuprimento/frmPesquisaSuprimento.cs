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
    public partial class frmPesquisaSuprimento : Form
    {
        private SuprimentoBL suprimentoBL = new SuprimentoBL();

        public frmPesquisaSuprimento()
        {
            InitializeComponent();
        }

        private void frmPesquisaSuprimento_Load(object sender, EventArgs e)
        {
            grdRetirada.DataSource = suprimentoBL.ByDate(dateTimePicker1.Value);
            FormataGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            grdRetirada.DataSource = suprimentoBL.ByDate(dateTimePicker1.Value);
            FormataGrid();
        }

        private void FormataGrid()
        {
            grdRetirada.Columns[0].Visible = false;
            grdRetirada.Columns[1].Width = 60;
            grdRetirada.Columns[2].Width = 60;
            grdRetirada.Columns[3].Width = 240;
        }

        private void grdRetirada_DoubleClick(object sender, EventArgs e)
        {
            if (grdRetirada.CurrentRow == null)
                return;

            var index = grdRetirada.Rows[grdRetirada.CurrentRow.Index].Cells[0].Value;

            if (!string.IsNullOrEmpty(index.ToString()))
            {
                Suprimento suprimento = new Suprimento();
                suprimento.ID = int.Parse(index.ToString());
                suprimento = suprimentoBL.ByID(suprimento);

                frmSuprimentoEdicao frmServicoLavador = new frmSuprimentoEdicao(suprimento);
                frmServicoLavador.ShowDialog();
            }
            grdRetirada.DataSource = suprimentoBL.ByDate(dateTimePicker1.Value);
            FormataGrid();
        }
    }
}
