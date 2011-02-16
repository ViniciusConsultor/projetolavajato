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
            this.nomeFantasiaPesquisa = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.grdCredor = new System.Windows.Forms.DataGridView();
            this.razaoSocialPesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCredor)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFantasiaPesquisa
            // 
            this.nomeFantasiaPesquisa.Location = new System.Drawing.Point(225, 385);
            this.nomeFantasiaPesquisa.Name = "nomeFantasiaPesquisa";
            this.nomeFantasiaPesquisa.Size = new System.Drawing.Size(217, 20);
            this.nomeFantasiaPesquisa.TabIndex = 54;
            this.nomeFantasiaPesquisa.TextChanged += new System.EventHandler(this.nomeFantasiaPesquisa_TextChanged);
            this.nomeFantasiaPesquisa.Leave += new System.EventHandler(this.nomeFantasiaPesquisa_Leave);
            this.nomeFantasiaPesquisa.Enter += new System.EventHandler(this.nomeFantasiaPesquisa_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(222, 372);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Nome Fantasia:";
            // 
            // grdCredor
            // 
            this.grdCredor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCredor.Location = new System.Drawing.Point(2, 1);
            this.grdCredor.Name = "grdCredor";
            this.grdCredor.Size = new System.Drawing.Size(440, 368);
            this.grdCredor.TabIndex = 50;
            this.grdCredor.DoubleClick += new System.EventHandler(this.grdCredor_DoubleClick);
            // 
            // razaoSocialPesquisa
            // 
            this.razaoSocialPesquisa.Location = new System.Drawing.Point(2, 385);
            this.razaoSocialPesquisa.Name = "razaoSocialPesquisa";
            this.razaoSocialPesquisa.Size = new System.Drawing.Size(217, 20);
            this.razaoSocialPesquisa.TabIndex = 56;
            this.razaoSocialPesquisa.TextChanged += new System.EventHandler(this.razaoSocialPesquisa_TextChanged_1);
            this.razaoSocialPesquisa.Leave += new System.EventHandler(this.razaoSocialPesquisa_Leave);
            this.razaoSocialPesquisa.Enter += new System.EventHandler(this.razaoSocialPesquisa_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Razão Social:";
            // 
            // frmCredorPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 406);
            this.Controls.Add(this.razaoSocialPesquisa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nomeFantasiaPesquisa);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.grdCredor);
            this.Name = "frmCredorPesquisa";
            this.Text = "frmCredorPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.grdCredor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeFantasiaPesquisa;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView grdCredor;
        private System.Windows.Forms.TextBox razaoSocialPesquisa;
        private System.Windows.Forms.Label label10;
    }
}