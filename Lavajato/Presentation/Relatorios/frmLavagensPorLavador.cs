using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.Operacional;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmLavagensPorLavador : Form
    {
        public frmLavagensPorLavador()
        {
            InitializeComponent();
            CarregaLavadores();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            frmLavagemPorLavadorRelatorio rel = new frmLavagemPorLavadorRelatorio(dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(cmbLavador.SelectedValue.ToString()));
            rel.ShowDialog();
        }

        private void CarregaLavadores()
        {
            cmbLavador.DataSource = new UsuarioBL().GetUsuarioTipoLavador();
            cmbLavador.DisplayMember = "Nome";
            cmbLavador.ValueMember = "ID";
        }
    }
}
