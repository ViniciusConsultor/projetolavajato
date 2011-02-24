namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmClientePesquisa
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.placaPesquisa = new System.Windows.Forms.TextBox();
            this.nomePesquisa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Placa:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.placaPesquisa);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.nomePesquisa);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(735, 78);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Procura por:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nome:";
            // 
            // placaPesquisa
            // 
            this.placaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placaPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placaPesquisa.Location = new System.Drawing.Point(10, 42);
            this.placaPesquisa.MaxLength = 50;
            this.placaPesquisa.Multiline = true;
            this.placaPesquisa.Name = "placaPesquisa";
            this.placaPesquisa.Size = new System.Drawing.Size(100, 25);
            this.placaPesquisa.TabIndex = 6;
            this.placaPesquisa.TextChanged += new System.EventHandler(this.placaPesquisa_TextChanged);
            this.placaPesquisa.Enter += new System.EventHandler(this.placaPesquisa_Enter);
            this.placaPesquisa.Leave += new System.EventHandler(this.placaPesquisa_Leave);
            // 
            // nomePesquisa
            // 
            this.nomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomePesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePesquisa.Location = new System.Drawing.Point(110, 42);
            this.nomePesquisa.MaxLength = 50;
            this.nomePesquisa.Multiline = true;
            this.nomePesquisa.Name = "nomePesquisa";
            this.nomePesquisa.Size = new System.Drawing.Size(615, 25);
            this.nomePesquisa.TabIndex = 7;
            this.nomePesquisa.TextChanged += new System.EventHandler(this.nomePesquisa_TextChanged);
            this.nomePesquisa.Enter += new System.EventHandler(this.nomePesquisa_Enter);
            this.nomePesquisa.Leave += new System.EventHandler(this.nomePesquisa_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdClientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 404);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(6, 12);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(720, 383);
            this.grdClientes.TabIndex = 3;
            this.grdClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdClientes_MouseDoubleClick);
            // 
            // frmClientePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(737, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmClientePesquisa";
            this.Text = "Pesquisa de Clientes";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox placaPesquisa;
        private System.Windows.Forms.TextBox nomePesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdClientes;

    }
}