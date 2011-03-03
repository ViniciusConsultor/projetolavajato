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

        private WSLavajato.Cliente _cliente = new LavajatoMobile.WSLavajato.Cliente();
        private WSLavajato.WebServiceLavajato wsService = new LavajatoMobile.WSLavajato.WebServiceLavajato();
        
        public frmEntrada()
        {
            InitializeComponent();
            CarregaHora();
            SetHoraInicial();
        }

        private void SetHoraInicial()
        {
            txtHoraInicial.Text = DateTime.Now.ToShortTimeString();
            txtHoraInicial.Enabled = false;
        }

        #region Métodos Formulario

        private void placa_LostFocus(object sender, EventArgs e)
        {
            if (!PlacaEValida())
            {
                placa.BackColor = Color.White;
                btnCadastraCliente.Text = "Cad. Cliente";
                LimpaCampos();
                return;
            }

            _cliente.Placa = placa.Text;
            _cliente = wsService.ClienteByPlaca(_cliente);

            if (_cliente.ID == 0)
            {
                string placaTemp = placa.Text;
                LimpaCampos();

                DialogResult dialogResult = MessageBox.Show("Cliente não Cadastrado, deseja cadastrar?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    placa.BackColor = Color.White;
                    placa.Text = placaTemp;
                    btnCadastraCliente.Text = "Cad. Cliente";
                    teclado.Enabled = true;
                    return;
                }
                else
                {
                    placa.BackColor = Color.Yellow;
                    placa.Focus();
                    teclado.Enabled = true;
                }
                placa.BackColor = Color.White;
                return;
            }

            CarregaCliente(this._cliente);
            btnCadastraCliente.Text = "Alt. Cliente";

            placa.BackColor = Color.White;
            teclado.Enabled = false;
        }

        private bool PlacaEValida()
        {
            if (placa.TextLength == 0)
            {
                teclado.Enabled = true;
                return false;
            }

            if (placa.TextLength > 8)
            {
                MessageBox.Show("Placa deve conter 7 digitos", "Atenção");
                teclado.Enabled = true;
                return false;
            }
            return true;
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            if (this._cliente.ID == 0)
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
            DateTime horaSaida;
            if (VerificaHora() && VerificaMinuto())
            {
                MessageBox.Show("Favor inserir dada e hora de saida do veículo", "Atenção!");
                return;
            }

            horaSaida = SetHoraEMinutoDeSaidaDoCarro();       

            frmServico frmServico = new frmServico(_cliente, horaSaida);
            frmServico.ShowDialog();
            LimpaCampos();
            placa.BackColor = Color.Yellow;
            placa.Focus();
            btnCadastraCliente.Text = "Cad. Cliente";
        }

        private DateTime SetHoraEMinutoDeSaidaDoCarro()
        {
            var h = (hora.SelectedItem == null ? "0" : hora.SelectedItem.ToString());
            var m = (min.SelectedItem == null ? "0" : min.SelectedItem.ToString());
            return  DateTime.Now
                .AddHours(double.Parse(h))
                .AddMinutes(double.Parse(m));
        }

        private bool VerificaHora()
        {
            return ((hora.SelectedIndex == -1));
        }

        private bool VerificaMinuto()
        {
            return  ((min.SelectedIndex == -1));
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

            this._cliente = new LavajatoMobile.WSLavajato.Cliente();
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
            wsService.ClienteUpdate(_cliente);
        }

        private DateTime SetUpSaidaData()
        {
            DateTime saida = entrada.Value.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
            return saida;
        }

        private void ClienteInsert()
        {
            this._cliente = wsService.ClienteAdd(this._cliente);
        }

        private void SetUpFieldsCliente()
        {
            this._cliente.Placa = placa.Text;
            this._cliente.Veiculo = veiculo.Text;
            this._cliente.Telefone = telefone.Text;
            this._cliente.Nome = nome.Text;
            this._cliente.Cor = cor.Text;
        }

        private void CarregaCliente(Cliente cliente)
        {
            placa.Text = this._cliente.Placa;
            veiculo.Text = this._cliente.Veiculo;
            telefone.Text = this._cliente.Telefone;
            nome.Text = this._cliente.Nome;
            cor.Text = this._cliente.Cor;
        }

        private Cliente ProcuraCliente(Cliente cliente)
        {
            return wsService.ClienteByPlaca(this._cliente);
        }
        
        private void CarregaHora()
        {
            foreach (var item in Configuracao.CarregaHora())
                hora.Items.Add(item);

            foreach (var item in Configuracao.CarregaMinuto())
                min.Items.Add(item);

        }

        private void LimpaCampos()
        {
            this._cliente = new LavajatoMobile.WSLavajato.Cliente();
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
            teclado.Enabled = true;
        }

        private void placa_GotFocus(object sender, EventArgs e)
        {
            placa.BackColor = Color.Yellow;
            teclado.Enabled = true;
        }

        private void veiculo_LostFocus(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.White;
            teclado.Enabled = false;
        }

        private void cor_GotFocus(object sender, EventArgs e)
        {
            cor.BackColor = Color.Yellow;
            teclado.Enabled = true;
        }

        private void cor_LostFocus(object sender, EventArgs e)
        {
            cor.BackColor = Color.White;
            teclado.Enabled = true;
        }

        private void nome_GotFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
            teclado.Enabled = true;
        }

        private void nome_LostFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
            teclado.Enabled = false;
        }

        private void telefone_GotFocus(object sender, EventArgs e)
        {
            telefone.BackColor = Color.Yellow;
            teclado.Enabled = true;
        }

        private void telefone_LostFocus(object sender, EventArgs e)
        {
            string tel = telefone.Text;
            if (telefone.TextLength < 10)
            {
                MessageBox.Show("Telefone deve conter DDD + Número. \n Exemplo 3135161163","Atenção!");
                teclado.Enabled = true;
            }
            else if (telefone.TextLength == 10)
            {
                string ddd = "(" + tel.Substring(0, 2) + ")";
                string inicio = tel.Substring(2, 4) + "-";
                string numero = tel.Substring(6, 4);
                telefone.Text = ddd + inicio + numero;
                telefone.SelectionStart = tel.Length;
            }

            telefone.BackColor = Color.White;
            teclado.Enabled = false;
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