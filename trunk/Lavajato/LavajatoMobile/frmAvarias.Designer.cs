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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAvaria = new System.Windows.Forms.Label();
            this.btnAvaria = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.comboBox1.Items.Add("");
            this.comboBox1.Items.Add("Capo");
            this.comboBox1.Items.Add("Teto");
            this.comboBox1.Items.Add("Porta 1");
            this.comboBox1.Items.Add("Porta 2");
            this.comboBox1.Items.Add("Porta 3");
            this.comboBox1.Items.Add("Porta 4");
            this.comboBox1.Items.Add("Vidro 1");
            this.comboBox1.Items.Add("Vidro 2");
            this.comboBox1.Items.Add("Vidro 3");
            this.comboBox1.Items.Add("Vidro 4");
            this.comboBox1.Items.Add("Parabrisa");
            this.comboBox1.Items.Add("Vidro Traseiro");
            this.comboBox1.Items.Add("Para-Choque D");
            this.comboBox1.Items.Add("Para-Choque T");
            this.comboBox1.Items.Add("Lanterna D");
            this.comboBox1.Items.Add("Lanterna E");
            this.comboBox1.Items.Add("Farol D");
            this.comboBox1.Items.Add("Farol E");
            this.comboBox1.Items.Add("Porta Malas");
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // lblAvaria
            // 
            this.lblAvaria.Location = new System.Drawing.Point(3, 31);
            this.lblAvaria.Name = "lblAvaria";
            this.lblAvaria.Size = new System.Drawing.Size(234, 135);
            // 
            // btnAvaria
            // 
            this.btnAvaria.Location = new System.Drawing.Point(95, 169);
            this.btnAvaria.Name = "btnAvaria";
            this.btnAvaria.Size = new System.Drawing.Size(72, 20);
            this.btnAvaria.TabIndex = 2;
            this.btnAvaria.Text = "Adicionar";
            this.btnAvaria.Click += new System.EventHandler(this.btnAvaria_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(167, 169);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(72, 20);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmAvarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAvaria);
            this.Controls.Add(this.lblAvaria);
            this.Controls.Add(this.comboBox1);
            this.Menu = this.mainMenu1;
            this.Name = "frmAvarias";
            this.Text = "Avarias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAvaria;
        private System.Windows.Forms.Button btnAvaria;
        private System.Windows.Forms.Button btnFechar;

    }
}