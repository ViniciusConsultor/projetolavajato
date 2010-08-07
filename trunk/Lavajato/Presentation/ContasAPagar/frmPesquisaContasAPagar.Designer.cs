namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmPesquisaContasAPagar
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
            this.grdContasPagar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeCredorPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.documentoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VencendoHoje = new System.Windows.Forms.Button();
            this.MostrarTodos = new System.Windows.Forms.Button();
            this.Pagos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdContasPagar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdContasPagar
            // 
            this.grdContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContasPagar.Location = new System.Drawing.Point(1, 1);
            this.grdContasPagar.Name = "grdContasPagar";
            this.grdContasPagar.Size = new System.Drawing.Size(551, 271);
            this.grdContasPagar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeCredorPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.documentoPesquisa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // nomeCredorPesquisa
            // 
            this.nomeCredorPesquisa.Location = new System.Drawing.Point(121, 25);
            this.nomeCredorPesquisa.Name = "nomeCredorPesquisa";
            this.nomeCredorPesquisa.Size = new System.Drawing.Size(424, 20);
            this.nomeCredorPesquisa.TabIndex = 3;
            this.nomeCredorPesquisa.TextChanged += new System.EventHandler(this.nomeCredorPesquisa_TextChanged);
            this.nomeCredorPesquisa.Leave += new System.EventHandler(this.nomeCredorPesquisa_Leave);
            this.nomeCredorPesquisa.Enter += new System.EventHandler(this.nomeCredorPesquisa_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Credor:";
            // 
            // documentoPesquisa
            // 
            this.documentoPesquisa.Location = new System.Drawing.Point(7, 25);
            this.documentoPesquisa.Name = "documentoPesquisa";
            this.documentoPesquisa.Size = new System.Drawing.Size(108, 20);
            this.documentoPesquisa.TabIndex = 1;
            this.documentoPesquisa.TextChanged += new System.EventHandler(this.documentoPesquisa_TextChanged);
            this.documentoPesquisa.Leave += new System.EventHandler(this.documentoPesquisa_Leave);
            this.documentoPesquisa.Enter += new System.EventHandler(this.documentoPesquisa_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrar por:";
            // 
            // VencendoHoje
            // 
            this.VencendoHoje.Location = new System.Drawing.Point(559, 26);
            this.VencendoHoje.Name = "VencendoHoje";
            this.VencendoHoje.Size = new System.Drawing.Size(117, 25);
            this.VencendoHoje.TabIndex = 5;
            this.VencendoHoje.Text = "Vencendo Hoje";
            this.VencendoHoje.UseVisualStyleBackColor = true;
            this.VencendoHoje.Click += new System.EventHandler(this.VencendoHoje_Click);
            // 
            // MostrarTodos
            // 
            this.MostrarTodos.Location = new System.Drawing.Point(558, 51);
            this.MostrarTodos.Name = "MostrarTodos";
            this.MostrarTodos.Size = new System.Drawing.Size(117, 25);
            this.MostrarTodos.TabIndex = 7;
            this.MostrarTodos.Text = "Mostrar Todos";
            this.MostrarTodos.UseVisualStyleBackColor = true;
            this.MostrarTodos.Click += new System.EventHandler(this.MostrarTodos_Click);
            // 
            // Pagos
            // 
            this.Pagos.Location = new System.Drawing.Point(558, 76);
            this.Pagos.Name = "Pagos";
            this.Pagos.Size = new System.Drawing.Size(117, 25);
            this.Pagos.TabIndex = 8;
            this.Pagos.Text = "Pagos";
            this.Pagos.UseVisualStyleBackColor = true;
            this.Pagos.Click += new System.EventHandler(this.Pagos_Click);
            // 
            // frmPesquisaContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 334);
            this.Controls.Add(this.Pagos);
            this.Controls.Add(this.MostrarTodos);
            this.Controls.Add(this.VencendoHoje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdContasPagar);
            this.Name = "frmPesquisaContasAPagar";
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.grdContasPagar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContasPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox documentoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCredorPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VencendoHoje;
        private System.Windows.Forms.Button MostrarTodos;
        private System.Windows.Forms.Button Pagos;
    }
}