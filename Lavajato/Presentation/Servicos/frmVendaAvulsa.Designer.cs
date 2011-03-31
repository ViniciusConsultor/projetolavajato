namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmVendaAvulsa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdServico = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAlterarQuantidade = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdServico);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 195);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // grdServico
            // 
            this.grdServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServico.Location = new System.Drawing.Point(4, 12);
            this.grdServico.Name = "grdServico";
            this.grdServico.Size = new System.Drawing.Size(292, 179);
            this.grdServico.TabIndex = 10;
            this.grdServico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdServico_MouseClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "Modulo de Venda Avulsa";
            // 
            // lblOperador
            // 
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(12, 33);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(311, 27);
            this.lblOperador.TabIndex = 13;
            this.lblOperador.Text = "operador";
            // 
            // cmbProduto
            // 
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(7, 37);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(281, 28);
            this.cmbProduto.TabIndex = 0;
            this.cmbProduto.Enter += new System.EventHandler(this.cmbProduto_Enter);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "QTDE:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(6, 89);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(278, 26);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(312, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(191, 117);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(92, 26);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(4, 256);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(139, 23);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Venda";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAlterarQuantidade
            // 
            this.btnAlterarQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarQuantidade.Location = new System.Drawing.Point(143, 256);
            this.btnAlterarQuantidade.Name = "btnAlterarQuantidade";
            this.btnAlterarQuantidade.Size = new System.Drawing.Size(115, 23);
            this.btnAlterarQuantidade.TabIndex = 7;
            this.btnAlterarQuantidade.Text = "Alterar Qtde.";
            this.btnAlterarQuantidade.UseVisualStyleBackColor = true;
            this.btnAlterarQuantidade.Click += new System.EventHandler(this.btnAlterarQuantidade_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(493, 256);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(258, 256);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTroco);
            this.groupBox3.Controls.Add(this.txtDesconto);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbFormaPagamento);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(4, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 73);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(501, 31);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(91, 31);
            this.txtTroco.TabIndex = 9;
            this.txtTroco.Enter += new System.EventHandler(this.txtTroco_Enter);
            this.txtTroco.Leave += new System.EventHandler(this.txtTroco_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(410, 31);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(91, 31);
            this.txtDesconto.TabIndex = 8;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(319, 31);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 31);
            this.txtValor.TabIndex = 7;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(405, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 25);
            this.label13.TabIndex = 99;
            this.label13.Text = "Desc.:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(494, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 98;
            this.label11.Text = "Troco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 97;
            this.label6.Text = "Valor:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(228, 31);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(91, 31);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 95;
            this.label4.Text = "Total:";
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(7, 32);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(221, 32);
            this.cmbFormaPagamento.TabIndex = 5;
            this.cmbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPagamento_SelectedIndexChanged);
            this.cmbFormaPagamento.Enter += new System.EventHandler(this.cmbFormaPagamento_Enter);
            this.cmbFormaPagamento.Leave += new System.EventHandler(this.cmbFormaPagamento_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 93;
            this.label12.Text = "For. Pag:";
            // 
            // frmVendaAvulsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(614, 283);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlterarQuantidade);
            this.Controls.Add(this.btnFinalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVendaAvulsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda Avulsa";
            this.Load += new System.EventHandler(this.frmVendaAvulsa_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdServico;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAlterarQuantidade;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
    }
}