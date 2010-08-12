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

        private void grdOrdensAbertas_DoubleClick(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            servico.ID = int.Parse(grdOrdensAbertas.Rows[grdOrdensAbertas.CurrentRow.Index].Cells[0].Value.ToString());
            servico = new ServicoBL().ByID(servico);
            
            frmCaixa frmCaixa = new frmCaixa(servico);
            frmCaixa.ShowDialog();
        }
    }
}
