namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmUsuario
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsuarioPesquisa = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.loginPesquisa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nomePesquisa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkOrdemEmAberto = new System.Windows.Forms.CheckBox();
            this.checkBoxCategoriaProduto = new System.Windows.Forms.CheckBox();
            this.checkBoxRelatorio = new System.Windows.Forms.CheckBox();
            this.checkBoxCaixa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOrdemServico = new System.Windows.Forms.CheckBox();
            this.checkBoxServico = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUsuario = new System.Windows.Forms.CheckBox();
            this.checkBoxProduto = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cep = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
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
            this.tabControl.SuspendLayout();
            this.tabUsuarioPesquisa.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.tabUsuario.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsuarioPesquisa);
            this.tabControl.Controls.Add(this.tabUsuario);
            this.tabControl.Location = new System.Drawing.Point(1, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(533, 462);
            this.tabControl.TabIndex = 0;
            // 
            // tabUsuarioPesquisa
            // 
            this.tabUsuarioPesquisa.Controls.Add(this.groupBox5);
            this.tabUsuarioPesquisa.Controls.Add(this.grdUsuarios);
            this.tabUsuarioPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarioPesquisa.Name = "tabUsuarioPesquisa";
            this.tabUsuarioPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarioPesquisa.Size = new System.Drawing.Size(525, 436);
            this.tabUsuarioPesquisa.TabIndex = 0;
            this.tabUsuarioPesquisa.Text = "Pesquisa";
            this.tabUsuarioPesquisa.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.loginPesquisa);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.nomePesquisa);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(3, 378);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(515, 52);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // loginPesquisa
            // 
            this.loginPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPesquisa.Location = new System.Drawing.Point(312, 25);
            this.loginPesquisa.MaxLength = 50;
            this.loginPesquisa.Name = "loginPesquisa";
            this.loginPesquisa.Size = new System.Drawing.Size(187, 21);
            this.loginPesquisa.TabIndex = 11;
            this.loginPesquisa.TextChanged += new System.EventHandler(this.loginPesquisa_TextChanged);
            this.loginPesquisa.Leave += new System.EventHandler(this.loginPesquisa_Leave);
            this.loginPesquisa.Enter += new System.EventHandler(this.loginPesquisa_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Nome:";
            // 
            // nomePesquisa
            // 
            this.nomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePesquisa.Location = new System.Drawing.Point(6, 25);
            this.nomePesquisa.MaxLength = 50;
            this.nomePesquisa.Name = "nomePesquisa";
            this.nomePesquisa.Size = new System.Drawing.Size(300, 21);
            this.nomePesquisa.TabIndex = 9;
            this.nomePesquisa.TextChanged += new System.EventHandler(this.nomePesquisa_TextChanged);
            this.nomePesquisa.Leave += new System.EventHandler(this.nomePesquisa_Leave);
            this.nomePesquisa.Enter += new System.EventHandler(this.nomePesquisa_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Login:";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Location = new System.Drawing.Point(3, 3);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.Size = new System.Drawing.Size(516, 375);
            this.grdUsuarios.TabIndex = 0;
            this.grdUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdUsuarios_MouseDoubleClick);
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.button1);
            this.tabUsuario.Controls.Add(this.groupBox6);
            this.tabUsuario.Controls.Add(this.groupBox4);
            this.tabUsuario.Controls.Add(this.groupBox3);
            this.tabUsuario.Controls.Add(this.btnSalvar);
            this.tabUsuario.Controls.Add(this.btnAlterar);
            this.tabUsuario.Controls.Add(this.btnExcluir);
            this.tabUsuario.Controls.Add(this.btnNovo);
            this.tabUsuario.Controls.Add(this.groupBox1);
            this.tabUsuario.Controls.Add(this.groupBox2);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(525, 436);
            this.tabUsuario.TabIndex = 1;
            this.tabUsuario.Text = "Usuario";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbTipoUsuario);
            this.groupBox6.Location = new System.Drawing.Point(329, 122);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(193, 41);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Funcionário";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(6, 13);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(178, 21);
            this.cmbTipoUsuario.TabIndex = 18;
            this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.rg);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cpf);
            this.groupBox4.Location = new System.Drawing.Point(329, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(193, 55);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Documentos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "RG:";
            // 
            // rg
            // 
            this.rg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg.Location = new System.Drawing.Point(87, 30);
            this.rg.MaxLength = 50;
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(99, 21);
            this.rg.TabIndex = 17;
            this.rg.Leave += new System.EventHandler(this.rg_Leave);
            this.rg.Enter += new System.EventHandler(this.rg_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "CPF:";
            // 
            // cpf
            // 
            this.cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(7, 30);
            this.cpf.MaxLength = 50;
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(80, 21);
            this.cpf.TabIndex = 16;
            this.cpf.Leave += new System.EventHandler(this.cpf_Leave);
            this.cpf.Enter += new System.EventHandler(this.cpf_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.checkOrdemEmAberto);
            this.groupBox3.Controls.Add(this.checkBoxCategoriaProduto);
            this.groupBox3.Controls.Add(this.checkBoxRelatorio);
            this.groupBox3.Controls.Add(this.checkBoxCaixa);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkBoxOrdemServico);
            this.groupBox3.Controls.Add(this.checkBoxServico);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBoxUsuario);
            this.groupBox3.Controls.Add(this.checkBoxProduto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 126);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissões";
            // 
            // checkOrdemEmAberto
            // 
            this.checkOrdemEmAberto.AutoSize = true;
            this.checkOrdemEmAberto.Location = new System.Drawing.Point(213, 91);
            this.checkOrdemEmAberto.Name = "checkOrdemEmAberto";
            this.checkOrdemEmAberto.Size = new System.Drawing.Size(136, 20);
            this.checkOrdemEmAberto.TabIndex = 24;
            this.checkOrdemEmAberto.Text = "Ordens em Aberto";
            this.checkOrdemEmAberto.UseVisualStyleBackColor = true;
            // 
            // checkBoxCategoriaProduto
            // 
            this.checkBoxCategoriaProduto.AutoSize = true;
            this.checkBoxCategoriaProduto.Location = new System.Drawing.Point(11, 91);
            this.checkBoxCategoriaProduto.Name = "checkBoxCategoriaProduto";
            this.checkBoxCategoriaProduto.Size = new System.Drawing.Size(136, 20);
            this.checkBoxCategoriaProduto.TabIndex = 21;
            this.checkBoxCategoriaProduto.Text = "Categoria Produto";
            this.checkBoxCategoriaProduto.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelatorio
            // 
            this.checkBoxRelatorio.AutoSize = true;
            this.checkBoxRelatorio.Location = new System.Drawing.Point(391, 67);
            this.checkBoxRelatorio.Name = "checkBoxRelatorio";
            this.checkBoxRelatorio.Size = new System.Drawing.Size(82, 20);
            this.checkBoxRelatorio.TabIndex = 26;
            this.checkBoxRelatorio.Text = "Relatório";
            this.checkBoxRelatorio.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaixa
            // 
            this.checkBoxCaixa.AutoSize = true;
            this.checkBoxCaixa.Location = new System.Drawing.Point(391, 43);
            this.checkBoxCaixa.Name = "checkBoxCaixa";
            this.checkBoxCaixa.Size = new System.Drawing.Size(61, 20);
            this.checkBoxCaixa.TabIndex = 25;
            this.checkBoxCaixa.Text = "Caixa";
            this.checkBoxCaixa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu Relatórios";
            // 
            // checkBoxOrdemServico
            // 
            this.checkBoxOrdemServico.AutoSize = true;
            this.checkBoxOrdemServico.Location = new System.Drawing.Point(214, 67);
            this.checkBoxOrdemServico.Name = "checkBoxOrdemServico";
            this.checkBoxOrdemServico.Size = new System.Drawing.Size(117, 20);
            this.checkBoxOrdemServico.TabIndex = 23;
            this.checkBoxOrdemServico.Text = "Ordem Serviço";
            this.checkBoxOrdemServico.UseVisualStyleBackColor = true;
            // 
            // checkBoxServico
            // 
            this.checkBoxServico.AutoSize = true;
            this.checkBoxServico.Location = new System.Drawing.Point(214, 43);
            this.checkBoxServico.Name = "checkBoxServico";
            this.checkBoxServico.Size = new System.Drawing.Size(73, 20);
            this.checkBoxServico.TabIndex = 22;
            this.checkBoxServico.Text = "Serviço";
            this.checkBoxServico.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menu Serviço";
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Location = new System.Drawing.Point(11, 67);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(74, 20);
            this.checkBoxUsuario.TabIndex = 20;
            this.checkBoxUsuario.Text = "Usuário";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBoxProduto
            // 
            this.checkBoxProduto.AutoSize = true;
            this.checkBoxProduto.Location = new System.Drawing.Point(11, 43);
            this.checkBoxProduto.Name = "checkBoxProduto";
            this.checkBoxProduto.Size = new System.Drawing.Size(74, 20);
            this.checkBoxProduto.TabIndex = 19;
            this.checkBoxProduto.Text = "Produto";
            this.checkBoxProduto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menu Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(116, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 38);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(61, 392);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 38);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(171, 392);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 38);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 392);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(55, 38);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.senha);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Location = new System.Drawing.Point(329, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 55);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Login";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Senha:";
            // 
            // senha
            // 
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(87, 30);
            this.senha.MaxLength = 50;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(99, 21);
            this.senha.TabIndex = 15;
            this.senha.Leave += new System.EventHandler(this.senha_Leave);
            this.senha.Enter += new System.EventHandler(this.senha_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Login:";
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(7, 30);
            this.login.MaxLength = 50;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(80, 21);
            this.login.TabIndex = 14;
            this.login.Leave += new System.EventHandler(this.login_Leave);
            this.login.Enter += new System.EventHandler(this.login_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cep);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cidade);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 211);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // cep
            // 
            this.cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cep.Location = new System.Drawing.Point(7, 140);
            this.cep.Mask = "99.9999-999";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(121, 20);
            this.cep.TabIndex = 10;
            this.cep.Leave += new System.EventHandler(this.cep_Leave);
            this.cep.Enter += new System.EventHandler(this.cep_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Email:";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(7, 179);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(300, 21);
            this.email.TabIndex = 13;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            this.email.Enter += new System.EventHandler(this.email_Enter);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Cidade:";
            // 
            // cidade
            // 
            this.cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(8, 105);
            this.cidade.MaxLength = 50;
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(120, 21);
            this.cidade.TabIndex = 7;
            this.cidade.Leave += new System.EventHandler(this.cidade_Leave);
            this.cidade.Enter += new System.EventHandler(this.cidade_Enter);
            // 
            // celular
            // 
            this.celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celular.Location = new System.Drawing.Point(216, 140);
            this.celular.Mask = "(00)0000-0000";
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(93, 20);
            this.celular.TabIndex = 12;
            this.celular.Leave += new System.EventHandler(this.celular_Leave);
            this.celular.Enter += new System.EventHandler(this.celular_Enter);
            // 
            // fone
            // 
            this.fone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fone.Location = new System.Drawing.Point(128, 140);
            this.fone.Mask = "(00)0000-0000";
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(88, 20);
            this.fone.TabIndex = 11;
            this.fone.Leave += new System.EventHandler(this.fone_Leave);
            this.fone.Enter += new System.EventHandler(this.fone_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fone:";
            // 
            // uf
            // 
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
            this.uf.Location = new System.Drawing.Point(237, 105);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(70, 21);
            this.uf.TabIndex = 9;
            this.uf.Leave += new System.EventHandler(this.uf_Leave);
            this.uf.Enter += new System.EventHandler(this.uf_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bairro:";
            // 
            // bairro
            // 
            this.bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(128, 105);
            this.bairro.MaxLength = 50;
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(109, 21);
            this.bairro.TabIndex = 8;
            this.bairro.Leave += new System.EventHandler(this.bairro_Leave);
            this.bairro.Enter += new System.EventHandler(this.bairro_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cep:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nº:";
            // 
            // numero
            // 
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(267, 69);
            this.numero.MaxLength = 50;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(40, 21);
            this.numero.TabIndex = 6;
            this.numero.Leave += new System.EventHandler(this.numero_Leave);
            this.numero.Enter += new System.EventHandler(this.numero_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço:";
            // 
            // endereco
            // 
            this.endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(7, 69);
            this.endereco.MaxLength = 50;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(260, 21);
            this.endereco.TabIndex = 5;
            this.endereco.Leave += new System.EventHandler(this.endereco_Leave);
            this.endereco.Enter += new System.EventHandler(this.endereco_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(7, 30);
            this.nome.MaxLength = 50;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(300, 21);
            this.nome.TabIndex = 4;
            this.nome.Leave += new System.EventHandler(this.nome_Leave);
            this.nome.Enter += new System.EventHandler(this.nome_Enter);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 467);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuários";
            this.tabControl.ResumeLayout(false);
            this.tabUsuarioPesquisa.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.tabUsuario.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsuarioPesquisa;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox celular;
        private System.Windows.Forms.MaskedTextBox fone;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxCategoriaProduto;
        private System.Windows.Forms.CheckBox checkBoxRelatorio;
        private System.Windows.Forms.CheckBox checkBoxCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxOrdemServico;
        private System.Windows.Forms.CheckBox checkBoxServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxUsuario;
        private System.Windows.Forms.CheckBox checkBoxProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox checkOrdemEmAberto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox loginPesquisa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nomePesquisa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox cep;

    }
}