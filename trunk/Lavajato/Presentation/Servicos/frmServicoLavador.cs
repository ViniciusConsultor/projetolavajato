using System;
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
        private HenryCorporation.Lavajato.DomainModel.Produto _produto = new Produto();
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
            cmbServico.Focus();
        }

        private void frmServicoLavador_Load(object sender, EventArgs e)
        {
            CarregaProdutos();
            CarregaLavadores();
            CarregaServicoFuncionario();
            cmbServico.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!PodeAdicionar())
            {
                _servico.Usuario.ID = int.Parse(cmbLavador.SelectedValue.ToString());
                Produto produto = new Produto() { ID = int.Parse(cmbServico.SelectedValue.ToString()) };

                _servicoBL.FuncionarioNoServicoAdd(_servico, produto);
                CarregaServicoFuncionario();
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
                CarregaServicoFuncionario();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdServicoFuncionario.Rows.Count > 0)
            {
                var index = grdServicoFuncionario.Rows[Validador.RetornaValorSelecionadoNoGrid(grdServicoFuncionario.CurrentRow)].Cells[0].Value;
                _indexRowDelete = int.Parse((index == null || index.ToString().Length == 0 ? "0" : index.ToString()));
            }
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
