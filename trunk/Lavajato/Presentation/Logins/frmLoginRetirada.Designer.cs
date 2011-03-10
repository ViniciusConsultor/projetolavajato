namespace HenryCorporation.Lavajato.Presentation.Logins
{
    partial class frmLoginRetirada
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Visible = false;
            // 
            // label2
            // 
            this.label2.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(263, 45);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(118, 43);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(394, 91);
            // 
            // frmLoginRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(401, 110);
            this.Name = "frmLoginRetirada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
