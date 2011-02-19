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
    public partial class frmProcuraServicoPorPlaca : Form
    {
        public frmProcuraServicoPorPlaca()
        {
            InitializeComponent();
        }

        private void frmProcuraServicoPorPlaca_Load(object sender, EventArgs e)
        {

        }

        private void ordemServico_TextChanged(object sender, EventArgs e)
        {
            if (ordemServico.TextLength > 0)
            {
                Servico servico = new Servico() { OrdemServico = Convert.ToInt32(ordemServico.Text) };
                grdServicos.DataSource = new ServicoBL().GetOrdemServico(servico);
                OculdaColunaNoGrid();
            }
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            if (placa.TextLength > 0)
            {
                Cliente cliente = new Cliente() { Placa = placa.Text };
                grdServicos.DataSource = new ClienteBL().CriaTabelaOrdemServico(cliente);
                OculdaColunaNoGrid();
            }
        }

        private void grdServicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Servico servico = new Servico();
            servico.ID = int.Parse(grdServicos.Rows[grdServicos.CurrentRow.Index].Cells[0].Value.ToString());
            frmServicoLavador frmServicoLavador = new frmServicoLavador(servico);
            frmServicoLavador.ShowDialog();
            this.Visible = true;
        }

        private void OculdaColunaNoGrid()
        {
            grdServicos.Columns[0].Visible = false;
        }
    }
}
