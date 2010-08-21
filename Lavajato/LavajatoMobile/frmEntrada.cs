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

        private WSLavajato.Cliente cliente = new LavajatoMobile.WSLavajato.Cliente();
        private WSLavajato.Service wsService = new LavajatoMobile.WSLavajato.Service();
        
        public frmEntrada()
        {
            InitializeComponent();
            CarregaHora();
            textBox1.Text = DateTime.Now.ToShortTimeString();
            textBox1.Enabled = false;
        }

        #region Métodos Formulario

        private void placa_LostFocus(object sender, EventArgs e)
        {
            if (placa.TextLength == 0)
            {
                placa.BackColor = Color.White;
                inputPanel1.Enabled = true;
                return;
            }

            if (placa.TextLength > 8)
            {
                MessageBox.Show("Placa deve conter 7 digitos", "Atenção");
                inputPanel1.Enabled = true;
                return;
            }

            this.cliente.Placa = placa.Text;
            this.cliente = wsService.ClienteByPlaca(this.cliente);
            
            if (this.cliente.ID == 0)
            {
                string placaTemp = placa.Text;
                LimpaCampos();
                DialogResult dialogResult = MessageBox.Show("Cliente não Cadastrado, deseja cadastrar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    placa.BackColor = Color.White;
                    placa.Text = placaTemp;
                    btnCadastraCliente.Text = "Cad. Cliente";
                    inputPanel1.Enabled = true;
                    return;
                }
                else
                {
                    placa.BackColor = Color.Yellow;
                    placa.Focus();
                    inputPanel1.Enabled = true;
                }

                placa.BackColor = Color.White;
            }
            else 
            {
                CarregaCliente(this.cliente);
                btnCadastraCliente.Text = "Alt. Cliente";
            }

            placa.BackColor = Color.White;
            inputPanel1.Enabled = false;
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            if (this.cliente.ID == 0)
            {
                SetUpFieldsCliente();
                ClienteInsert();
                MessageBox.Show("Cliente salvo com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                btnCadastraCliente.Text = "Cad. Cliente";
            }
            else
            {
                SetUpFieldsCliente();
                ClienteUpdate();
                MessageBox.Show("Cliente alterado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                LimpaCampos();
                btnCadastraCliente.Text = "Cad. Cliente";
            }
        }

        private void btnCadastrarServicos_Click(object sender, EventArgs e)
        {
            DateTime saida = DateTime.Now.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
            frmServico frmServico = new frmServico(this.cliente, DateTime.Now, saida);
            frmServico.ShowDialog();
            LimpaCampos();
            placa.BackColor = Color.Yellow;
            placa.Focus();
            btnCadastraCliente.Text = "Cad. Cliente";
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

        private void telefone_TextChanged(object sender, EventArgs e)
        {
            string telefoneTemp = telefone.Text;
            if (telefoneTemp == "(  )    -")
            {
                telefone.Text = "";
                return;
            }

            if (telefoneTemp.Length == 10)
            {
                string ddd = "(" + telefoneTemp.Substring(0, 2) + ")";
                string inicio = telefoneTemp.Substring(2, 4) + "-";
                string numero = telefoneTemp.Substring(6, 4);
                telefone.Text = ddd + inicio + numero;
                telefone.SelectionStart = telefoneTemp.Length;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            this.cliente = new LavajatoMobile.WSLavajato.Cliente();
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            cor.Text = "";
        }

        #endregion

        #region Metodos Auxiliares

        private void ClienteUpdate()
        {
            wsService.ClienteUpdate(cliente);
        }

        private DateTime SetUpSaidaData()
        {
            DateTime saida = entrada.Value.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
            return saida;
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
        
        private void CarregaHora()
        {
            foreach (var item in Configuracao.CarregaHora())
                hora.Items.Add(item);

            foreach (var item in Configuracao.CarregaMinuto())
                min.Items.Add(item);

            hora.SelectedIndex = 0;
            min.SelectedIndex = 0;
        }

        private void LimpaCampos()
        {
            this.cliente = new LavajatoMobile.WSLavajato.Cliente();
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            cor.Text = "";
            placa.Text = "";
        }

        #endregion

        #region Eventos

        private void veiculo_GotFocus(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.Yellow;
            inputPanel1.Enabled = true;
        }

        private void placa_GotFocus(object sender, EventArgs e)
        {
            placa.BackColor = Color.Yellow;
            inputPanel1.Enabled = true;
        }

        private void veiculo_LostFocus(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.White;
            inputPanel1.Enabled = false;
        }

        private void cor_GotFocus(object sender, EventArgs e)
        {
            cor.BackColor = Color.Yellow;
            inputPanel1.Enabled = true;
        }

        private void cor_LostFocus(object sender, EventArgs e)
        {
            cor.BackColor = Color.White;
            inputPanel1.Enabled = true;
        }

        private void nome_GotFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
            inputPanel1.Enabled = true;
        }

        private void nome_LostFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
            inputPanel1.Enabled = false;
        }

        private void telefone_GotFocus(object sender, EventArgs e)
        {
            telefone.BackColor = Color.Yellow;
            inputPanel1.Enabled = true;
        }

        private void telefone_LostFocus(object sender, EventArgs e)
        {
            if (telefone.TextLength < 10)
            {
                MessageBox.Show("Telefone deve conter DDD + Número. \n Exemplo 3135161163");
                inputPanel1.Enabled = true;
            }
            telefone.BackColor = Color.White;
            inputPanel1.Enabled = false;
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

        private void veiculo_TextChanged(object sender, EventArgs e)
        {
            veiculo.Text = veiculo.Text.ToUpper();
            veiculo.SelectionStart = veiculo.TextLength;

        }

        private void cor_TextChanged(object sender, EventArgs e)
        {
            cor.Text = cor.Text.ToUpper();
            cor.SelectionStart = cor.TextLength;
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            nome.Text = nome.Text.ToUpper();
            nome.SelectionStart = nome.TextLength;
        }

        #endregion

        private void menuItem2_Click(object sender, EventArgs e)
        {
            frmCarrosLavando frmCarlosLavador = new frmCarrosLavando();
            frmCarlosLavador.ShowDialog();
        }
    }
}