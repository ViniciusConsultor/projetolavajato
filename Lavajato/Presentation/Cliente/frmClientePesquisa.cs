﻿using System;
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
            OculdaColuna();
        }
        private void placaPesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Cliente cliente = new HenryCorporation.Lavajato.DomainModel.Cliente();
            cliente.Placa = placaPesquisa.Text;
            grdClientes.DataSource = clienteBL.ByPlacas(cliente);
            OculdaColuna();
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Cliente cliente = new HenryCorporation.Lavajato.DomainModel.Cliente();
            cliente.Nome = nomePesquisa.Text;
            grdClientes.DataSource = clienteBL.ByName(cliente);
            OculdaColuna();
        }

        private void grdClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ID = int.Parse(grdClientes.Rows[grdClientes.CurrentRow.Index].Cells[0].Value.ToString());
            frmCliente frmCliente = new frmCliente(cliente);
            frmCliente.ShowDialog();
        }

        private void OculdaColuna()
        {
            grdClientes.Columns[0].Visible = false;
        }

        private void placaPesquisa_Enter(object sender, EventArgs e)
        {
            placaPesquisa.BackColor = Color.Yellow;
        }

        private void placaPesquisa_Leave(object sender, EventArgs e)
        {
            placaPesquisa.BackColor = Color.White;
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }
    }
}
