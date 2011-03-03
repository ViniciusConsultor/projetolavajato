namespace LavajatoMobile
{
    partial class frmAvarias
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
            this.cmbAvarias = new System.Windows.Forms.ComboBox();
            this.btnAvaria = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lstAvarias = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAvarias
            // 
            this.cmbAvarias.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.cmbAvarias.Items.Add("");
            this.cmbAvarias.Items.Add("Capo");
            this.cmbAvarias.Items.Add("Teto");
            this.cmbAvarias.Items.Add("Porta 1");
            this.cmbAvarias.Items.Add("Porta 2");
            this.cmbAvarias.Items.Add("Porta 3");
            this.cmbAvarias.Items.Add("Porta 4");
            this.cmbAvarias.Items.Add("Vidro 1");
            this.cmbAvarias.Items.Add("Vidro 2");
            this.cmbAvarias.Items.Add("Vidro 3");
            this.cmbAvarias.Items.Add("Vidro 4");
            this.cmbAvarias.Items.Add("Parabrisa");
            this.cmbAvarias.Items.Add("Vidro Traseiro");
            this.cmbAvarias.Items.Add("Para-Choque D");
            this.cmbAvarias.Items.Add("Para-Choque T");
            this.cmbAvarias.Items.Add("Lanterna D");
            this.cmbAvarias.Items.Add("Lanterna E");
            this.cmbAvarias.Items.Add("Farol D");
            this.cmbAvarias.Items.Add("Farol E");
            this.cmbAvarias.Items.Add("Porta Malas");
            this.cmbAvarias.Location = new System.Drawing.Point(3, 3);
            this.cmbAvarias.Name = "cmbAvarias";
            this.cmbAvarias.Size = new System.Drawing.Size(156, 25);
            this.cmbAvarias.TabIndex = 0;
            // 
            // btnAvaria
            // 
            this.btnAvaria.BackColor = System.Drawing.Color.Lime;
            this.btnAvaria.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAvaria.Location = new System.Drawing.Point(159, 3);
            this.btnAvaria.Name = "btnAvaria";
            this.btnAvaria.Size = new System.Drawing.Size(78, 25);
            this.btnAvaria.TabIndex = 2;
            this.btnAvaria.Text = "Adicionar";
            this.btnAvaria.Click += new System.EventHandler(this.btnAvaria_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(165, 240);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(72, 20);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lstAvarias
            // 
            this.lstAvarias.Location = new System.Drawing.Point(4, 28);
            this.lstAvarias.Name = "lstAvarias";
            this.lstAvarias.Size = new System.Drawing.Size(233, 212);
            this.lstAvarias.TabIndex = 6;
            this.lstAvarias.SelectedIndexChanged += new System.EventHandler(this.lstAvarias_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(95, 240);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 20);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmAvarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lstAvarias);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAvaria);
            this.Controls.Add(this.cmbAvarias);
            this.Menu = this.mainMenu1;
            this.Name = "frmAvarias";
            this.Text = "Avarias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAvarias;
        private System.Windows.Forms.Button btnAvaria;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox lstAvarias;
        private System.Windows.Forms.Button btnExcluir;

    }
}