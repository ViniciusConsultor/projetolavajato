﻿namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmProduto
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
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabProdutoPesquisa = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nomePesquisa = new System.Windows.Forms.TextBox();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expSaldoEstoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expMinimo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expQuantidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estoqueSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minimo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.precoVenda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.precoCompra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaProduto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabProdutos.SuspendLayout();
            this.tabProdutoPesquisa.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.tabProduto.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabProdutoPesquisa);
            this.tabProdutos.Controls.Add(this.tabProduto);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(2, 3);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(701, 600);
            this.tabProdutos.TabIndex = 50;
            // 
            // tabProdutoPesquisa
            // 
            this.tabProdutoPesquisa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabProdutoPesquisa.Controls.Add(this.groupBox5);
            this.tabProdutoPesquisa.Controls.Add(this.grdProdutos);
            this.tabProdutoPesquisa.Location = new System.Drawing.Point(4, 29);
            this.tabProdutoPesquisa.Name = "tabProdutoPesquisa";
            this.tabProdutoPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutoPesquisa.Size = new System.Drawing.Size(693, 567);
            this.tabProdutoPesquisa.TabIndex = 0;
            this.tabProdutoPesquisa.Text = "Pesquisa";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.nomePesquisa);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 467);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(678, 80);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Procura por:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nome:";
            // 
            // nomePesquisa
            // 
            this.nomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePesquisa.Location = new System.Drawing.Point(9, 42);
            this.nomePesquisa.MaxLength = 50;
            this.nomePesquisa.Multiline = true;
            this.nomePesquisa.Name = "nomePesquisa";
            this.nomePesquisa.Size = new System.Drawing.Size(663, 25);
            this.nomePesquisa.TabIndex = 0;
            this.nomePesquisa.TextChanged += new System.EventHandler(this.nomePesquisa_TextChanged);
            this.nomePesquisa.Enter += new System.EventHandler(this.nomePesquisa_Enter);
            this.nomePesquisa.Leave += new System.EventHandler(this.nomePesquisa_Leave);
            // 
            // grdProdutos
            // 
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(7, 7);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.Size = new System.Drawing.Size(672, 454);
            this.grdProdutos.TabIndex = 3;
            this.grdProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdProdutos_MouseDoubleClick);
            // 
            // tabProduto
            // 
            this.tabProduto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabProduto.Controls.Add(this.groupBox6);
            this.tabProduto.Controls.Add(this.btnSalvar);
            this.tabProduto.Controls.Add(this.btnSair);
            this.tabProduto.Controls.Add(this.btnAlterar);
            this.tabProduto.Controls.Add(this.btnExcluir);
            this.tabProduto.Controls.Add(this.btnNovo);
            this.tabProduto.Controls.Add(this.groupBox4);
            this.tabProduto.Controls.Add(this.groupBox3);
            this.tabProduto.Controls.Add(this.groupBox2);
            this.tabProduto.Controls.Add(this.groupBox1);
            this.tabProduto.Location = new System.Drawing.Point(4, 29);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(693, 567);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produto";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.expSaldoEstoque);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.expMinimo);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.expQuantidade);
            this.groupBox6.Location = new System.Drawing.Point(450, 79);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(218, 111);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Expositor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saldo Est:";
            // 
            // expSaldoEstoque
            // 
            this.expSaldoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expSaldoEstoque.Enabled = false;
            this.expSaldoEstoque.Location = new System.Drawing.Point(107, 73);
            this.expSaldoEstoque.MaxLength = 50;
            this.expSaldoEstoque.Name = "expSaldoEstoque";
            this.expSaldoEstoque.Size = new System.Drawing.Size(83, 26);
            this.expSaldoEstoque.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minimo:";
            // 
            // expMinimo
            // 
            this.expMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expMinimo.Location = new System.Drawing.Point(107, 47);
            this.expMinimo.Name = "expMinimo";
            this.expMinimo.Size = new System.Drawing.Size(83, 26);
            this.expMinimo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quantidade:";
            // 
            // expQuantidade
            // 
            this.expQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expQuantidade.Location = new System.Drawing.Point(107, 21);
            this.expQuantidade.Name = "expQuantidade";
            this.expQuantidade.Size = new System.Drawing.Size(83, 26);
            this.expQuantidade.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(211, 224);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 37);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.Leave += new System.EventHandler(this.btnSalvar_Leave);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(583, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 37);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.Leave += new System.EventHandler(this.btnSair_Leave);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(107, 224);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(104, 37);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.Leave += new System.EventHandler(this.btnAlterar_Leave);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(315, 224);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 37);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.Leave += new System.EventHandler(this.btnExcluir_Leave);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(3, 224);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 37);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            this.btnNovo.Leave += new System.EventHandler(this.btnNovo_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.estoqueSaldo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.minimo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.quantidade);
            this.groupBox4.Location = new System.Drawing.Point(226, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 111);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Saldo Est:";
            // 
            // estoqueSaldo
            // 
            this.estoqueSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estoqueSaldo.Enabled = false;
            this.estoqueSaldo.Location = new System.Drawing.Point(107, 73);
            this.estoqueSaldo.MaxLength = 50;
            this.estoqueSaldo.Name = "estoqueSaldo";
            this.estoqueSaldo.Size = new System.Drawing.Size(83, 26);
            this.estoqueSaldo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minimo:";
            // 
            // minimo
            // 
            this.minimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimo.Location = new System.Drawing.Point(107, 47);
            this.minimo.Name = "minimo";
            this.minimo.Size = new System.Drawing.Size(83, 26);
            this.minimo.TabIndex = 15;
            this.minimo.TextChanged += new System.EventHandler(this.minimo_TextChanged);
            this.minimo.Enter += new System.EventHandler(this.minimo_Enter);
            this.minimo.Leave += new System.EventHandler(this.minimo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade:";
            // 
            // quantidade
            // 
            this.quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantidade.Location = new System.Drawing.Point(107, 21);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(83, 26);
            this.quantidade.TabIndex = 13;
            this.quantidade.TextChanged += new System.EventHandler(this.quantidade_TextChanged);
            this.quantidade.Enter += new System.EventHandler(this.quantidade_Enter);
            this.quantidade.Leave += new System.EventHandler(this.quantidade_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.precoVenda);
            this.groupBox3.Location = new System.Drawing.Point(3, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 51);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço de Venda";
            // 
            // precoVenda
            // 
            this.precoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precoVenda.Location = new System.Drawing.Point(15, 19);
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.Size = new System.Drawing.Size(186, 26);
            this.precoVenda.TabIndex = 10;
            this.precoVenda.TextChanged += new System.EventHandler(this.precoVenda_TextChanged);
            this.precoVenda.Enter += new System.EventHandler(this.precoVenda_Enter);
            this.precoVenda.Leave += new System.EventHandler(this.precoVenda_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.precoCompra);
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 54);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preço de Compra";
            // 
            // precoCompra
            // 
            this.precoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precoCompra.Location = new System.Drawing.Point(15, 20);
            this.precoCompra.Name = "precoCompra";
            this.precoCompra.Size = new System.Drawing.Size(186, 26);
            this.precoCompra.TabIndex = 8;
            this.precoCompra.TextChanged += new System.EventHandler(this.precoCompra_TextChanged);
            this.precoCompra.Enter += new System.EventHandler(this.precoCompra_Enter);
            this.precoCompra.Leave += new System.EventHandler(this.precoCompra_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategoriaProduto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.descricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbCategoriaProduto
            // 
            this.cmbCategoriaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaProduto.FormattingEnabled = true;
            this.cmbCategoriaProduto.Items.AddRange(new object[] {
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
            this.cmbCategoriaProduto.Location = new System.Drawing.Point(482, 35);
            this.cmbCategoriaProduto.Name = "cmbCategoriaProduto";
            this.cmbCategoriaProduto.Size = new System.Drawing.Size(178, 26);
            this.cmbCategoriaProduto.TabIndex = 6;
            this.cmbCategoriaProduto.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaProduto_SelectedIndexChanged);
            this.cmbCategoriaProduto.Enter += new System.EventHandler(this.cmbCategoriaProduto_Enter);
            this.cmbCategoriaProduto.Leave += new System.EventHandler(this.cmbCategoriaProduto_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Categoria:";
            // 
            // descricao
            // 
            this.descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricao.Location = new System.Drawing.Point(8, 35);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(474, 26);
            this.descricao.TabIndex = 4;
            this.descricao.Enter += new System.EventHandler(this.descricao_Enter);
            this.descricao.Leave += new System.EventHandler(this.descricao_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição do Produto:";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(715, 612);
            this.Controls.Add(this.tabProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutoPesquisa.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.tabProduto.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabProdutoPesquisa;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCategoriaProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precoCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox precoVenda;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nomePesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox estoqueSaldo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expSaldoEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expMinimo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox expQuantidade;
    }
}