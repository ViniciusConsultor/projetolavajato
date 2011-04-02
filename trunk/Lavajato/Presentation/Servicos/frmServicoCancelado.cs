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
        private ServicoBL _servicoBL = new ServicoBL();

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

        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void chkCancelar_Click(object sender, EventArgs e)
        {
            if (chkCancelar.Checked)
            {
                frmCancelaOrdemServico frmCancelaServico = new frmCancelaOrdemServico();
                frmCancelaServico.ShowDialog();

                if (frmCancelaServico.txtLogin.TextLength > 0 &&
                    frmCancelaServico.txtPassword.TextLength > 0)
                {
                    if (frmCancelaServico.User.ID > 0 &&
                        frmCancelaServico.User.TipoFuncionario.Descricao == "Gerente")
                    {
                        _serviço.Cancelado = chkCancelar.Checked ? 1 : 0;
                        _serviço.Usuario = frmCancelaServico.User;

                        _servicoBL.Cancela(_serviço);
                        MessageBox.Show(Resources.Venda_cancelada, Resources.Atencao);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário sem permissão", "Atenção");
                        chkCancelar.Checked = false;
                    }
                }
                else
                {
                    chkCancelar.Checked = false;
                }
            }
        }

      
    }
}
