namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmContasAPagar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valorTitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.observacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.credor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataDocumento = new System.Windows.Forms.DateTimePicker();
            this.documento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serie = new System.Windows.Forms.TextBox();
            this.notaFiscal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saldoPaga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.valorPago = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.diasAtraso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valorTitulo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.observacao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tipoDocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataVencimento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.credor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataDocumento);
            this.groupBox1.Controls.Add(this.documento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.serie);
            this.groupBox1.Controls.Add(this.notaFiscal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // valorTitulo
            // 
            this.valorTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTitulo.Location = new System.Drawing.Point(370, 109);
            this.valorTitulo.Name = "valorTitulo";
            this.valorTitulo.Size = new System.Drawing.Size(106, 22);
            this.valorTitulo.TabIndex = 17;
            this.valorTitulo.Leave += new System.EventHandler(this.valorTitulo_Leave);
            this.valorTitulo.Enter += new System.EventHandler(this.valorTitulo_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(367, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Valor Título:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(437, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 21);
            this.button5.TabIndex = 6;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // observacao
            // 
            this.observacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacao.Location = new System.Drawing.Point(12, 152);
            this.observacao.Multiline = true;
            this.observacao.Name = "observacao";
            this.observacao.Size = new System.Drawing.Size(464, 71);
            this.observacao.TabIndex = 15;
            this.observacao.Leave += new System.EventHandler(this.observacao_Leave);
            this.observacao.Enter += new System.EventHandler(this.observacao_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Observação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo Documento:";
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.FormattingEnabled = true;
            this.tipoDocumento.Items.AddRange(new object[] {
            "Duplicada",
            "Boleto",
            "Cheque",
            "Promissoria",
            "Nota Fiscal",
            "Outros"});
            this.tipoDocumento.Location = new System.Drawing.Point(177, 110);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(192, 21);
            this.tipoDocumento.TabIndex = 12;
            this.tipoDocumento.Leave += new System.EventHandler(this.tipoDocumento_Leave);
            this.tipoDocumento.Enter += new System.EventHandler(this.tipoDocumento_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Vencimento:";
            // 
            // dataVencimento
            // 
            this.dataVencimento.Location = new System.Drawing.Point(12, 111);
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(159, 20);
            this.dataVencimento.TabIndex = 10;
            this.dataVencimento.Leave += new System.EventHandler(this.dataVencimento_Leave);
            this.dataVencimento.Enter += new System.EventHandler(this.dataVencimento_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Credor:";
            // 
            // credor
            // 
            this.credor.FormattingEnabled = true;
            this.credor.Location = new System.Drawing.Point(12, 73);
            this.credor.Name = "credor";
            this.credor.Size = new System.Drawing.Size(424, 21);
            this.credor.TabIndex = 8;
            this.credor.Leave += new System.EventHandler(this.credor_Leave);
            this.credor.Enter += new System.EventHandler(this.credor_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Documento:";
            // 
            // dataDocumento
            // 
            this.dataDocumento.Location = new System.Drawing.Point(278, 32);
            this.dataDocumento.Name = "dataDocumento";
            this.dataDocumento.Size = new System.Drawing.Size(198, 20);
            this.dataDocumento.TabIndex = 6;
            this.dataDocumento.Leave += new System.EventHandler(this.dataDocumento_Leave);
            this.dataDocumento.Enter += new System.EventHandler(this.dataDocumento_Enter);
            // 
            // documento
            // 
            this.documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documento.Location = new System.Drawing.Point(156, 32);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(116, 22);
            this.documento.TabIndex = 5;
            this.documento.Leave += new System.EventHandler(this.documento_Leave);
            this.documento.Enter += new System.EventHandler(this.documento_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento:";
            // 
            // serie
            // 
            this.serie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie.Location = new System.Drawing.Point(119, 32);
            this.serie.Name = "serie";
            this.serie.Size = new System.Drawing.Size(31, 22);
            this.serie.TabIndex = 3;
            this.serie.Leave += new System.EventHandler(this.serie_Leave);
            this.serie.Enter += new System.EventHandler(this.serie_Enter);
            // 
            // notaFiscal
            // 
            this.notaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaFiscal.Location = new System.Drawing.Point(12, 32);
            this.notaFiscal.Name = "notaFiscal";
            this.notaFiscal.Size = new System.Drawing.Size(101, 22);
            this.notaFiscal.TabIndex = 2;
            this.notaFiscal.Leave += new System.EventHandler(this.notaFiscal_Leave);
            this.notaFiscal.Enter += new System.EventHandler(this.notaFiscal_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Série:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota Fiscal:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saldoPaga);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.valorPago);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.diasAtraso);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataPagamento);
            this.groupBox2.Location = new System.Drawing.Point(3, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // saldoPaga
            // 
            this.saldoPaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saldoPaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoPaga.Location = new System.Drawing.Point(375, 44);
            this.saldoPaga.Name = "saldoPaga";
            this.saldoPaga.Size = new System.Drawing.Size(96, 22);
            this.saldoPaga.TabIndex = 21;
            this.saldoPaga.Leave += new System.EventHandler(this.saldoPaga_Leave);
            this.saldoPaga.Enter += new System.EventHandler(this.saldoPaga_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(372, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Saldo a Pagar:";
            // 
            // valorPago
            // 
            this.valorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorPago.Location = new System.Drawing.Point(281, 44);
            this.valorPago.Name = "valorPago";
            this.valorPago.Size = new System.Drawing.Size(88, 22);
            this.valorPago.TabIndex = 19;
            this.valorPago.Leave += new System.EventHandler(this.valorPago_Leave);
            this.valorPago.Enter += new System.EventHandler(this.valorPago_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(281, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Valor Pago:";
            // 
            // diasAtraso
            // 
            this.diasAtraso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diasAtraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diasAtraso.Location = new System.Drawing.Point(175, 44);
            this.diasAtraso.Name = "diasAtraso";
            this.diasAtraso.Size = new System.Drawing.Size(100, 22);
            this.diasAtraso.TabIndex = 17;
            this.diasAtraso.Leave += new System.EventHandler(this.diasAtraso_Leave);
            this.diasAtraso.Enter += new System.EventHandler(this.diasAtraso_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(172, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Atraso em Dias:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Data Pagamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(361, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "DADOS REFERENTES AO PAGAMENTO DESSE TITULO";
            // 
            // dataPagamento
            // 
            this.dataPagamento.Location = new System.Drawing.Point(13, 44);
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.Size = new System.Drawing.Size(159, 20);
            this.dataPagamento.TabIndex = 16;
            this.dataPagamento.Leave += new System.EventHandler(this.dataPagamento_Leave);
            this.dataPagamento.Enter += new System.EventHandler(this.dataPagamento_Enter);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(4, 311);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(55, 36);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(59, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(430, 311);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(119, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmContasAPagar";
            this.Text = "Contas a Pagar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataDocumento;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serie;
        private System.Windows.Forms.TextBox notaFiscal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox observacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tipoDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataVencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox credor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox saldoPaga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox valorPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox diasAtraso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dataPagamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox valorTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}