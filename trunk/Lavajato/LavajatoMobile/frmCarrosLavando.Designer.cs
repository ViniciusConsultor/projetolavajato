namespace LavajatoMobile
{
    partial class frmCarrosLavando
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.grdServicos = new System.Windows.Forms.DataGrid();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grdServicos
            // 
            this.grdServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdServicos.Location = new System.Drawing.Point(1, 26);
            this.grdServicos.Name = "grdServicos";
            this.grdServicos.Size = new System.Drawing.Size(237, 218);
            this.grdServicos.TabIndex = 0;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackColor = System.Drawing.Color.Lime;
            this.btnAtualiza.Location = new System.Drawing.Point(1, 0);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(237, 26);
            this.btnAtualiza.TabIndex = 1;
            this.btnAtualiza.Text = "Atualizar Listagem";
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(165, 244);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(72, 21);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCarrosLavando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.grdServicos);
            this.Menu = this.mainMenu1;
            this.Name = "frmCarrosLavando";
            this.Text = "Carros no Lavajato";
            this.Load += new System.EventHandler(this.frmCarrosLavando_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid grdServicos;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnFechar;
    }
}