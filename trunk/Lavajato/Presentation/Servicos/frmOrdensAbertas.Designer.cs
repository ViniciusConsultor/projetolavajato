namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmOrdensAbertas
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
            this.btnAtualizaListagem = new System.Windows.Forms.Button();
            this.grdOrdensAbertas = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdensAbertas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.btnAtualizaListagem);
            this.groupBox1.Controls.Add(this.grdOrdensAbertas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 584);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAtualizaListagem
            // 
            this.btnAtualizaListagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaListagem.Location = new System.Drawing.Point(5, 44);
            this.btnAtualizaListagem.Name = "btnAtualizaListagem";
            this.btnAtualizaListagem.Size = new System.Drawing.Size(710, 36);
            this.btnAtualizaListagem.TabIndex = 2;
            this.btnAtualizaListagem.Text = "Atualiza listagem de carros não lavados";
            this.btnAtualizaListagem.UseVisualStyleBackColor = true;
            this.btnAtualizaListagem.Click += new System.EventHandler(this.btnAtualizaListagem_Click);
            // 
            // grdOrdensAbertas
            // 
            this.grdOrdensAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdensAbertas.Location = new System.Drawing.Point(5, 80);
            this.grdOrdensAbertas.Name = "grdOrdensAbertas";
            this.grdOrdensAbertas.Size = new System.Drawing.Size(710, 498);
            this.grdOrdensAbertas.TabIndex = 1;
            this.grdOrdensAbertas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdOrdensAbertas_MouseDoubleClick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(6, 18);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(708, 26);
            this.dateTimePicker.TabIndex = 3;
            // 
            // frmOrdensAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(730, 588);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmOrdensAbertas";
            this.Text = "Ordens Abertas";
            this.Load += new System.EventHandler(this.frmOrdensAbertas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdensAbertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdOrdensAbertas;
        private System.Windows.Forms.Button btnAtualizaListagem;
        private System.Windows.Forms.DateTimePicker dateTimePicker;

    }
}