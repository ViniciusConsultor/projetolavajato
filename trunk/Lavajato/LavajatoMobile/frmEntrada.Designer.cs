namespace LavajatoMobile
{
    partial class frmEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.TextBox();
            this.veiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastraCliente = new System.Windows.Forms.Button();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCadastrarServicos = new System.Windows.Forms.Button();
            this.entrada = new System.Windows.Forms.DateTimePicker();
            this.inputPanel1 = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Carros Lavando";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.Text = "Placa:";
            // 
            // placa
            // 
            this.placa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.placa.Location = new System.Drawing.Point(1, 13);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(122, 26);
            this.placa.TabIndex = 1;
            this.placa.TextChanged += new System.EventHandler(this.placa_TextChanged);
            this.placa.GotFocus += new System.EventHandler(this.placa_GotFocus);
            this.placa.LostFocus += new System.EventHandler(this.placa_LostFocus);
            // 
            // veiculo
            // 
            this.veiculo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.veiculo.Location = new System.Drawing.Point(123, 13);
            this.veiculo.Name = "veiculo";
            this.veiculo.Size = new System.Drawing.Size(117, 26);
            this.veiculo.TabIndex = 2;
            this.veiculo.TextChanged += new System.EventHandler(this.veiculo_TextChanged);
            this.veiculo.GotFocus += new System.EventHandler(this.veiculo_GotFocus);
            this.veiculo.LostFocus += new System.EventHandler(this.veiculo_LostFocus);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(123, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.Text = "Veiculo:";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.nome.Location = new System.Drawing.Point(0, 91);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(153, 26);
            this.nome.TabIndex = 5;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            this.nome.GotFocus += new System.EventHandler(this.nome_GotFocus);
            this.nome.LostFocus += new System.EventHandler(this.nome_LostFocus);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.Text = "Nome:";
            // 
            // cor
            // 
            this.cor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.cor.Location = new System.Drawing.Point(0, 52);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(123, 26);
            this.cor.TabIndex = 3;
            this.cor.TextChanged += new System.EventHandler(this.cor_TextChanged);
            this.cor.GotFocus += new System.EventHandler(this.cor_GotFocus);
            this.cor.LostFocus += new System.EventHandler(this.cor_LostFocus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(146, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.Text = "Saida:";
            // 
            // btnCadastraCliente
            // 
            this.btnCadastraCliente.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnCadastraCliente.Location = new System.Drawing.Point(153, 91);
            this.btnCadastraCliente.Name = "btnCadastraCliente";
            this.btnCadastraCliente.Size = new System.Drawing.Size(87, 26);
            this.btnCadastraCliente.TabIndex = 8;
            this.btnCadastraCliente.Text = "Cad. Cliente";
            this.btnCadastraCliente.Click += new System.EventHandler(this.btnCadastraCliente_Click);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.telefone.Location = new System.Drawing.Point(123, 52);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(117, 26);
            this.telefone.TabIndex = 4;
            this.telefone.TextChanged += new System.EventHandler(this.telefone_TextChanged);
            this.telefone.GotFocus += new System.EventHandler(this.telefone_GotFocus);
            this.telefone.LostFocus += new System.EventHandler(this.telefone_LostFocus);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(123, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.Text = "Telefone:";
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.hora.Location = new System.Drawing.Point(147, 130);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(41, 27);
            this.hora.TabIndex = 6;
            this.hora.LostFocus += new System.EventHandler(this.hora_LostFocus);
            this.hora.GotFocus += new System.EventHandler(this.hora_GotFocus);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.Text = "Entrada:";
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.min.Location = new System.Drawing.Point(188, 130);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(52, 27);
            this.min.TabIndex = 7;
            this.min.LostFocus += new System.EventHandler(this.min_LostFocus);
            this.min.GotFocus += new System.EventHandler(this.min_GotFocus);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.textBox1.Location = new System.Drawing.Point(1, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 26);
            this.textBox1.TabIndex = 16;
            // 
            // btnCadastrarServicos
            // 
            this.btnCadastrarServicos.Location = new System.Drawing.Point(0, 157);
            this.btnCadastrarServicos.Name = "btnCadastrarServicos";
            this.btnCadastrarServicos.Size = new System.Drawing.Size(240, 23);
            this.btnCadastrarServicos.TabIndex = 24;
            this.btnCadastrarServicos.Text = "Cadastrar Servicos";
            this.btnCadastrarServicos.Click += new System.EventHandler(this.btnCadastrarServicos_Click);
            // 
            // entrada
            // 
            this.entrada.CustomFormat = "hh:mm";
            this.entrada.Enabled = false;
            this.entrada.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.entrada.Location = new System.Drawing.Point(0, 202);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(147, 27);
            this.entrada.TabIndex = 6;
            this.entrada.Value = new System.DateTime(2010, 8, 15, 17, 45, 0, 0);
            this.entrada.Visible = false;
            this.entrada.GotFocus += new System.EventHandler(this.entrada_GotFocus);
            this.entrada.LostFocus += new System.EventHandler(this.entrada_LostFocus);
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnCadastrarServicos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCadastraCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.veiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "frmEntrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox placa;
        private System.Windows.Forms.TextBox veiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastraCliente;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox min;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCadastrarServicos;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.DateTimePicker entrada;
        private Microsoft.WindowsCE.Forms.InputPanel inputPanel1;

    }
}