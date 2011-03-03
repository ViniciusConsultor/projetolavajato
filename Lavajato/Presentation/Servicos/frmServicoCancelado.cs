using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Presentation.Properties;
using HenryCorporation.Lavajato.BusinessLogic;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmServicoCancelado : login
    {
        private Servico _serviço;
        public frmServicoCancelado(Servico servico)
        {
            InitializeComponent();
            _serviço = servico;
            CarregaServico();
        }

        private void CarregaServico()
        {
            lblOrdemServico.Text = _serviço.OrdemServico.ToString();
            lblTotal.Text = _serviço.Total.ToString("C");
            lblData.Text = _serviço.Entrada.ToShortDateString();
            int i =1;
            StringBuilder servicos = new StringBuilder();
            foreach (ServicoItem si in _serviço.ServicoItem)
                lblServicos.Items.Add((i++) + "º" + " " + si.Produto.Descricao);

            lblServicos.Text = servicos.ToString();
        }

        public frmServicoCancelado()
        {
            InitializeComponent();
        }

        private void chkCancelar_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja Cancelar a O.S.", "Atenção!",
                MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                _serviço.Cancelado = 1;
                _serviço.Usuario = this.Usuario;

                new ServicoBL().Update(_serviço);
                MessageBox.Show(Resources.Venda_cancelada, Resources.Atencao);
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
