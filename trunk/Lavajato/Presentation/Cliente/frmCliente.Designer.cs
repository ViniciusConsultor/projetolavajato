namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmCliente
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
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.placaPesquisa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nomePesquisa = new System.Windows.Forms.TextBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.tabManutencao = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.convenio = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cep = new System.Windows.Forms.MaskedTextBox();
            this.celular = new System.Windows.Forms.MaskedTextBox();
            this.fone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uf = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.placa = new System.Windows.Forms.MaskedTextBox();
            this.veiculo = new System.Windows.Forms.TextBox();
            this.cor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabClientes.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.tabManutencao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabConsulta);
            this.tabClientes.Controls.Add(this.tabManutencao);
            this.tabClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClientes.Location = new System.Drawing.Point(2, 3);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(753, 604);
            this.tabClientes.TabIndex = 20;
            // 
            // tabConsulta
            // 
            this.tabConsulta.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabConsulta.Controls.Add(this.groupBox4);
            this.tabConsulta.Controls.Add(this.grdClientes);
            this.tabConsulta.Location = new System.Drawing.Point(4, 29);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(745, 571);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.placaPesquisa);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.nomePesquisa);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(733, 75);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procura por:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nome:";
            // 
            // placaPesquisa
            // 
            this.placaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placaPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaPesquisa.Location = new System.Drawing.Point(6, 39);
            this.placaPesquisa.MaxLength = 50;
            this.placaPesquisa.Multiline = true;
            this.placaPesquisa.Name = "placaPesquisa";
            this.placaPesquisa.Size = new System.Drawing.Size(100, 25);
            this.placaPesquisa.TabIndex = 1;
            this.placaPesquisa.TextChanged += new System.EventHandler(this.placaPesquisa_TextChanged);
            this.placaPesquisa.Enter += new System.EventHandler(this.placaPesquisa_Enter);
            this.placaPesquisa.Leave += new System.EventHandler(this.placaPesquisa_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Placa:";
            // 
            // nomePesquisa
            // 
            this.nomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePesquisa.Location = new System.Drawing.Point(106, 39);
            this.nomePesquisa.MaxLength = 50;
            this.nomePesquisa.Multiline = true;
            this.nomePesquisa.Name = "nomePesquisa";
            this.nomePesquisa.Size = new System.Drawing.Size(615, 25);
            this.nomePesquisa.TabIndex = 2;
            this.nomePesquisa.TextChanged += new System.EventHandler(this.nomePesquisa_TextChanged);
            this.nomePesquisa.Enter += new System.EventHandler(this.nomePesquisa_Enter);
            this.nomePesquisa.Leave += new System.EventHandler(this.nomePesquisa_Leave);
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(3, 6);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(736, 446);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdClientes_MouseDoubleClick);
            // 
            // tabManutencao
            // 
            this.tabManutencao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabManutencao.Controls.Add(this.btnSair);
            this.tabManutencao.Controls.Add(this.btnSalvar);
            this.tabManutencao.Controls.Add(this.groupBox3);
            this.tabManutencao.Controls.Add(this.btnAlterar);
            this.tabManutencao.Controls.Add(this.btnExcluir);
            this.tabManutencao.Controls.Add(this.groupBox2);
            this.tabManutencao.Controls.Add(this.groupBox1);
            this.tabManutencao.Location = new System.Drawing.Point(4, 29);
            this.tabManutencao.Name = "tabManutencao";
            this.tabManutencao.Padding = new System.Windows.Forms.Padding(3);
            this.tabManutencao.Size = new System.Drawing.Size(745, 571);
            this.tabManutencao.TabIndex = 1;
            this.tabManutencao.Text = "Cliente";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(634, 367);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 38);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(6, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 38);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.convenio);
            this.groupBox3.Location = new System.Drawing.Point(4, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 59);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convênio";
            // 
            // convenio
            // 
            this.convenio.FormattingEnabled = true;
            this.convenio.Location = new System.Drawing.Point(5, 21);
            this.convenio.Name = "convenio";
            this.convenio.Size = new System.Drawing.Size(722, 28);
            this.convenio.TabIndex = 12;
            this.convenio.Enter += new System.EventHandler(this.convenio_Enter);
            this.convenio.Leave += new System.EventHandler(this.convenio_Leave);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(109, 367);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(103, 38);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(212, 367);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 38);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cep);
            this.groupBox2.Controls.Add(this.celular);
            this.groupBox2.Controls.Add(this.fone);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.uf);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.bairro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.endereco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nome);
            this.groupBox2.Location = new System.Drawing.Point(6, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 209);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // cep
            // 
            this.cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cep.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep.Location = new System.Drawing.Point(138, 130);
            this.cep.Mask = "99-999-999";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(118, 25);
            this.cep.TabIndex = 8;
            this.cep.Enter += new System.EventHandler(this.cep_Enter_1);
            this.cep.Leave += new System.EventHandler(this.cep_Leave_1);
            // 
            // celular
            // 
            this.celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celular.Location = new System.Drawing.Point(138, 176);
            this.celular.Mask = "(00)0000-0000";
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(112, 26);
            this.celular.TabIndex = 11;
            this.celular.Enter += new System.EventHandler(this.celular_Enter);
            this.celular.Leave += new System.EventHandler(this.celular_Leave);
            // 
            // fone
            // 
            this.fone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fone.Location = new System.Drawing.Point(9, 176);
            this.fone.Mask = "(00)0000-0000";
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(129, 26);
            this.fone.TabIndex = 10;
            this.fone.Enter += new System.EventHandler(this.fone_Enter);
            this.fone.Leave += new System.EventHandler(this.fone_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fone:";
            // 
            // uf
            // 
            this.uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uf.FormattingEnabled = true;
            this.uf.Items.AddRange(new object[] {
            "AC ",
            "AL ",
            "AP ",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE ",
            "TO"});
            this.uf.Location = new System.Drawing.Point(8, 130);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(130, 26);
            this.uf.TabIndex = 7;
            this.uf.Enter += new System.EventHandler(this.uf_Enter);
            this.uf.Leave += new System.EventHandler(this.uf_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bairro:";
            // 
            // bairro
            // 
            this.bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(256, 130);
            this.bairro.MaxLength = 50;
            this.bairro.Multiline = true;
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(454, 25);
            this.bairro.TabIndex = 9;
            this.bairro.Enter += new System.EventHandler(this.bairro_Enter);
            this.bairro.Leave += new System.EventHandler(this.bairro_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cep:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nº:";
            // 
            // numero
            // 
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(631, 85);
            this.numero.MaxLength = 50;
            this.numero.Multiline = true;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(79, 25);
            this.numero.TabIndex = 6;
            this.numero.Enter += new System.EventHandler(this.numero_Enter);
            this.numero.Leave += new System.EventHandler(this.numero_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço:";
            // 
            // endereco
            // 
            this.endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(6, 85);
            this.endereco.MaxLength = 50;
            this.endereco.Multiline = true;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(625, 25);
            this.endereco.TabIndex = 5;
            this.endereco.Enter += new System.EventHandler(this.endereco_Enter);
            this.endereco.Leave += new System.EventHandler(this.endereco_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(6, 40);
            this.nome.MaxLength = 50;
            this.nome.Multiline = true;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(704, 25);
            this.nome.TabIndex = 4;
            this.nome.Enter += new System.EventHandler(this.nome_Enter);
            this.nome.Leave += new System.EventHandler(this.nome_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.placa);
            this.groupBox1.Controls.Add(this.veiculo);
            this.groupBox1.Controls.Add(this.cor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Carro";
            // 
            // placa
            // 
            this.placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placa.Location = new System.Drawing.Point(5, 42);
            this.placa.Mask = "aaa-0000";
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(100, 26);
            this.placa.TabIndex = 1;
            this.placa.Enter += new System.EventHandler(this.placa_Enter);
            this.placa.Leave += new System.EventHandler(this.placa_Leave);
            // 
            // veiculo
            // 
            this.veiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.veiculo.Location = new System.Drawing.Point(205, 42);
            this.veiculo.Name = "veiculo";
            this.veiculo.Size = new System.Drawing.Size(100, 26);
            this.veiculo.TabIndex = 3;
            this.veiculo.Enter += new System.EventHandler(this.veiculo_Enter);
            this.veiculo.Leave += new System.EventHandler(this.veiculo_Leave);
            // 
            // cor
            // 
            this.cor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cor.Location = new System.Drawing.Point(105, 42);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(100, 26);
            this.cor.TabIndex = 2;
            this.cor.Enter += new System.EventHandler(this.cor_Enter);
            this.cor.Leave += new System.EventHandler(this.cor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(767, 619);
            this.Controls.Add(this.tabClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabClientes.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.tabManutencao.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.TabPage tabManutencao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox uf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox veiculo;
        private System.Windows.Forms.TextBox cor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox placaPesquisa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox nomePesquisa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox celular;
        private System.Windows.Forms.MaskedTextBox fone;
        private System.Windows.Forms.MaskedTextBox placa;
        private System.Windows.Forms.MaskedTextBox cep;
        private System.Windows.Forms.ComboBox convenio;
        private System.Windows.Forms.Button btnSair;

    }
}