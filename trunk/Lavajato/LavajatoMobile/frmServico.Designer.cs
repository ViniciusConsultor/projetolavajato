namespace LavajatoMobile
{
    partial class frmServico
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
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionaProduto = new System.Windows.Forms.Button();
            this.cmdServico = new System.Windows.Forms.ComboBox();
            this.grdServico = new System.Windows.Forms.DataGrid();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qtde = new System.Windows.Forms.TextBox();
            this.btnAvarias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.Lime;
            this.btnConcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnConcluir.Location = new System.Drawing.Point(171, 166);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(67, 22);
            this.btnConcluir.TabIndex = 28;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Location = new System.Drawing.Point(1, 166);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 22);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionaProduto
            // 
            this.btnAdicionaProduto.BackColor = System.Drawing.Color.Lime;
            this.btnAdicionaProduto.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdicionaProduto.Location = new System.Drawing.Point(1, 27);
            this.btnAdicionaProduto.Name = "btnAdicionaProduto";
            this.btnAdicionaProduto.Size = new System.Drawing.Size(236, 25);
            this.btnAdicionaProduto.TabIndex = 24;
            this.btnAdicionaProduto.Text = "Adicionar";
            this.btnAdicionaProduto.Click += new System.EventHandler(this.btnAdicionaProduto_Click);
            // 
            // cmdServico
            // 
            this.cmdServico.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.cmdServico.Location = new System.Drawing.Point(0, 3);
            this.cmdServico.Name = "cmdServico";
            this.cmdServico.Size = new System.Drawing.Size(151, 24);
            this.cmdServico.TabIndex = 23;
            // 
            // grdServico
            // 
            this.grdServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdServico.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.grdServico.Location = new System.Drawing.Point(1, 52);
            this.grdServico.Name = "grdServico";
            this.grdServico.Size = new System.Drawing.Size(236, 114);
            this.grdServico.TabIndex = 27;
            this.grdServico.Click += new System.EventHandler(this.grdServico_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblTotal.Location = new System.Drawing.Point(74, 166);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(151, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.Text = "Qtde";
            // 
            // qtde
            // 
            this.qtde.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.qtde.Location = new System.Drawing.Point(186, 2);
            this.qtde.Name = "qtde";
            this.qtde.Size = new System.Drawing.Size(51, 23);
            this.qtde.TabIndex = 30;
            // 
            // btnAvarias
            // 
            this.btnAvarias.BackColor = System.Drawing.Color.Red;
            this.btnAvarias.Location = new System.Drawing.Point(171, 188);
            this.btnAvarias.Name = "btnAvarias";
            this.btnAvarias.Size = new System.Drawing.Size(67, 21);
            this.btnAvarias.TabIndex = 33;
            this.btnAvarias.Text = "Avarias";
            this.btnAvarias.Click += new System.EventHandler(this.btnAvarias_Click);
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnAvarias);
            this.Controls.Add(this.qtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionaProduto);
            this.Controls.Add(this.cmdServico);
            this.Controls.Add(this.grdServico);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmServico";
            this.Text = "Servico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionaProduto;
        private System.Windows.Forms.ComboBox cmdServico;
        private System.Windows.Forms.DataGrid grdServico;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtde;
        private System.Windows.Forms.Button btnAvarias;
    }
}