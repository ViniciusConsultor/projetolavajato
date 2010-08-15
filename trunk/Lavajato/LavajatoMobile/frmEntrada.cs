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
                DateTime saida = entrada.Value.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
                frmServico frmServico = new frmServico(this.cliente, entrada.Value, saida);
                frmServico.ShowDialog();
            }

            placa.BackColor = Color.White;
            
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            DateTime saida = entrada.Value.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
            SetUpFieldsCliente();
            ClienteInsert();
            MessageBox.Show("Cliente salvo com sucesso!", "Atenção");
            frmServico frmServico = new frmServico(this.cliente, entrada.Value, saida);
            frmServico.ShowDialog();
            LimpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            this.cliente = new LavajatoMobile.WSLavajato.Cliente();
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            cor.Text = "";
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

        private void telefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}