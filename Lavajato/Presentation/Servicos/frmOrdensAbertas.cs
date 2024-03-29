﻿using System;
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
            CarregaLavagens();
            FormataGrid();
        }

        private void grdOrdensAbertas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Servico servico = new Servico();
            var index = grdOrdensAbertas.Rows[grdOrdensAbertas.CurrentRow.Index].Cells[0].Value.ToString();
            index = index.Length > 0 ? index : "0"; 
                        
            servico.ID = int.Parse(index);
            servico = new ServicoBL().ByID(servico);

            if (servico.ID > 0)
            {
                frmCaixa frmCaixa = new frmCaixa(servico);
                frmCaixa.ShowDialog();
                CarregaLavagens();
                FormataGrid();
            }
            else
            {
                MessageBox.Show("Erro: Código incorreto", "Atenção");
            }
        }

        private void CarregaLavagens()
        {
            grdOrdensAbertas.DataSource = new ServicoBL().GetCarrosNoLavajatoByDate(dateTimePicker.Value);
        }

        private void btnAtualizaListagem_Click(object sender, EventArgs e)
        {
            CarregaLavagens();
            FormataGrid();
        }

        private void FormataGrid()
        {
            grdOrdensAbertas.Columns[0].Visible = false;
            grdOrdensAbertas.Columns[1].Width = 150;
            grdOrdensAbertas.Columns[4].Width = 200;
        }
    }
}
