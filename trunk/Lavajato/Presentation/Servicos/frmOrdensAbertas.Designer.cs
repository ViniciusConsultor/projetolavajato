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
            this.grdOrdensAbertas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdensAbertas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrdensAbertas
            // 
            this.grdOrdensAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdensAbertas.Location = new System.Drawing.Point(0, 1);
            this.grdOrdensAbertas.Name = "grdOrdensAbertas";
            this.grdOrdensAbertas.Size = new System.Drawing.Size(430, 527);
            this.grdOrdensAbertas.TabIndex = 0;
            this.grdOrdensAbertas.DoubleClick += new System.EventHandler(this.grdOrdensAbertas_DoubleClick);
            // 
            // frmOrdensAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 526);
            this.Controls.Add(this.grdOrdensAbertas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmOrdensAbertas";
            this.Text = "frmOrdensAbertas";
            this.Load += new System.EventHandler(this.frmOrdensAbertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdensAbertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrdensAbertas;
    }
}