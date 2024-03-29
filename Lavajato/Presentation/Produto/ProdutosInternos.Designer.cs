﻿namespace HenryCorporation.Lavajato.Presentation
{
    partial class ProdutosInternos
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabProdutos.Location = new System.Drawing.Point(0, 3);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(407, 416);
            this.tabProdutos.TabIndex = 59;
            // 
            // tabProdutoPesquisa
            // 
            this.tabProdutoPesquisa.Controls.Add(this.groupBox5);
            this.tabProdutoPesquisa.Controls.Add(this.grdProdutos);
            this.tabProdutoPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabProdutoPesquisa.Name = "tabProdutoPesquisa";
            this.tabProdutoPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabProdutoPesquisa.Size = new System.Drawing.Size(399, 390);
            this.tabProdutoPesquisa.TabIndex = 0;
            this.tabProdutoPesquisa.Text = "Pesquisa";
            this.tabProdutoPesquisa.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.nomePesquisa);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 323);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 59);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Procura por:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nome:";
            // 
            // nomePesquisa
            // 
            this.nomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePesquisa.Location = new System.Drawing.Point(8, 33);
            this.nomePesquisa.MaxLength = 50;
            this.nomePesquisa.Name = "nomePesquisa";
            this.nomePesquisa.Size = new System.Drawing.Size(378, 21);
            this.nomePesquisa.TabIndex = 61;
            // 
            // grdProdutos
            // 
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Location = new System.Drawing.Point(7, 7);
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.Size = new System.Drawing.Size(386, 310);
            this.grdProdutos.TabIndex = 60;
            this.grdProdutos.DoubleClick += new System.EventHandler(this.grdProdutos_DoubleClick);
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.btnSalvar);
            this.tabProduto.Controls.Add(this.btnSair);
            this.tabProduto.Controls.Add(this.btnAlterar);
            this.tabProduto.Controls.Add(this.btnExcluir);
            this.tabProduto.Controls.Add(this.btnNovo);
            this.tabProduto.Controls.Add(this.groupBox4);
            this.tabProduto.Controls.Add(this.groupBox3);
            this.tabProduto.Controls.Add(this.groupBox2);
            this.tabProduto.Controls.Add(this.groupBox1);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(399, 390);
            this.tabProduto.TabIndex = 1;
            this.tabProduto.Text = "Produto";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(112, 165);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 38);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(222, 165);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 38);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(57, 165);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 38);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(167, 165);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 38);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(2, 165);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(55, 38);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.minimo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.quantidade);
            this.groupBox4.Location = new System.Drawing.Point(125, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 100);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Saldo Est:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(69, 55);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Minimo:";
            // 
            // minimo
            // 
            this.minimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimo.Location = new System.Drawing.Point(69, 35);
            this.minimo.Name = "minimo";
            this.minimo.Size = new System.Drawing.Size(83, 20);
            this.minimo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantidade:";
            // 
            // quantidade
            // 
            this.quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantidade.Location = new System.Drawing.Point(69, 15);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(83, 20);
            this.quantidade.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.precoVenda);
            this.groupBox3.Location = new System.Drawing.Point(2, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(117, 47);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preço de Venda";
            // 
            // precoVenda
            // 
            this.precoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precoVenda.Location = new System.Drawing.Point(4, 19);
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.Size = new System.Drawing.Size(104, 20);
            this.precoVenda.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.precoCompra);
            this.groupBox2.Location = new System.Drawing.Point(2, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 47);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preço de Compra";
            // 
            // precoCompra
            // 
            this.precoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.precoCompra.Location = new System.Drawing.Point(4, 19);
            this.precoCompra.Name = "precoCompra";
            this.precoCompra.Size = new System.Drawing.Size(104, 20);
            this.precoCompra.TabIndex = 3;
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
            this.groupBox1.Size = new System.Drawing.Size(391, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cmbCategoriaProduto
            // 
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
            this.cmbCategoriaProduto.Location = new System.Drawing.Point(287, 27);
            this.cmbCategoriaProduto.Name = "cmbCategoriaProduto";
            this.cmbCategoriaProduto.Size = new System.Drawing.Size(97, 21);
            this.cmbCategoriaProduto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria:";
            // 
            // descricao
            // 
            this.descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descricao.Location = new System.Drawing.Point(6, 28);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(275, 20);
            this.descricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descrição do Produto:";
            // 
            // ProdutosInternos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 422);
            this.Controls.Add(this.tabProdutos);
            this.Name = "ProdutosInternos";
            this.Text = "Produtos Internos";
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutoPesquisa.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.tabProduto.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nomePesquisa;
        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox precoVenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox precoCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategoriaProduto;
    }
}