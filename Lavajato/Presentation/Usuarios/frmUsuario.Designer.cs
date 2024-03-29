﻿namespace HenryCorporation.Lavajato.Presentation
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
            this.checkBoxServicoCancelado = new System.Windows.Forms.CheckBox();
            this.checkBoxServicoPorOS = new System.Windows.Forms.CheckBox();
            this.checkBoxCarrosNoLavajato = new System.Windows.Forms.CheckBox();
            this.checkBoxRelLavagemPorLavador = new System.Windows.Forms.CheckBox();
            this.checkBoxRelClientes = new System.Windows.Forms.CheckBox();
            this.checkBoxRelEstoque = new System.Windows.Forms.CheckBox();
            this.checkBoxRelCaixaPorData = new System.Windows.Forms.CheckBox();
            this.checkBoxCancelaOrdemServicoFinalizada = new System.Windows.Forms.CheckBox();
            this.checkBoxIncluirLavadorNoServico = new System.Windows.Forms.CheckBox();
            this.checkBoxCredor = new System.Windows.Forms.CheckBox();
            this.checkBoxConvenio = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.checkOrdemEmAberto = new System.Windows.Forms.CheckBox();
            this.checkBoxRelCaixa = new System.Windows.Forms.CheckBox();
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
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(1, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(692, 613);
            this.tabControl.TabIndex = 8;
            // 
            // tabUsuarioPesquisa
            // 
            this.tabUsuarioPesquisa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabUsuarioPesquisa.Controls.Add(this.groupBox5);
            this.tabUsuarioPesquisa.Controls.Add(this.grdUsuarios);
            this.tabUsuarioPesquisa.Location = new System.Drawing.Point(4, 29);
            this.tabUsuarioPesquisa.Name = "tabUsuarioPesquisa";
            this.tabUsuarioPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarioPesquisa.Size = new System.Drawing.Size(684, 580);
            this.tabUsuarioPesquisa.TabIndex = 0;
            this.tabUsuarioPesquisa.Text = "Pesquisa";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.loginPesquisa);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.nomePesquisa);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(3, 449);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 74);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // loginPesquisa
            // 
            this.loginPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPesquisa.Location = new System.Drawing.Point(384, 33);
            this.loginPesquisa.MaxLength = 50;
            this.loginPesquisa.Name = "loginPesquisa";
            this.loginPesquisa.Size = new System.Drawing.Size(288, 26);
            this.loginPesquisa.TabIndex = 5;
            this.loginPesquisa.TextChanged += new System.EventHandler(this.loginPesquisa_TextChanged);
            this.loginPesquisa.Enter += new System.EventHandler(this.loginPesquisa_Enter);
            this.loginPesquisa.Leave += new System.EventHandler(this.loginPesquisa_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nome:";
            // 
            // nomePesquisa
            // 
            this.nomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePesquisa.Location = new System.Drawing.Point(6, 33);
            this.nomePesquisa.MaxLength = 50;
            this.nomePesquisa.Name = "nomePesquisa";
            this.nomePesquisa.Size = new System.Drawing.Size(378, 26);
            this.nomePesquisa.TabIndex = 3;
            this.nomePesquisa.TextChanged += new System.EventHandler(this.nomePesquisa_TextChanged);
            this.nomePesquisa.Enter += new System.EventHandler(this.nomePesquisa_Enter);
            this.nomePesquisa.Leave += new System.EventHandler(this.nomePesquisa_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(380, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Login:";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Location = new System.Drawing.Point(3, 3);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.Size = new System.Drawing.Size(675, 440);
            this.grdUsuarios.TabIndex = 7;
            this.grdUsuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdUsuarios_MouseDoubleClick);
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabUsuario.Controls.Add(this.button1);
            this.tabUsuario.Controls.Add(this.groupBox6);
            this.tabUsuario.Controls.Add(this.groupBox4);
            this.tabUsuario.Controls.Add(this.groupBox3);
            this.tabUsuario.Controls.Add(this.btnSalvar);
            this.tabUsuario.Controls.Add(this.btnAlterar);
            this.tabUsuario.Controls.Add(this.btnExcluir);
            this.tabUsuario.Controls.Add(this.groupBox1);
            this.tabUsuario.Controls.Add(this.groupBox2);
            this.tabUsuario.Location = new System.Drawing.Point(4, 29);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(684, 580);
            this.tabUsuario.TabIndex = 1;
            this.tabUsuario.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbTipoUsuario);
            this.groupBox6.Location = new System.Drawing.Point(441, 165);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 55);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo de Funcionário";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(6, 20);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(218, 28);
            this.cmbTipoUsuario.TabIndex = 18;
            //this.cmbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoUsuario_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.rg);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cpf);
            this.groupBox4.Location = new System.Drawing.Point(441, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 76);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Documentos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "RG:";
            // 
            // rg
            // 
            this.rg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg.Location = new System.Drawing.Point(112, 42);
            this.rg.MaxLength = 50;
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(113, 26);
            this.rg.TabIndex = 17;
            this.rg.Enter += new System.EventHandler(this.rg_Enter);
            this.rg.Leave += new System.EventHandler(this.rg_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "CPF:";
            // 
            // cpf
            // 
            this.cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(9, 42);
            this.cpf.MaxLength = 50;
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(103, 26);
            this.cpf.TabIndex = 16;
            this.cpf.Enter += new System.EventHandler(this.cpf_Enter);
            this.cpf.Leave += new System.EventHandler(this.cpf_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.checkBoxServicoCancelado);
            this.groupBox3.Controls.Add(this.checkBoxServicoPorOS);
            this.groupBox3.Controls.Add(this.checkBoxCarrosNoLavajato);
            this.groupBox3.Controls.Add(this.checkBoxRelLavagemPorLavador);
            this.groupBox3.Controls.Add(this.checkBoxRelClientes);
            this.groupBox3.Controls.Add(this.checkBoxRelEstoque);
            this.groupBox3.Controls.Add(this.checkBoxRelCaixaPorData);
            this.groupBox3.Controls.Add(this.checkBoxCancelaOrdemServicoFinalizada);
            this.groupBox3.Controls.Add(this.checkBoxIncluirLavadorNoServico);
            this.groupBox3.Controls.Add(this.checkBoxCredor);
            this.groupBox3.Controls.Add(this.checkBoxConvenio);
            this.groupBox3.Controls.Add(this.checkBoxCliente);
            this.groupBox3.Controls.Add(this.checkOrdemEmAberto);
            this.groupBox3.Controls.Add(this.checkBoxRelCaixa);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkBoxOrdemServico);
            this.groupBox3.Controls.Add(this.checkBoxServico);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.checkBoxUsuario);
            this.groupBox3.Controls.Add(this.checkBoxProduto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 261);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissões";
            // 
            // checkBoxServicoCancelado
            // 
            this.checkBoxServicoCancelado.AutoSize = true;
            this.checkBoxServicoCancelado.Location = new System.Drawing.Point(471, 211);
            this.checkBoxServicoCancelado.Name = "checkBoxServicoCancelado";
            this.checkBoxServicoCancelado.Size = new System.Drawing.Size(160, 24);
            this.checkBoxServicoCancelado.TabIndex = 38;
            this.checkBoxServicoCancelado.Text = "Serviço Cancelado";
            this.checkBoxServicoCancelado.UseVisualStyleBackColor = true;
            // 
            // checkBoxServicoPorOS
            // 
            this.checkBoxServicoPorOS.AutoSize = true;
            this.checkBoxServicoPorOS.Location = new System.Drawing.Point(471, 187);
            this.checkBoxServicoPorOS.Name = "checkBoxServicoPorOS";
            this.checkBoxServicoPorOS.Size = new System.Drawing.Size(134, 24);
            this.checkBoxServicoPorOS.TabIndex = 37;
            this.checkBoxServicoPorOS.Text = "Serviço por OS";
            this.checkBoxServicoPorOS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarrosNoLavajato
            // 
            this.checkBoxCarrosNoLavajato.AutoSize = true;
            this.checkBoxCarrosNoLavajato.Location = new System.Drawing.Point(471, 163);
            this.checkBoxCarrosNoLavajato.Name = "checkBoxCarrosNoLavajato";
            this.checkBoxCarrosNoLavajato.Size = new System.Drawing.Size(161, 24);
            this.checkBoxCarrosNoLavajato.TabIndex = 36;
            this.checkBoxCarrosNoLavajato.Text = "Carros no Lavajato";
            this.checkBoxCarrosNoLavajato.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelLavagemPorLavador
            // 
            this.checkBoxRelLavagemPorLavador.AutoSize = true;
            this.checkBoxRelLavagemPorLavador.Location = new System.Drawing.Point(471, 139);
            this.checkBoxRelLavagemPorLavador.Name = "checkBoxRelLavagemPorLavador";
            this.checkBoxRelLavagemPorLavador.Size = new System.Drawing.Size(181, 24);
            this.checkBoxRelLavagemPorLavador.TabIndex = 35;
            this.checkBoxRelLavagemPorLavador.Text = "Lavagem por Lavador";
            this.checkBoxRelLavagemPorLavador.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelClientes
            // 
            this.checkBoxRelClientes.AutoSize = true;
            this.checkBoxRelClientes.Location = new System.Drawing.Point(471, 115);
            this.checkBoxRelClientes.Name = "checkBoxRelClientes";
            this.checkBoxRelClientes.Size = new System.Drawing.Size(85, 24);
            this.checkBoxRelClientes.TabIndex = 34;
            this.checkBoxRelClientes.Text = "Clientes";
            this.checkBoxRelClientes.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelEstoque
            // 
            this.checkBoxRelEstoque.AutoSize = true;
            this.checkBoxRelEstoque.Location = new System.Drawing.Point(471, 91);
            this.checkBoxRelEstoque.Name = "checkBoxRelEstoque";
            this.checkBoxRelEstoque.Size = new System.Drawing.Size(88, 24);
            this.checkBoxRelEstoque.TabIndex = 33;
            this.checkBoxRelEstoque.Text = "Estoque";
            this.checkBoxRelEstoque.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelCaixaPorData
            // 
            this.checkBoxRelCaixaPorData.AutoSize = true;
            this.checkBoxRelCaixaPorData.Location = new System.Drawing.Point(471, 67);
            this.checkBoxRelCaixaPorData.Name = "checkBoxRelCaixaPorData";
            this.checkBoxRelCaixaPorData.Size = new System.Drawing.Size(133, 24);
            this.checkBoxRelCaixaPorData.TabIndex = 32;
            this.checkBoxRelCaixaPorData.Text = "Caixa por Data";
            this.checkBoxRelCaixaPorData.UseVisualStyleBackColor = true;
            // 
            // checkBoxCancelaOrdemServicoFinalizada
            // 
            this.checkBoxCancelaOrdemServicoFinalizada.AutoSize = true;
            this.checkBoxCancelaOrdemServicoFinalizada.Location = new System.Drawing.Point(190, 138);
            this.checkBoxCancelaOrdemServicoFinalizada.Name = "checkBoxCancelaOrdemServicoFinalizada";
            this.checkBoxCancelaOrdemServicoFinalizada.Size = new System.Drawing.Size(270, 24);
            this.checkBoxCancelaOrdemServicoFinalizada.TabIndex = 31;
            this.checkBoxCancelaOrdemServicoFinalizada.Text = "Cancela Ordem Serviço Finalizada";
            this.checkBoxCancelaOrdemServicoFinalizada.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncluirLavadorNoServico
            // 
            this.checkBoxIncluirLavadorNoServico.AutoSize = true;
            this.checkBoxIncluirLavadorNoServico.Location = new System.Drawing.Point(190, 115);
            this.checkBoxIncluirLavadorNoServico.Name = "checkBoxIncluirLavadorNoServico";
            this.checkBoxIncluirLavadorNoServico.Size = new System.Drawing.Size(200, 24);
            this.checkBoxIncluirLavadorNoServico.TabIndex = 30;
            this.checkBoxIncluirLavadorNoServico.Text = "Incluir lavador no servico";
            this.checkBoxIncluirLavadorNoServico.UseVisualStyleBackColor = true;
            // 
            // checkBoxCredor
            // 
            this.checkBoxCredor.AutoSize = true;
            this.checkBoxCredor.Location = new System.Drawing.Point(14, 139);
            this.checkBoxCredor.Name = "checkBoxCredor";
            this.checkBoxCredor.Size = new System.Drawing.Size(76, 24);
            this.checkBoxCredor.TabIndex = 29;
            this.checkBoxCredor.Text = "Credor";
            this.checkBoxCredor.UseVisualStyleBackColor = true;
            // 
            // checkBoxConvenio
            // 
            this.checkBoxConvenio.AutoSize = true;
            this.checkBoxConvenio.Location = new System.Drawing.Point(14, 115);
            this.checkBoxConvenio.Name = "checkBoxConvenio";
            this.checkBoxConvenio.Size = new System.Drawing.Size(94, 24);
            this.checkBoxConvenio.TabIndex = 28;
            this.checkBoxConvenio.Text = "Convênio";
            this.checkBoxConvenio.UseVisualStyleBackColor = true;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Location = new System.Drawing.Point(14, 43);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(85, 24);
            this.checkBoxCliente.TabIndex = 27;
            this.checkBoxCliente.Text = "Clientes";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // checkOrdemEmAberto
            // 
            this.checkOrdemEmAberto.AutoSize = true;
            this.checkOrdemEmAberto.Location = new System.Drawing.Point(190, 91);
            this.checkOrdemEmAberto.Name = "checkOrdemEmAberto";
            this.checkOrdemEmAberto.Size = new System.Drawing.Size(158, 24);
            this.checkOrdemEmAberto.TabIndex = 24;
            this.checkOrdemEmAberto.Text = "Ordens em Aberto";
            this.checkOrdemEmAberto.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelCaixa
            // 
            this.checkBoxRelCaixa.AutoSize = true;
            this.checkBoxRelCaixa.Location = new System.Drawing.Point(471, 43);
            this.checkBoxRelCaixa.Name = "checkBoxRelCaixa";
            this.checkBoxRelCaixa.Size = new System.Drawing.Size(67, 24);
            this.checkBoxRelCaixa.TabIndex = 25;
            this.checkBoxRelCaixa.Text = "Caixa";
            this.checkBoxRelCaixa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu Relatórios";
            // 
            // checkBoxOrdemServico
            // 
            this.checkBoxOrdemServico.AutoSize = true;
            this.checkBoxOrdemServico.Location = new System.Drawing.Point(191, 67);
            this.checkBoxOrdemServico.Name = "checkBoxOrdemServico";
            this.checkBoxOrdemServico.Size = new System.Drawing.Size(132, 24);
            this.checkBoxOrdemServico.TabIndex = 23;
            this.checkBoxOrdemServico.Text = "Ordem Serviço";
            this.checkBoxOrdemServico.UseVisualStyleBackColor = true;
            // 
            // checkBoxServico
            // 
            this.checkBoxServico.AutoSize = true;
            this.checkBoxServico.Location = new System.Drawing.Point(191, 43);
            this.checkBoxServico.Name = "checkBoxServico";
            this.checkBoxServico.Size = new System.Drawing.Size(80, 24);
            this.checkBoxServico.TabIndex = 22;
            this.checkBoxServico.Text = "Serviço";
            this.checkBoxServico.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menu Serviço";
            // 
            // checkBoxUsuario
            // 
            this.checkBoxUsuario.AutoSize = true;
            this.checkBoxUsuario.Location = new System.Drawing.Point(14, 67);
            this.checkBoxUsuario.Name = "checkBoxUsuario";
            this.checkBoxUsuario.Size = new System.Drawing.Size(83, 24);
            this.checkBoxUsuario.TabIndex = 20;
            this.checkBoxUsuario.Text = "Usuário";
            this.checkBoxUsuario.UseVisualStyleBackColor = true;
            // 
            // checkBoxProduto
            // 
            this.checkBoxProduto.AutoSize = true;
            this.checkBoxProduto.Location = new System.Drawing.Point(14, 91);
            this.checkBoxProduto.Name = "checkBoxProduto";
            this.checkBoxProduto.Size = new System.Drawing.Size(84, 24);
            this.checkBoxProduto.TabIndex = 19;
            this.checkBoxProduto.Text = "Produto";
            this.checkBoxProduto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Menu Cadastro";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(7, 538);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 38);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(104, 538);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(97, 38);
            this.btnAlterar.TabIndex = 29;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(201, 538);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 38);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.senha);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Location = new System.Drawing.Point(441, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Login";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Senha:";
            // 
            // senha
            // 
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(116, 38);
            this.senha.MaxLength = 50;
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(109, 26);
            this.senha.TabIndex = 15;
            this.senha.Enter += new System.EventHandler(this.senha_Enter);
            this.senha.Leave += new System.EventHandler(this.senha_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Login:";
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(9, 38);
            this.login.MaxLength = 50;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(107, 26);
            this.login.TabIndex = 14;
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
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
            this.groupBox2.Size = new System.Drawing.Size(429, 263);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // cep
            // 
            this.cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cep.Location = new System.Drawing.Point(11, 179);
            this.cep.Mask = "99.9999-999";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(172, 26);
            this.cep.TabIndex = 10;
            this.cep.Enter += new System.EventHandler(this.cep_Enter);
            this.cep.Leave += new System.EventHandler(this.cep_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 20);
            this.label19.TabIndex = 23;
            this.label19.Text = "Email:";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(10, 225);
            this.email.MaxLength = 50;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(413, 26);
            this.email.TabIndex = 13;
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 20);
            this.label18.TabIndex = 21;
            this.label18.Text = "Cidade:";
            // 
            // cidade
            // 
            this.cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade.Location = new System.Drawing.Point(11, 133);
            this.cidade.MaxLength = 50;
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(172, 26);
            this.cidade.TabIndex = 7;
            this.cidade.Enter += new System.EventHandler(this.cidade_Enter);
            this.cidade.Leave += new System.EventHandler(this.cidade_Leave);
            // 
            // celular
            // 
            this.celular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celular.Location = new System.Drawing.Point(309, 179);
            this.celular.Mask = "(00)0000-0000";
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(114, 26);
            this.celular.TabIndex = 12;
            this.celular.Enter += new System.EventHandler(this.celular_Enter);
            this.celular.Leave += new System.EventHandler(this.celular_Leave);
            // 
            // fone
            // 
            this.fone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fone.Location = new System.Drawing.Point(183, 179);
            this.fone.Mask = "(00)0000-0000";
            this.fone.Name = "fone";
            this.fone.Size = new System.Drawing.Size(126, 26);
            this.fone.TabIndex = 11;
            this.fone.Enter += new System.EventHandler(this.fone_Enter);
            this.fone.Leave += new System.EventHandler(this.fone_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Celular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 159);
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
            this.uf.Location = new System.Drawing.Point(340, 133);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(83, 26);
            this.uf.TabIndex = 9;
            this.uf.Enter += new System.EventHandler(this.uf_Enter);
            this.uf.Leave += new System.EventHandler(this.uf_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(176, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bairro:";
            // 
            // bairro
            // 
            this.bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bairro.Location = new System.Drawing.Point(183, 133);
            this.bairro.MaxLength = 50;
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(157, 26);
            this.bairro.TabIndex = 8;
            this.bairro.Enter += new System.EventHandler(this.bairro_Enter);
            this.bairro.Leave += new System.EventHandler(this.bairro_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cep:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "UF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nº:";
            // 
            // numero
            // 
            this.numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(363, 87);
            this.numero.MaxLength = 50;
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(60, 26);
            this.numero.TabIndex = 6;
            this.numero.Enter += new System.EventHandler(this.numero_Enter);
            this.numero.Leave += new System.EventHandler(this.numero_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Endereço:";
            // 
            // endereco
            // 
            this.endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(11, 87);
            this.endereco.MaxLength = 50;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(352, 26);
            this.endereco.TabIndex = 5;
            this.endereco.Enter += new System.EventHandler(this.endereco_Enter);
            this.endereco.Leave += new System.EventHandler(this.endereco_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(10, 41);
            this.nome.MaxLength = 50;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(413, 26);
            this.nome.TabIndex = 4;
            this.nome.Enter += new System.EventHandler(this.nome_Enter);
            this.nome.Leave += new System.EventHandler(this.nome_Leave);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(700, 624);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
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
        private System.Windows.Forms.CheckBox checkBoxRelCaixa;
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
        private System.Windows.Forms.CheckBox checkBoxServicoCancelado;
        private System.Windows.Forms.CheckBox checkBoxServicoPorOS;
        private System.Windows.Forms.CheckBox checkBoxCarrosNoLavajato;
        private System.Windows.Forms.CheckBox checkBoxRelLavagemPorLavador;
        private System.Windows.Forms.CheckBox checkBoxRelClientes;
        private System.Windows.Forms.CheckBox checkBoxRelEstoque;
        private System.Windows.Forms.CheckBox checkBoxRelCaixaPorData;
        private System.Windows.Forms.CheckBox checkBoxCancelaOrdemServicoFinalizada;
        private System.Windows.Forms.CheckBox checkBoxIncluirLavadorNoServico;
        private System.Windows.Forms.CheckBox checkBoxCredor;
        private System.Windows.Forms.CheckBox checkBoxConvenio;
        private System.Windows.Forms.CheckBox checkBoxCliente;

    }
}