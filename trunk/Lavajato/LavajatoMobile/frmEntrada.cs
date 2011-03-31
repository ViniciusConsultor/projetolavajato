using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LavajatoMobile.WSLavajato;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LavajatoMobile
{
    public partial class frmEntrada : Form
    {

        private Cliente _cliente = new Cliente();
        private Servico _servico = new Servico();
        private WSLavajato.WebServiceLavajato wsService = new LavajatoMobile.WSLavajato.WebServiceLavajato();

        public frmEntrada()
        {
            InitializeComponent();
            CarregaHora();
        }

        #region Métodos Formulario

        private void placa_LostFocus(object sender, EventArgs e)
        {
            if (!ServicoBL.PlacaValida(placa.Text))
            {
                placa.BackColor = Color.White;
                btnCadastraCliente.Text = "Cad. Cliente";
                LimpaCampos();
                return;
            }

            _cliente.Placa = placa.Text;

            //Procura cliente com base na placa
            _cliente = wsService.ClienteByPlaca(_cliente);

            //Procura serviço aberto se existir o cliente com ordem aberta
            _servico = CarregaServico(_cliente);

            //se encontrar o cliente vai carregar as informaçõe do mesmo caso contrario, será perguntado
            //se deseja cadastrar o cliente.
            if (_cliente.ID == 0)
            {
                string placaTemp = placa.Text;
                LimpaCampos();

                placa.Text = placaTemp;
                btnCadastraCliente.Text = "Cad. Cliente";


                placa.BackColor = Color.White;
                return;
            }

            CarregaCliente(_cliente);

            btnCadastraCliente.Text = "Alt. Cliente";
            placa.BackColor = Color.White;

            SIPHandler.HideSIP();

        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            if (this._cliente.ID == 0)
            {
                SetUpFieldsCliente();
                ClienteInsert();
                
                MessageBox.Show("Cliente salvo com sucesso!", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                btnCadastraCliente.Text = "Cad. Cliente";
            }
            else
            {
                SetUpFieldsCliente();
                ClienteUpdate();
                MessageBox.Show("Cliente alterado com sucesso !", "Atenção", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                
                LimpaCampos();
                btnCadastraCliente.Text = "Cad. Cliente";
            }
        }

        private void btnCadastrarServicos_Click(object sender, EventArgs e)
        {
            if (_cliente.ID > 0)
            {
                string h = (hora.SelectedItem == null) ? "0" : hora.SelectedItem.ToString();
                string m = (min.SelectedItem == null ) ? "0" : min.SelectedItem.ToString();

                // se o serviço já existir não será verificado a hora, 
                // caso ele esteja sendo criado será verificado
                DateTime horaSaida = new DateTime();
                if (_servico.ID == 0)
                {
                    //se o serviço não existir ainda então é validada a data, hora e minuto não 
                    //podem ser igual a zero(0)
                    if (ServicoBL.HoraMinutoValidos(h, m))
                    {
                        MessageBox.Show("Favor inserir dada e hora de saida do veículo", "Atenção!");
                        return;
                    }

                    //Seta a hora de saida caso o id seja igual a zero
                    horaSaida = ServicoBL.SetHoraMinutoDeSaidaDoCarro(h, m);
                }
                else
                {
                    //pega a hora de saida já salva no sistema
                    horaSaida = _servico.Saida;
                }

                frmServico frmServico = new frmServico(_cliente, horaSaida);
                frmServico.ShowDialog();
                LimpaCampos();
                
                hora.SelectedItem = 0;
                min.SelectedItem = 0;

                btnCadastraCliente.Text = "Cad. Cliente";
                placa.BackColor = Color.Yellow;
                placa.Focus();
            }
            else
            {
                MessageBox.Show("Favor escolher/cadastrar cliente!", "Atenção");
            }
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            SIPHandler.ShowSIP();

            if (placa.TextLength >= 3)
                SIPHandler.ShowSIPNumeric();
            else
                SIPHandler.ShowSIPRegular();

            string pl = ServicoBL.PlacaFormata(placa.Text);
            placa.Text = pl.ToUpper();
            placa.SelectionStart = pl.Length;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            _cliente = new LavajatoMobile.WSLavajato.Cliente();
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

        private void ClienteInsert()
        {
            this._cliente = wsService.ClienteAdd(this._cliente);
        }

        private Servico CarregaServico(Cliente _cliente)
        {
            return wsService.ByCliente(_cliente);
        }

        private void SetUpFieldsCliente()
        {
            _cliente.Placa = placa.Text;
            _cliente.Veiculo = veiculo.Text;
            _cliente.Telefone = telefone.Text;
            _cliente.Nome = nome.Text;
            _cliente.Cor = cor.Text;
        }

        private void CarregaCliente(Cliente cliente)
        {
            placa.Text = _cliente.Placa;
            veiculo.Text = _cliente.Veiculo;
            telefone.Text = _cliente.Telefone;
            nome.Text = _cliente.Nome;
            cor.Text = _cliente.Cor;
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
            SIPHandler.ShowSIP();
            SIPHandler.ShowSIPRegular();
            veiculo.BackColor = Color.Yellow;
            
        }

        private void veiculo_LostFocus(object sender, EventArgs e)
        {
            SIPHandler.HideSIP();
            veiculo.BackColor = Color.White;
            
        }

        private void placa_GotFocus(object sender, EventArgs e)
        {
            SIPHandler.ShowSIP();
            SIPHandler.ShowSIPRegular();
            placa.BackColor = Color.Yellow;
            
        }

        private void cor_GotFocus(object sender, EventArgs e)
        {
            SIPHandler.ShowSIP();
            SIPHandler.ShowSIPRegular();
            cor.BackColor = Color.Yellow;
        }

        private void cor_LostFocus(object sender, EventArgs e)
        {
            SIPHandler.HideSIP();
            cor.BackColor = Color.White;
            
        }

        private void nome_GotFocus(object sender, EventArgs e)
        {
            SIPHandler.ShowSIP();
            SIPHandler.ShowSIPRegular();
            nome.BackColor = Color.Yellow;
        }

        private void nome_LostFocus(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
            SIPHandler.HideSIP();
        }

        private void telefone_GotFocus(object sender, EventArgs e)
        {
            SIPHandler.ShowSIP();
            SIPHandler.ShowSIPNumeric();
            telefone.BackColor = Color.Yellow;
            
        }

        private void telefone_LostFocus(object sender, EventArgs e)
        {
            string tel = telefone.Text;
            if (telefone.TextLength == 10)
            {
                string ddd = "(" + tel.Substring(0, 2) + ")";
                string inicio = tel.Substring(2, 4) + "-";
                string numero = tel.Substring(6, 4);
                telefone.Text = ddd + inicio + numero;
                telefone.SelectionStart = tel.Length;
            }

            telefone.BackColor = Color.White;

            SIPHandler.HideSIP();
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

        private void menuItem2_Click(object sender, EventArgs e)
        {
            frmCarrosLavando frmCarlosLavador = new frmCarrosLavando();
            frmCarlosLavador.ShowDialog();
        }

        #endregion

        private void placa_KeyDown(object sender, KeyEventArgs e)
        {
        }

        //#region Teclado

        //public void SetKeyboardNumeric()
        //{

        //    Process p = Process.GetCurrentProcess();

        //    if (p.MainWindowHandle != IntPtr.Zero)

        //        SHSetImeMode(p.MainWindowHandle, SHIME_MODE.SHIME_MODE_NUMBERS);
        //}

        //public void SetKeyboardNormal()
        //{

        //    Process p = Process.GetCurrentProcess();

        //    if (p.MainWindowHandle != IntPtr.Zero)

        //        SHSetImeMode(p.MainWindowHandle, SHIME_MODE.SHIME_MODE_NONE);

        //}

        //private enum SHIME_MODE
        //{

        //    SHIME_MODE_NONE = 0,

        //    SHIME_MODE_SPELL = 1,

        //    SHIME_MODE_SPELL_CAPS = 2,

        //    SHIME_MODE_SPELL_CAPS_LOCK = 3,

        //    SHIME_MODE_AMBIGUOUS = 4,

        //    SHIME_MODE_AMBIGUOUS_CAPS = 5,

        //    SHIME_MODE_AMBIGUOUS_CAPS_LOCK = 6,

        //    SHIME_MODE_NUMBERS = 7,

        //    SHIME_MODE_CUSTOM = 8

        //}

        //[DllImport("aygshell.dll")]
        //private static extern int SHSetImeMode(IntPtr hWnd, SHIME_MODE nMode);

        //private void textBox1_GotFocus(object sender, EventArgs e)
        //{
        //    SetKeyboardNumeric();
        //}

        //private void textBox1_LostFocus(object sender, EventArgs e)
        //{
        //    SetKeyboardNormal();
        //}

        //#endregion
    }
}