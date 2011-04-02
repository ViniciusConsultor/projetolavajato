namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmRelFechamentoCaixaPorData
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
            this.reportViewFechamentoCaixa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewFechamentoCaixa
            // 
            this.reportViewFechamentoCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewFechamentoCaixa.Location = new System.Drawing.Point(0, 0);
            this.reportViewFechamentoCaixa.Name = "reportViewFechamentoCaixa";
            this.reportViewFechamentoCaixa.Size = new System.Drawing.Size(602, 273);
            this.reportViewFechamentoCaixa.TabIndex = 0;
            // 
            // frmRelatorioFechamentoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 273);
            this.Controls.Add(this.reportViewFechamentoCaixa);
            this.Name = "frmRelatorioFechamentoDeCaixa";
            this.Text = "frmRelatorioFechamentoDeCaixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelFechamentoCaixaPorData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewFechamentoCaixa;

    }
}