namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmProcuraServicoPorPlaca
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
            this.placa = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ordemServico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdServicos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa:";
            // 
            // placa
            // 
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(177, 66);
            this.placa.Mask = "AAA-0000";
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(298, 26);
            this.placa.TabIndex = 4;
            this.placa.TextChanged += new System.EventHandler(this.placa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ordem Serviço:";
            // 
            // ordemServico
            // 
            this.ordemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordemServico.Location = new System.Drawing.Point(177, 40);
            this.ordemServico.Name = "ordemServico";
            this.ordemServico.Size = new System.Drawing.Size(298, 26);
            this.ordemServico.TabIndex = 2;
            this.ordemServico.TextChanged += new System.EventHandler(this.ordemServico_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entrada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ordemServico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.placa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grdServicos
            // 
            this.grdServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicos.Location = new System.Drawing.Point(6, 13);
            this.grdServicos.Name = "grdServicos";
            this.grdServicos.Size = new System.Drawing.Size(469, 218);
            this.grdServicos.TabIndex = 0;
            this.grdServicos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdServicos_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdServicos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 237);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrada.Location = new System.Drawing.Point(177, 14);
            this.entrada.Name = "dateTimePicker1";
            this.entrada.Size = new System.Drawing.Size(298, 26);
            this.entrada.TabIndex = 6;
            // 
            // frmProcuraServicoPorPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(490, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmProcuraServicoPorPlaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procura Servico Por Placa";
            this.Load += new System.EventHandler(this.frmProcuraServicoPorPlaca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox placa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ordemServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker entrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdServicos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;

    }
}