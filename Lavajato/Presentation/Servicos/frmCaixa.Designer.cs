namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Button btnAlterarQuantidade;
            System.Windows.Forms.CheckBox acertoFuturo;
            this.grdServico = new System.Windows.Forms.DataGridView();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.desconto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.troco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalServico = new System.Windows.Forms.TextBox();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVendaAvulca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.convenio = new System.Windows.Forms.ComboBox();
            this.ordemServico = new System.Windows.Forms.TextBox();
            this.chbLavado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLavador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.ComboBox();
            this.hora = new System.Windows.Forms.ComboBox();
            this.placa = new System.Windows.Forms.TextBox();
            this.veiculo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.corVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            btnAlterarQuantidade = new System.Windows.Forms.Button();
            acertoFuturo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterarQuantidade
            // 
            btnAlterarQuantidade.Location = new System.Drawing.Point(76, 519);
            btnAlterarQuantidade.Name = "btnAlterarQuantidade";
            btnAlterarQuantidade.Size = new System.Drawing.Size(75, 51);
            btnAlterarQuantidade.TabIndex = 22;
            btnAlterarQuantidade.Text = "Alterar Quantidade (F3)";
            btnAlterarQuantidade.UseVisualStyleBackColor = true;
            btnAlterarQuantidade.Click += new System.EventHandler(this.btnAlterarQuantidade_Click);
            // 
            // acertoFuturo
            // 
            acertoFuturo.AutoSize = true;
            acertoFuturo.Enabled = false;
            acertoFuturo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            acertoFuturo.Location = new System.Drawing.Point(225, 351);
            acertoFuturo.Name = "acertoFuturo";
            acertoFuturo.Size = new System.Drawing.Size(154, 29);
            acertoFuturo.TabIndex = 111;
            acertoFuturo.Text = "Acerto futuro";
            acertoFuturo.UseVisualStyleBackColor = true;
            acertoFuturo.CheckedChanged += new System.EventHandler(this.acertoFuturo_CheckedChanged);
            // 
            // grdServico
            // 
            this.grdServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServico.Location = new System.Drawing.Point(385, 1);
            this.grdServico.Name = "grdServico";
            this.grdServico.Size = new System.Drawing.Size(402, 389);
            this.grdServico.TabIndex = 0;
            this.grdServico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdServico_MouseClick);
            // 
            // cmbProduto
            // 
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(134, 395);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(416, 33);
            this.cmbProduto.TabIndex = 13;
            this.cmbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduto_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(683, 397);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 33);
            this.btnAdicionar.TabIndex = 15;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.desconto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbFormaPagamento);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.troco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.valor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.totalServico);
            this.groupBox1.Location = new System.Drawing.Point(1, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 83);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 29);
            this.label13.TabIndex = 94;
            this.label13.Text = "Desconto:";
            // 
            // desconto
            // 
            this.desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconto.Location = new System.Drawing.Point(390, 44);
            this.desconto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.desconto.Multiline = true;
            this.desconto.Name = "desconto";
            this.desconto.Size = new System.Drawing.Size(112, 33);
            this.desconto.TabIndex = 19;
            this.desconto.TextChanged += new System.EventHandler(this.desconto_TextChanged);
            this.desconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.desconto_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 92;
            this.label12.Text = "For. Pag:";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(5, 44);
            this.cmbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(161, 33);
            this.cmbFormaPagamento.TabIndex = 16;
            this.cmbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedIndexChanged);
            this.cmbFormaPagamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFormaPagamento_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(497, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 29);
            this.label11.TabIndex = 90;
            this.label11.Text = "Troco:";
            // 
            // troco
            // 
            this.troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troco.Location = new System.Drawing.Point(502, 44);
            this.troco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.troco.Multiline = true;
            this.troco.Name = "troco";
            this.troco.Size = new System.Drawing.Size(112, 33);
            this.troco.TabIndex = 20;
            this.troco.TextChanged += new System.EventHandler(this.troco_TextChanged);
            this.troco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.troco_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 88;
            this.label6.Text = "Valor:";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(278, 44);
            this.valor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.valor.Multiline = true;
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(112, 33);
            this.valor.TabIndex = 18;
            this.valor.TextChanged += new System.EventHandler(this.valor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 86;
            this.label1.Text = "Total:";
            // 
            // totalServico
            // 
            this.totalServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalServico.Location = new System.Drawing.Point(166, 44);
            this.totalServico.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.totalServico.Multiline = true;
            this.totalServico.Name = "totalServico";
            this.totalServico.Size = new System.Drawing.Size(112, 33);
            this.totalServico.TabIndex = 17;
            this.totalServico.TextChanged += new System.EventHandler(this.totalServico_TextChanged);
            this.totalServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totalServico_KeyDown);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(301, 519);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(75, 51);
            this.btnCancelarVenda.TabIndex = 25;
            this.btnCancelarVenda.Text = " Cancelar  \r\n   Venda     \r(F6)";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Location = new System.Drawing.Point(1, 519);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(75, 51);
            this.btnConcluirVenda.TabIndex = 21;
            this.btnConcluirVenda.Text = "Concluir  Venda    (F2)";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            this.btnConcluirVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnConcluirVenda_KeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(226, 519);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 51);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "   Excluir\r\n   Item \r\n   (F5)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVendaAvulca
            // 
            this.btnVendaAvulca.Location = new System.Drawing.Point(151, 519);
            this.btnVendaAvulca.Name = "btnVendaAvulca";
            this.btnVendaAvulca.Size = new System.Drawing.Size(75, 51);
            this.btnVendaAvulca.TabIndex = 23;
            this.btnVendaAvulca.Text = "   Venda   \r\n     Avulsa    \r\n (F4)";
            this.btnVendaAvulca.UseVisualStyleBackColor = true;
            this.btnVendaAvulca.Click += new System.EventHandler(this.btnVendaAvulca_Click);
            this.btnVendaAvulca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnVendaAvulca_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(acertoFuturo);
            this.groupBox2.Controls.Add(this.convenio);
            this.groupBox2.Controls.Add(this.ordemServico);
            this.groupBox2.Controls.Add(this.chbLavado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbLavador);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataEntrada);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.min);
            this.groupBox2.Controls.Add(this.hora);
            this.groupBox2.Controls.Add(this.placa);
            this.groupBox2.Controls.Add(this.veiculo);
            this.groupBox2.Controls.Add(this.nome);
            this.groupBox2.Controls.Add(this.corVeiculo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.telefone);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblVeiculo);
            this.groupBox2.Controls.Add(this.lblPlaca);
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 394);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-4, 314);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 31);
            this.label15.TabIndex = 113;
            this.label15.Text = "Convenio:";
            // 
            // convenio
            // 
            this.convenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convenio.FormattingEnabled = true;
            this.convenio.Location = new System.Drawing.Point(133, 317);
            this.convenio.Name = "convenio";
            this.convenio.Size = new System.Drawing.Size(240, 33);
            this.convenio.TabIndex = 112;
            this.convenio.SelectedIndexChanged += new System.EventHandler(this.convenio_SelectedIndexChanged);
            // 
            // ordemServico
            // 
            this.ordemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordemServico.Location = new System.Drawing.Point(133, 12);
            this.ordemServico.Name = "ordemServico";
            this.ordemServico.Size = new System.Drawing.Size(240, 31);
            this.ordemServico.TabIndex = 1;
            this.ordemServico.Validated += new System.EventHandler(this.ordemServico_Validated);
            this.ordemServico.Leave += new System.EventHandler(this.ordemServico_Leave);
            // 
            // chbLavado
            // 
            this.chbLavado.AutoSize = true;
            this.chbLavado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLavado.Location = new System.Drawing.Point(123, 351);
            this.chbLavado.Name = "chbLavado";
            this.chbLavado.Size = new System.Drawing.Size(102, 29);
            this.chbLavado.TabIndex = 12;
            this.chbLavado.Text = "Lavado";
            this.chbLavado.UseVisualStyleBackColor = true;
            this.chbLavado.CheckedChanged += new System.EventHandler(this.chbLavado_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 110;
            this.label5.Text = "Ord. Serv.:";
            // 
            // cmbLavador
            // 
            this.cmbLavador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLavador.FormattingEnabled = true;
            this.cmbLavador.Location = new System.Drawing.Point(133, 284);
            this.cmbLavador.Name = "cmbLavador";
            this.cmbLavador.Size = new System.Drawing.Size(240, 33);
            this.cmbLavador.TabIndex = 10;
            this.cmbLavador.SelectedIndexChanged += new System.EventHandler(this.cmbLavador_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 108;
            this.label4.Text = "Lavador:";
            // 
            // dataEntrada
            // 
            this.dataEntrada.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataEntrada.Enabled = false;
            this.dataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataEntrada.Location = new System.Drawing.Point(133, 216);
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(240, 31);
            this.dataEntrada.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(52, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 29);
            this.label10.TabIndex = 102;
            this.label10.Text = "Saida:";
            // 
            // min
            // 
            this.min.Enabled = false;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.FormattingEnabled = true;
            this.min.Location = new System.Drawing.Point(265, 247);
            this.min.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(108, 37);
            this.min.TabIndex = 9;
            // 
            // hora
            // 
            this.hora.Enabled = false;
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.FormattingEnabled = true;
            this.hora.Location = new System.Drawing.Point(133, 247);
            this.hora.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(115, 37);
            this.hora.TabIndex = 8;
            // 
            // placa
            // 
            this.placa.Enabled = false;
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(133, 44);
            this.placa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(240, 35);
            this.placa.TabIndex = 2;
            // 
            // veiculo
            // 
            this.veiculo.Enabled = false;
            this.veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculo.Location = new System.Drawing.Point(133, 149);
            this.veiculo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.veiculo.Name = "veiculo";
            this.veiculo.Size = new System.Drawing.Size(240, 35);
            this.veiculo.TabIndex = 5;
            // 
            // nome
            // 
            this.nome.Enabled = false;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(133, 79);
            this.nome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(240, 35);
            this.nome.TabIndex = 3;
            // 
            // corVeiculo
            // 
            this.corVeiculo.Enabled = false;
            this.corVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corVeiculo.Location = new System.Drawing.Point(133, 184);
            this.corVeiculo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.Size = new System.Drawing.Size(240, 35);
            this.corVeiculo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(29, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "Entrada:";
            // 
            // telefone
            // 
            this.telefone.Enabled = false;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(133, 114);
            this.telefone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(240, 35);
            this.telefone.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(73, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 29);
            this.label9.TabIndex = 97;
            this.label9.Text = "Cor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(70, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 96;
            this.label8.Text = "Tel.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(46, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 95;
            this.label7.Text = "Nome:";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVeiculo.Location = new System.Drawing.Point(32, 149);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(99, 29);
            this.lblVeiculo.TabIndex = 93;
            this.lblVeiculo.Text = "Veiculo:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlaca.Location = new System.Drawing.Point(52, 44);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(79, 29);
            this.lblPlaca.TabIndex = 91;
            this.lblPlaca.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 397);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 103;
            this.label3.Text = "Qtde:";
            // 
            // quantidade
            // 
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(631, 395);
            this.quantidade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(51, 35);
            this.quantidade.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 395);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 31);
            this.label14.TabIndex = 111;
            this.label14.Text = "Produto:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 112;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVendaAvulca);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(btnAlterarQuantidade);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.grdServico);
            this.Controls.Add(this.quantidade);
            this.MinimizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCaixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCaixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdServico;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox troco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalServico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox desconto;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnVendaAvulca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ordemServico;
        private System.Windows.Forms.CheckBox chbLavado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLavador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataEntrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hora;
        private System.Windows.Forms.TextBox placa;
        private System.Windows.Forms.TextBox veiculo;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox corVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox convenio;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}