namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmProdutoAbaixoEstoque
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
            this.rvProdutoAbaixoEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvProdutoAbaixoEstoque
            // 
            this.rvProdutoAbaixoEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvProdutoAbaixoEstoque.Location = new System.Drawing.Point(0, 0);
            this.rvProdutoAbaixoEstoque.Name = "rvProdutoAbaixoEstoque";
            this.rvProdutoAbaixoEstoque.Size = new System.Drawing.Size(292, 290);
            this.rvProdutoAbaixoEstoque.TabIndex = 0;
            // 
            // frmProdutoAbaixoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 290);
            this.Controls.Add(this.rvProdutoAbaixoEstoque);
            this.Name = "frmProdutoAbaixoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutoAbaixoEstoque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProdutoAbaixoEstoque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvProdutoAbaixoEstoque;
    }
}