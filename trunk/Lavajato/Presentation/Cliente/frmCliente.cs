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

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmCliente : Form
    {

        private ClienteBL clienteBL = new ClienteBL();
        private Cliente cliente = new Cliente();
        
        public frmCliente()
        {
            InitializeComponent();
        }

        public frmCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.cliente = ProcuraCliente(this.cliente);
            CarregaCampos(this.cliente);
            tabClientes.SelectedTab = tabManutencao;
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregaClientesCadastrados();
            CarregaConvenioDosClientes();
        }

        private void CarregaConvenioDosClientes()
        {
            ConvenioBL convenioBL = new ConvenioBL();
            convenio.DataSource = convenioBL.GetAll();
            convenio.DisplayMember = "Nome";
            convenio.ValueMember = "ID";

        }

        private void CarregaClientesCadastrados()
        {
            grdClientes.DataSource = clienteBL.GetAll();
            grdClientes.Columns[0].Visible = false;
        }

        private void placaPesquisa_TextChanged(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Placa = placaPesquisa.Text;
            grdClientes.DataSource = clienteBL.ByPlacas(cliente);
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nomePesquisa.Text;
            grdClientes.DataSource = clienteBL.ByName (cliente);
        }

        private void grdClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.cliente.ID = int.Parse(grdClientes.Rows[grdClientes.CurrentRow.Index].Cells[0].Value.ToString());
            this.cliente = ProcuraCliente(this.cliente);
            CarregaCampos(this.cliente);
            tabClientes.SelectedTab = tabManutencao;
        }

        private void CarregaCampos(Cliente cliente)
        {
            placa.Text = cliente.Placa;
            cor.Text = cliente.Cor;
            veiculo.Text = cliente.Veiculo;

            nome.Text = cliente.Nome;
            endereco.Text = cliente.Endereco;
            numero.Text = cliente.Numero;
            uf.SelectedItem = cliente.UF.Length > 0 ? cliente.UF : "MG";
            cep.Text = cliente.Cep;
            bairro.Text = cliente.Bairro;
            fone.Text = cliente.Telefone;
            celular.Text = cliente.Celular;
            convenio.SelectedValue = cliente.Convenio.ID;
        }

        private Cliente ProcuraCliente(Cliente cliente)
        {
            return clienteBL.ByID(cliente);
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
            btnNovo.Enabled = false;
            RetornaFocoParaPlaca();
        }

        private void LimpaCampos()
        {
            placa.Text = "";
            cor.Text = "";
            veiculo.Text = "";

            nome.Text = "";
            endereco.Text = "";
            numero.Text = "";
            uf.SelectedValue = "";
            cep.Text = "";
            bairro.Text = "";
            fone.Text = "";
            celular.Text = "";
            this.cliente = new HenryCorporation.Lavajato.DomainModel.Cliente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.cliente.ID == 0)
            {
                MessageBox.Show("Nenhum Cliente encontrado", "Atenção");
                return;
            }

            CarregaCliente();
            clienteBL.Update(cliente);
            CarregaClientesCadastrados();
            MessageBox.Show("Cliente alterado com sucesso", "Atenção");
            RetornaFocoParaPlaca();
        }

        private void CarregaCliente()
        {
            cliente.Placa = placa.Text;
            cliente.Cor = cor.Text;
            cliente.Veiculo = veiculo.Text;

            cliente.Nome = nome.Text;
            cliente.Endereco = endereco.Text;
            cliente.Numero = numero.Text;
            cliente.UF = uf.SelectedItem.ToString().Length > 0 ? uf.SelectedItem.ToString() : "MG";
            cliente.Cep = cep.Text;
            cliente.Bairro = bairro.Text;
            cliente.Telefone = fone.Text;
            cliente.Celular = celular.Text;
            cliente.Convenio = this.convenio.SelectedIndex > 0 ? new ConvenioBL().ByID(Convert.ToInt32(this.convenio.SelectedValue.ToString())) : new Convenio() { ID=0};
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (placa.Text.Length == 0 && veiculo.Text.Length == 0 && nome.Text.Length == 0 || cor.Text.Length == 0)
            {
                MessageBox.Show("Favor preencher todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            CarregaCliente();
            clienteBL.Insert(cliente);
            this.cliente = clienteBL.ByPlaca(cliente);
            btnNovo.Enabled = true;
            CarregaClientesCadastrados();
            MessageBox.Show("Cliente salvo com sucesso!", "Atenção");
            RetornaFocoParaPlaca();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.cliente.ID == 0)
            {
                MessageBox.Show("Favor escolher um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Deseja realmente apagar o cliente?", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            clienteBL.Delete(this.cliente);
            MessageBox.Show("Cliente deletado com sucesso!", "Atenção");
            CarregaClientesCadastrados();
            LimpaCampos();
            RetornaFocoParaPlaca();
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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placa_Enter(object sender, EventArgs e)
        {
            placa.BackColor = Color.Yellow;
        }

        private void placa_Leave(object sender, EventArgs e)
        {
            placa.BackColor = Color.White;
        }

        private bool ValidaCampos(string p)
        {
            if (p.Length > 0)
                return true;
            return false;
        }

        private void cor_Enter(object sender, EventArgs e)
        {
            cor.BackColor = Color.Yellow;
        }

        private void cor_Leave(object sender, EventArgs e)
        {
            cor.BackColor = Color.White;
        }

        private void nome_Enter(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
        }

        private void nome_Leave(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
        }

        private void endereco_Enter(object sender, EventArgs e)
        {
            endereco.BackColor = Color.Yellow;
        }

        private void endereco_Leave(object sender, EventArgs e)
        {
            endereco.BackColor = Color.White;
        }

        private void numero_Enter(object sender, EventArgs e)
        {
            numero.BackColor = Color.Yellow;
        }

        private void numero_Leave(object sender, EventArgs e)
        {
            numero.BackColor = Color.White;
        }

        private void uf_Enter(object sender, EventArgs e)
        {
            uf.BackColor = Color.Yellow;
        }

        private void uf_Leave(object sender, EventArgs e)
        {
            uf.BackColor = Color.White;
        }

        private void bairro_Enter(object sender, EventArgs e)
        {
            bairro.BackColor = Color.Yellow;
        }

        private void bairro_Leave(object sender, EventArgs e)
        {
            bairro.BackColor = Color.White;
        }

        private void fone_Enter(object sender, EventArgs e)
        {
            fone.BackColor = Color.Yellow;
        }

        private void fone_Leave(object sender, EventArgs e)
        {
            fone.BackColor = Color.White;
        }

        private void celular_Enter(object sender, EventArgs e)
        {
            celular.BackColor = Color.Yellow;
        }

        private void celular_Leave(object sender, EventArgs e)
        {
            celular.BackColor = Color.White;
        }

        private void convênio_Enter(object sender, EventArgs e)
        {
            convenio.BackColor = Color.Yellow;
        }

        private void convênio_Leave(object sender, EventArgs e)
        {
            convenio.BackColor = Color.White;
        }

        private void veiculo_Enter(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.Yellow;
        }

        private void veiculo_Leave(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.White;
        }

        private void RetornaFocoParaPlaca()
        {
            placa.Focus();
        }

        private void convenio_Enter(object sender, EventArgs e)
        {
            convenio.BackColor = Color.Yellow;
        }

        private void convenio_Leave(object sender, EventArgs e)
        {
            convenio.BackColor = Color.White;
        }

        private void cep_Enter_1(object sender, EventArgs e)
        {
            cep.BackColor = Color.Yellow;
        }

        private void cep_Leave_1(object sender, EventArgs e)
        {
            cep.BackColor = Color.White;
        }
    }
}
