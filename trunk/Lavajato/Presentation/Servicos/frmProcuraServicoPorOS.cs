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


        /// <summary>
        /// Procura uma ordem de serviço com base na data e numero da ordem de serviço
        /// </summary>
        private void ordemServico_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ordemServico.Text) )
                return;

            if( Dinheiro.ParseToInt(ordemServico.Text))
            {
                Servico servico = new Servico();
                servico.OrdemServico = Convert.ToInt32(ordemServico.Text);
                servico.Entrada = entrada.Value;

                grdServicos.DataSource = new ServicoBL().GetOrdemServico(servico);
                FormatGrid();
            }
            else
            {
                MessageBox.Show("Favor digitar somente numeros!", "Atenção");
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
                FormatGrid();
            }
        }

        private void FormatGrid()
        {
            if (grdServicos.Rows.Count > 0)
            {
                grdServicos.Columns[0].Visible = false;
                grdServicos.Columns[1].Width = 150;
                grdServicos.Columns[2].Width = 80;
                grdServicos.Columns[3].Width = 160;
            }
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
                Servico servico = new Servico();
                servico.ID = int.Parse(index.ToString());

                servico = new ServicoBL().ByID(servico);

                frmServicoCancelado frmServicoLavador = new frmServicoCancelado(servico);
                frmServicoLavador.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario sem permissões para completar a operação!", "Atenção");
            }
        }

        private void entrada_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ordemServico.Text))
            {
                if (Dinheiro.ParseToInt(ordemServico.Text))
                {
                    Servico servico = new Servico();
                    servico.OrdemServico = Convert.ToInt32(ordemServico.Text);
                    servico.Entrada = entrada.Value;

                    grdServicos.DataSource = new ServicoBL().GetOrdemServico(servico);
                    FormatGrid();
                }
                else
                {
                    MessageBox.Show("Favor digitar somente numeros!", "Atenção");
                }
            }
            else if (!string.IsNullOrEmpty(placa.Text))
            {
                Servico servico = new Servico();
                servico.Cliente.Placa = placa.Text;
                servico.Entrada = entrada.Value;

                grdServicos.DataSource = new ClienteBL().GetOrdensServico(servico);
                FormatGrid();
            }

        }
    }
}
