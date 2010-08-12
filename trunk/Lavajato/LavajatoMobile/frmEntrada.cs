using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LavajatoMobile.WSLavajato;

namespace LavajatoMobile
{
    public partial class frmEntrada : Form
    {
        private WSLavajato.Service wsService = new LavajatoMobile.WSLavajato.Service();
        private WSLavajato.Cliente cliente;
        private WSLavajato.Servico servico = new LavajatoMobile.WSLavajato.Servico();
        private WSLavajato.ServicoItem servicoItem = new LavajatoMobile.WSLavajato.ServicoItem();


        public frmEntrada()
        {
            InitializeComponent();
            cliente = new LavajatoMobile.WSLavajato.Cliente();
            btnCadastraCliente.Enabled = false;
            CarregaProdutos();
            CarregaHora();
        }

        private void placa_LostFocus(object sender, EventArgs e)
        {
            if (placa.TextLength == 0)
            {
                placa.BackColor = Color.White;
                return;
            }

            if (placa.TextLength > 8)
            {
                MessageBox.Show("Placa deve conter 7 digitos", "Atenção");
                return;
            }

            this.cliente.Placa = placa.Text;
            this.cliente = wsService.ClienteByPlaca(this.cliente);

            if (this.cliente.ID == 0)
            {
                LimpaCampos();
                DialogResult dialogResult = MessageBox.Show("Cliente não Cadastrado, deseja cadastrar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    btnCadastraCliente.Enabled = true;
                    placa.BackColor = Color.White;
                    return;
                }
                else
                {
                    placa.Focus();
                }

                placa.BackColor = Color.White;
            }
            else
            {
                CarregaCliente(this.cliente);
            }

            this.servico = wsService.ServicoByCliente(this.cliente);
            if (this.servico.ID == 0)
            {
                placa.BackColor = Color.White;
                btnAdicionaProduto.Focus();
                return;
            }
            else
            {
                CarregaItensDoServico(this.servico);
                btnAdicionaProduto.Focus();
            }

            if (this.servico.Finalizado == 0)
                MessageBox.Show("Ordem de Serviço Aberto", "Atenção");

            if (this.servico.Lavado == 1)
                MessageBox.Show("Veículo já lavado", "Atenção");

            placa.BackColor = Color.White;
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            SetUpFieldsCliente();
            ClienteInsert();
            MessageBox.Show("Cliente salvo com sucesso!", "Atenção");
            btnCadastraCliente.Enabled = false;
            btnAdicionaProduto.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.servico.ID == 0)
            {
                MessageBox.Show("Nenhum item encontrado!", "Atenção");
                return;
            }

            DialogResult res = MessageBox.Show("Deseja realmente apagar o item de pedido", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No)
            {
                return;
            }

            wsService.ServicoItemDelete(this.servicoItem);
            MessageBox.Show("Item deletado com sucesso!", "Atenção");
            CarregaItensDoServico();
            CarregaItensDoServico(this.servico);

        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            string placaBackup = placa.Text;

            int index = placaBackup.IndexOfAny(new char[] { '-', '.', ',', '_' });
            if (index > -1)
                placaBackup = placaBackup.Remove(index, 1);

            if (placaBackup.Length > 7)
                placaBackup = placaBackup.Remove(7, placaBackup.Length - 7);

            string letras = "";
            string numeros = "";

            if (placaBackup.Length >= 3)
                letras = placaBackup.Substring(0, 3);

            if (placaBackup.Length > 3 && placaBackup.Length >= 7)
                numeros = placaBackup.Substring(3, placaBackup.Length - 3);

            if (placa.Left > 0 && numeros.Length > 0)
                placa.Text = letras + "-" + numeros;
            else
                placa.Text = placaBackup.ToUpper();

            placa.SelectionStart = placa.TextLength;
        }

        private void grdServico_Click(object sender, EventArgs e)
        {
            if (grdServico.CurrentRowIndex <= -1)
                return;

            int id = int.Parse(wsService.ServicoCriaGrid(this.servico).Rows[grdServico.CurrentRowIndex]["ID"].ToString());
            this.servicoItem.ID = id;
        }

        private void btnAdicionaProduto_Click(object sender, EventArgs e)
        {

            if (this.cliente.ID == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Atenção");
                return;
            }

            if (this.servico.ID == 0)
            {
                this.servico = ServicoSalva();
                ItemDoServicoSalva(this.servico);
            }
            else
            {
                ItemDoServicoSalva(this.servico);
            }

            CarregaItensDoServico();
            CarregaItensDoServico(this.servico);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.servico = new LavajatoMobile.WSLavajato.Servico();
            this.cliente = new LavajatoMobile.WSLavajato.Cliente();
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            cor.Text = "";
            CarregaItensDoServico(this.servico);
        }

        private void ClienteInsert()
        {
            this.cliente = wsService.ClienteAdd(this.cliente);
        }

        private void SetUpFieldsCliente()
        {
            this.cliente.Placa = placa.Text;
            this.cliente.Veiculo = veiculo.Text;
            this.cliente.Telefone = telefone.Text;
            this.cliente.Nome = nome.Text;
            this.cliente.Cor = cor.Text;
        }

        private void CarregaItensDoServico(Servico servico)
        {
            grdServico.DataSource = wsService.ServicoCriaGrid(this.servico);
        }

        private void CarregaCliente(Cliente cliente)
        {
            placa.Text = this.cliente.Placa;
            veiculo.Text = this.cliente.Veiculo;
            telefone.Text = this.cliente.Telefone;
            nome.Text = this.cliente.Nome;
            cor.Text = this.cliente.Cor;
        }

        private Cliente ProcuraCliente(Cliente cliente)
        {
            return wsService.ClienteByPlaca(this.cliente);
        }

        private void CarregaProdutos()
        {
            cmdServico.DataSource = wsService.ProdutoTipo(2);
            cmdServico.DisplayMember = "Descricao";
            cmdServico.ValueMember = "ID";
        }

        private void CarregaHora()
        {
            foreach (var item in Configuracao.CarregaHora())
                hora.Items.Add(item);

            foreach (var item in Configuracao.CarregaMinuto())
                min.Items.Add(item);

            hora.SelectedIndex = 0;
            min.SelectedIndex = 0;
        }

        private void CarregaItensDoServico()
        {
            this.servico = wsService.ServicoByID(this.servico);
        }

        private void LimpaCampos()
        {
            this.servico = new LavajatoMobile.WSLavajato.Servico();
            this.cliente = new LavajatoMobile.WSLavajato.Cliente();
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            cor.Text = "";
            CarregaItensDoServico(this.servico);
        }

        private void ItemDoServicoSalva(Servico servico)
        {
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto = new Produto() { ID = ((Produto)cmdServico.SelectedItem).ID };
            servicoItem.Quantidade = 1;
            servicoItem.Servico = servico;
            wsService.ServicoItemAdd(servicoItem);
        }

        private Servico ServicoSalva()
        {
            Servico servico = new Servico();
            servico.Cliente = this.cliente;
            servico.Total = 0;
            servico.SubTotal = 0;
            servico.Desconto = 0;
            servico.Entrada = DateTime.Now;
            servico.Saida = servico.Entrada.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
            servico.OrdemServico = this.cliente.ID;
            servico.FormaPagamento = new FormaPagamento() { ID = 1 };
            servico.Usuario = new Usuario() { ID = 26 };

            servico.Cancelado = 0;
            servico.Delete = 0;
            servico.Finalizado = 0;
            servico.Lavado = 0;

            return wsService.ServicoAdd(servico);
        }

        private void veiculo_GotFocus(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.Yellow;
        }

        private void placa_GotFocus(object sender, EventArgs e)
        {
            placa.BackColor = Color.Yellow;
        }

        private void veiculo_LostFocus(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.White;
        }

        private void cor_GotFocus(object sender, EventArgs e)
        {
            cor.BackColor = Color.Yellow;
        }

        private void cor_LostFocus(object sender, EventArgs e)
        {
            cor.BackColor = Color.White;
        }

        private void nome_GotFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
        }

        private void nome_LostFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
        }

        private void telefone_GotFocus(object sender, EventArgs e)
        {
            telefone.BackColor = Color.Yellow;
        }

        private void telefone_LostFocus(object sender, EventArgs e)
        {
            telefone.BackColor = Color.White;
        }

        private void entrada_GotFocus(object sender, EventArgs e)
        {
            entrada.BackColor = Color.Yellow;
        }

        private void entrada_LostFocus(object sender, EventArgs e)
        {
            entrada.BackColor = Color.White;
        }

        private void hora_GotFocus(object sender, EventArgs e)
        {
            hora.BackColor = Color.Yellow;
        }

        private void hora_LostFocus(object sender, EventArgs e)
        {
            hora.BackColor = Color.White;
        }

        private void min_GotFocus(object sender, EventArgs e)
        {
            min.BackColor = Color.Yellow;
        }

        private void min_LostFocus(object sender, EventArgs e)
        {
            min.BackColor = Color.White;
        }

        private void cmdServico_GotFocus(object sender, EventArgs e)
        {
            cmdServico.BackColor = Color.Yellow;
        }

        private void cmdServico_LostFocus(object sender, EventArgs e)
        {
            cmdServico.BackColor = Color.White;
        }

        private void telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            
        }
    }
}