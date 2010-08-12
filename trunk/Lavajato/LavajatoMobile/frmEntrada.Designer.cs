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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
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
            this.grdServico = new System.Windows.Forms.DataGrid();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdServico = new System.Windows.Forms.ComboBox();
            this.btnAdicionaProduto = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.ComboBox();
            this.min = new System.Windows.Forms.ComboBox();
            this.entrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.placa.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.placa.Location = new System.Drawing.Point(1, 13);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(73, 19);
            this.placa.TabIndex = 1;
            this.placa.TextChanged += new System.EventHandler(this.placa_TextChanged);
            this.placa.GotFocus += new System.EventHandler(this.placa_GotFocus);
            this.placa.LostFocus += new System.EventHandler(this.placa_LostFocus);
            // 
            // veiculo
            // 
            this.veiculo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.veiculo.Location = new System.Drawing.Point(74, 13);
            this.veiculo.Name = "veiculo";
            this.veiculo.Size = new System.Drawing.Size(79, 19);
            this.veiculo.TabIndex = 2;
            this.veiculo.GotFocus += new System.EventHandler(this.veiculo_GotFocus);
            this.veiculo.LostFocus += new System.EventHandler(this.veiculo_LostFocus);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(74, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.Text = "Veiculo:";
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.nome.Location = new System.Drawing.Point(1, 46);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(153, 19);
            this.nome.TabIndex = 4;
            this.nome.GotFocus += new System.EventHandler(this.nome_GotFocus);
            this.nome.LostFocus += new System.EventHandler(this.nome_LostFocus);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(1, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.Text = "Nome:";
            // 
            // cor
            // 
            this.cor.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cor.Location = new System.Drawing.Point(153, 13);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(84, 19);
            this.cor.TabIndex = 3;
            this.cor.GotFocus += new System.EventHandler(this.cor_GotFocus);
            this.cor.LostFocus += new System.EventHandler(this.cor_LostFocus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(153, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(152, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.Text = "Saida:";
            // 
            // btnCadastraCliente
            // 
            this.btnCadastraCliente.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnCadastraCliente.Location = new System.Drawing.Point(1, 67);
            this.btnCadastraCliente.Name = "btnCadastraCliente";
            this.btnCadastraCliente.Size = new System.Drawing.Size(80, 31);
            this.btnCadastraCliente.TabIndex = 9;
            this.btnCadastraCliente.Text = "Cad. Cliente";
            this.btnCadastraCliente.Click += new System.EventHandler(this.btnCadastraCliente_Click);
            // 
            // grdServico
            // 
            this.grdServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdServico.Location = new System.Drawing.Point(1, 118);
            this.grdServico.Name = "grdServico";
            this.grdServico.Size = new System.Drawing.Size(236, 103);
            this.grdServico.TabIndex = 15;
            this.grdServico.Click += new System.EventHandler(this.grdServico_Click);
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.telefone.Location = new System.Drawing.Point(154, 46);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(83, 19);
            this.telefone.TabIndex = 5;
            this.telefone.TextChanged += new System.EventHandler(this.telefone_TextChanged);
            this.telefone.GotFocus += new System.EventHandler(this.telefone_GotFocus);
            this.telefone.LostFocus += new System.EventHandler(this.telefone_LostFocus);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(151, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.Text = "Telefone:";
            // 
            // cmdServico
            // 
            this.cmdServico.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cmdServico.Location = new System.Drawing.Point(1, 98);
            this.cmdServico.Name = "cmdServico";
            this.cmdServico.Size = new System.Drawing.Size(178, 20);
            this.cmdServico.TabIndex = 10;
            this.cmdServico.LostFocus += new System.EventHandler(this.cmdServico_LostFocus);
            this.cmdServico.GotFocus += new System.EventHandler(this.cmdServico_GotFocus);
            // 
            // btnAdicionaProduto
            // 
            this.btnAdicionaProduto.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdicionaProduto.Location = new System.Drawing.Point(179, 98);
            this.btnAdicionaProduto.Name = "btnAdicionaProduto";
            this.btnAdicionaProduto.Size = new System.Drawing.Size(58, 20);
            this.btnAdicionaProduto.TabIndex = 12;
            this.btnAdicionaProduto.Text = "Adicionar";
            this.btnAdicionaProduto.Click += new System.EventHandler(this.btnAdicionaProduto_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Location = new System.Drawing.Point(1, 221);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 20);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(46, 221);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(46, 20);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpa";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.hora.Location = new System.Drawing.Point(153, 78);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(41, 20);
            this.hora.TabIndex = 7;
            this.hora.LostFocus += new System.EventHandler(this.hora_LostFocus);
            this.hora.GotFocus += new System.EventHandler(this.hora_GotFocus);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.min.Location = new System.Drawing.Point(194, 78);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(43, 20);
            this.min.TabIndex = 8;
            this.min.LostFocus += new System.EventHandler(this.min_LostFocus);
            this.min.GotFocus += new System.EventHandler(this.min_GotFocus);
            // 
            // entrada
            // 
            this.entrada.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.entrada.Location = new System.Drawing.Point(82, 78);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(71, 20);
            this.entrada.TabIndex = 6;
            this.entrada.GotFocus += new System.EventHandler(this.entrada_GotFocus);
            this.entrada.LostFocus += new System.EventHandler(this.entrada_LostFocus);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(82, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.Text = "Entrada:";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(175, 221);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(62, 20);
            this.btnConcluir.TabIndex = 22;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.min);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionaProduto);
            this.Controls.Add(this.cmdServico);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdServico);
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
            this.Text = "frmEntrada";
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
        private System.Windows.Forms.DataGrid grdServico;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmdServico;
        private System.Windows.Forms.Button btnAdicionaProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox hora;
        private System.Windows.Forms.ComboBox min;
        private System.Windows.Forms.DateTimePicker entrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConcluir;

    }
}