using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.Presentation;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmClientePesquisa : Form
    {
        private ClienteBL clienteBL = new ClienteBL();

        public frmClientePesquisa()
        {
            InitializeComponent();
            CarregaClientesCadastrados();
        }

        private void CarregaClientesCadastrados()
        {
            grdClientes.DataSource = clienteBL.GetAll();
        }
        private void placaPesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Cliente cliente = new HenryCorporation.Lavajato.DomainModel.Cliente();
            cliente.Placa = placaPesquisa.Text;
            grdClientes.DataSource = clienteBL.ByPlacas(cliente);
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Cliente cliente = new HenryCorporation.Lavajato.DomainModel.Cliente();
            cliente.Nome = nomePesquisa.Text;
            grdClientes.DataSource = clienteBL.ByName(cliente);
        }

        private void grdClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ID = int.Parse(grdClientes.Rows[grdClientes.CurrentRow.Index].Cells[0].Value.ToString());
            frmCliente frmCliente = new frmCliente(cliente);
            frmCliente.ShowDialog();
            this.Close();
        }
    }
}
