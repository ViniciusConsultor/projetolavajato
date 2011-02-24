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

using HenryCorporation.Lavajato.Presentation.Properties;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmServicoLavador : Form
    {
        private Servico _servico = new Servico();
        private Produto _produto = new Produto();
        private ServicoBL _servicoBL = new ServicoBL();
        private int _indexRowDelete;

        public frmServicoLavador()
        {
            InitializeComponent();

        }

        public frmServicoLavador(Servico servico)
        {
            InitializeComponent();
            _servico = servico;
        }

        private void frmServicoLavador_Load(object sender, EventArgs e)
        {
            CarregaProdutos();
            CarregaLavadores();
            CarregaServicoFuncionario();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!PodeAdicionar())
            {
                _servico.Usuario.ID = int.Parse(cmbLavador.SelectedValue.ToString());
                Produto produto = new Produto() { ID = int.Parse(cmbServico.SelectedValue.ToString()) };

                _servicoBL.FuncionarioNoServicoAdd(_servico, produto);
                CarregaServicoFuncionario();
                MessageBox.Show("Salvo com sucesso!", Resources.Atencao);
            }
            else
            {
                MessageBox.Show("Serviço já adicionado a um usuário!", Resources.Atencao);
            }
        }

        private bool PodeAdicionar()
        {
            DataTable table = _servicoBL.ServicoFuncionariosGet(_servico);
            foreach (DataRow row in table.Rows)
            {
                string ser = row["Servico"].ToString();
                if (ser == ((Produto)cmbServico.SelectedItem).Descricao)
                    return true;
            }
            return false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_indexRowDelete <= 0)
            {
                MessageBox.Show("Erro ao deletar registro", Resources.Atencao);
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir o item "+ _indexRowDelete + "?" , Resources.Atencao, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _servicoBL.ServicoFuncionarioDelete(_indexRowDelete);
                MessageBox.Show("Item excluido com sucesso?", Resources.Atencao);
                CarregaServicoFuncionario();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = 0;
            if (int.TryParse(grdServicoFuncionario.Rows[grdServicoFuncionario.CurrentRow.Index].Cells[0].Value.ToString(), out index))
                _indexRowDelete = index;
        }

        public void CarregaServicoFuncionario()
        {
            grdServicoFuncionario.DataSource = _servicoBL.ServicoFuncionariosGet(_servico);
        }

        private void CarregaProdutos()
        {
            IList<Produto> produtos = new List<Produto>();
            foreach (var item in _servico.ServicoItem)
            {
                if (item.Produto.CategoriaProduto.ID == 2)
                    produtos.Add(item.Produto);
            }
            
            cmbServico.DataSource = produtos;
            cmbServico.DisplayMember = "Descricao";
            cmbServico.ValueMember = "ID";
        }

        private void CarregaLavadores()
        {
            cmbLavador.DataSource = new UsuarioBL().GetUsuarioTipoLavador();
            cmbLavador.DisplayMember = "Nome";
            cmbLavador.ValueMember = "ID";
        }
    }
}
