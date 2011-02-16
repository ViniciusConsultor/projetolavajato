namespace HenryCorporation.Lavajato.Presentation
{
    partial class ServicoLavador
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cmbLavador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(390, 1);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(98, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar +";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cmbLavador
            // 
            this.cmbLavador.FormattingEnabled = true;
            this.cmbLavador.Location = new System.Drawing.Point(61, -1);
            this.cmbLavador.Name = "cmbLavador";
            this.cmbLavador.Size = new System.Drawing.Size(325, 21);
            this.cmbLavador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lavador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serviço:";
            // 
            // cmbServico
            // 
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(61, 20);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(325, 21);
            this.cmbServico.TabIndex = 2;
            // 
            // ServicoLavador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 43);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbServico);
            this.Controls.Add(this.cmbLavador);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "ServicoLavador";
            this.Text = "ServicoLavador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cmbLavador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbServico;
    }
}