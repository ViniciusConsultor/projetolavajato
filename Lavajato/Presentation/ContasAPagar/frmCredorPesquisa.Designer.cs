namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmCredorPesquisa
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
            this.grdCredor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.razaoSocialPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nomeFantasiaPesquisa = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCredor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 485);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // grdCredor
            // 
            this.grdCredor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCredor.Location = new System.Drawing.Point(6, 11);
            this.grdCredor.Name = "grdCredor";
            this.grdCredor.Size = new System.Drawing.Size(569, 465);
            this.grdCredor.TabIndex = 51;
            this.grdCredor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdCredor_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.razaoSocialPesquisa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nomeFantasiaPesquisa);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 73);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            // 
            // razaoSocialPesquisa
            // 
            this.razaoSocialPesquisa.Location = new System.Drawing.Point(7, 34);
            this.razaoSocialPesquisa.Name = "razaoSocialPesquisa";
            this.razaoSocialPesquisa.Size = new System.Drawing.Size(217, 26);
            this.razaoSocialPesquisa.TabIndex = 60;
            this.razaoSocialPesquisa.TextChanged += new System.EventHandler(this.razaoSocialPesquisa_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 59;
            this.label10.Text = "Razão Social:";
            // 
            // nomeFantasiaPesquisa
            // 
            this.nomeFantasiaPesquisa.Location = new System.Drawing.Point(224, 34);
            this.nomeFantasiaPesquisa.Name = "nomeFantasiaPesquisa";
            this.nomeFantasiaPesquisa.Size = new System.Drawing.Size(350, 26);
            this.nomeFantasiaPesquisa.TabIndex = 58;
            this.nomeFantasiaPesquisa.TextChanged += new System.EventHandler(this.nomeFantasiaPesquisa_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(220, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 20);
            this.label21.TabIndex = 57;
            this.label21.Text = "Nome Fantasia:";
            // 
            // frmCredorPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(589, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCredorPesquisa";
            this.Text = "frmCredorPesquisa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCredor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdCredor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox razaoSocialPesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nomeFantasiaPesquisa;
        private System.Windows.Forms.Label label21;

    }
}