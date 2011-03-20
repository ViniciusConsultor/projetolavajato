namespace HenryCorporation.Lavajato.Presentation
{
    partial class VendaFormaPagamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotalPagamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCartaoValor = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.convenio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmando Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL DA VENDA A PAGAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVenda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.Location = new System.Drawing.Point(198, 16);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(93, 24);
            this.lblVenda.TabIndex = 4;
            this.lblVenda.Text = "lblVenda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOTAL DA VENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDinheiro);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dinheiro:";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.Location = new System.Drawing.Point(99, 14);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(325, 29);
            this.txtDinheiro.TabIndex = 6;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            this.txtDinheiro.Enter += new System.EventHandler(this.txtDinheiro_Enter);
            this.txtDinheiro.Leave += new System.EventHandler(this.txtDinheiro_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotalPagamento);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 395);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 54);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Pago:";
            // 
            // txtTotalPagamento
            // 
            this.txtTotalPagamento.Enabled = false;
            this.txtTotalPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagamento.Location = new System.Drawing.Point(99, 16);
            this.txtTotalPagamento.Name = "txtTotalPagamento";
            this.txtTotalPagamento.Size = new System.Drawing.Size(325, 29);
            this.txtTotalPagamento.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 3;
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.DropDownHeight = 110;
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.IntegralHeight = false;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(99, 14);
            this.cmbFormaPagamento.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(159, 28);
            this.cmbFormaPagamento.TabIndex = 8;
            this.cmbFormaPagamento.Enter += new System.EventHandler(this.cmbFormaPagamento_Enter);
            this.cmbFormaPagamento.Leave += new System.EventHandler(this.cmbFormaPagamento_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCartaoValor);
            this.groupBox3.Controls.Add(this.cmbFormaPagamento);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cartão:";
            // 
            // txtCartaoValor
            // 
            this.txtCartaoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartaoValor.Location = new System.Drawing.Point(258, 14);
            this.txtCartaoValor.Multiline = true;
            this.txtCartaoValor.Name = "txtCartaoValor";
            this.txtCartaoValor.Size = new System.Drawing.Size(166, 28);
            this.txtCartaoValor.TabIndex = 9;
            this.txtCartaoValor.TextChanged += new System.EventHandler(this.txtCartaoValor_TextChanged);
            this.txtCartaoValor.Enter += new System.EventHandler(this.txtCartaoValor_Enter);
            this.txtCartaoValor.Leave += new System.EventHandler(this.txtCartaoValor_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDesconto);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(15, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 54);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(99, 19);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(325, 29);
            this.txtDesconto.TabIndex = 11;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTroco);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(15, 341);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(430, 54);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Troco";
            // 
            // txtTroco
            // 
            this.txtTroco.Enabled = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(99, 19);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(325, 29);
            this.txtTroco.TabIndex = 13;
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.Location = new System.Drawing.Point(15, 452);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(158, 35);
            this.btnConcluirVenda.TabIndex = 16;
            this.btnConcluirVenda.Text = "Concluir Venda";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(335, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.convenio);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(15, 287);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(430, 54);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Convenio:";
            // 
            // convenio
            // 
            this.convenio.FormattingEnabled = true;
            this.convenio.Location = new System.Drawing.Point(99, 16);
            this.convenio.Name = "convenio";
            this.convenio.Size = new System.Drawing.Size(325, 28);
            this.convenio.TabIndex = 0;
            this.convenio.SelectedIndexChanged += new System.EventHandler(this.convenio_SelectedIndexChanged);
            this.convenio.Enter += new System.EventHandler(this.convenio_Enter);
            this.convenio.Leave += new System.EventHandler(this.convenio_Leave);
            // 
            // VendaFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(454, 497);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "VendaFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma Pagamento";
            this.Load += new System.EventHandler(this.VendaFormaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTotalPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtCartaoValor;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox convenio;
    }
}