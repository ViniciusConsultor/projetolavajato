using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmProcuraServicoPorOS : Form
    {
        public frmProcuraServicoPorOS()
        {
            InitializeComponent();
        }

        private void ordemServico_TextChanged(object sender, EventArgs e)
        {
            var os = ordemServico.TextLength > 0 ? ordemServico.Text : "0";
            Servico servico = new Servico() { OrdemServico = Convert.ToInt32(os) };
            grdServicos.DataSource = new ServicoBL().GetOrdemServico(servico);
            OculdaColunaNoGrid();
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente() { Placa = placa.Text };
            grdServicos.DataSource = new ClienteBL().CriaTabelaOrdemServico(cliente);
            OculdaColunaNoGrid();
        }

        private void OculdaColunaNoGrid()
        {
            grdServicos.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdServicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = grdServicos.Rows[grdServicos.CurrentRow.Index].Cells[0].Value;

            if (!string.IsNullOrEmpty(index.ToString()))
            {
                Servico servico = new Servico() { ID = int.Parse(index.ToString()) };
                servico = new ServicoBL().ID(servico);
                frmServicoCancelado frmServicoLavador = new frmServicoCancelado(servico);
                frmServicoLavador.ShowDialog();
            }
        }

      
    }
}
