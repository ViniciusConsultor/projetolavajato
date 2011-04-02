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
            if (!string.IsNullOrEmpty(ordemServico.Text))
            {

                if (Dinheiro.ParseToInt(ordemServico.Text))
                {
                    Servico servico = new Servico();
                    servico.OrdemServico = Convert.ToInt32(ordemServico.Text);
                    servico.Entrada = entrada.Value;

                    grdServicos.DataSource = new ServicoBL().GetOrdemServico(servico);
                    OculdaColunaNoGrid();
                }
            }
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(placa.Text))
            {
                Servico servico = new Servico();
                servico.Cliente.Placa = placa.Text;
                servico.Entrada = entrada.Value;

                grdServicos.DataSource = new ClienteBL().GetOrdensServico(servico);
                OculdaColunaNoGrid();
            }
        }

        private void grdServicos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grdServicos.CurrentRow == null)
                return;

            var index = grdServicos.Rows[grdServicos.CurrentRow.Index].Cells[0].Value;
        
            if (!string.IsNullOrEmpty(index.ToString()))
            {
                Servico servico = new Servico();
                servico.ID = int.Parse(index.ToString());
                servico = new ServicoBL().ByID(servico);

                frmServicoLavador frmServicoLavador = new frmServicoLavador(servico);
                frmServicoLavador.ShowDialog();
            }
        }

        private void OculdaColunaNoGrid()
        {
            if (grdServicos.Rows.Count > 0)
            {
                grdServicos.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
