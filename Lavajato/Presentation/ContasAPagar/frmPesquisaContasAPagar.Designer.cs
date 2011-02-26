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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeCredorPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.documentoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdContasPagar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pagos = new System.Windows.Forms.Button();
            this.MostrarTodos = new System.Windows.Forms.Button();
            this.VencendoHoje = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContasPagar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomeCredorPesquisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.documentoPesquisa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // nomeCredorPesquisa
            // 
            this.nomeCredorPesquisa.Location = new System.Drawing.Point(122, 41);
            this.nomeCredorPesquisa.Name = "nomeCredorPesquisa";
            this.nomeCredorPesquisa.Size = new System.Drawing.Size(514, 26);
            this.nomeCredorPesquisa.TabIndex = 3;
            //this.nomeCredorPesquisa.TextChanged += new System.EventHandler(this.nomeCredorPesquisa_TextChanged);
            this.nomeCredorPesquisa.Enter += new System.EventHandler(this.nomeCredorPesquisa_Enter);
            this.nomeCredorPesquisa.Leave += new System.EventHandler(this.nomeCredorPesquisa_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Credor:";
            // 
            // documentoPesquisa
            // 
            this.documentoPesquisa.Location = new System.Drawing.Point(14, 41);
            this.documentoPesquisa.Name = "documentoPesquisa";
            this.documentoPesquisa.Size = new System.Drawing.Size(108, 26);
            this.documentoPesquisa.TabIndex = 1;
            //this.documentoPesquisa.TextChanged += new System.EventHandler(this.documentoPesquisa_TextChanged);
            this.documentoPesquisa.Enter += new System.EventHandler(this.documentoPesquisa_Enter);
            this.documentoPesquisa.Leave += new System.EventHandler(this.documentoPesquisa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdContasPagar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 342);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // grdContasPagar
            // 
            this.grdContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContasPagar.Location = new System.Drawing.Point(5, 11);
            this.grdContasPagar.Name = "grdContasPagar";
            this.grdContasPagar.Size = new System.Drawing.Size(631, 325);
            this.grdContasPagar.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Pagos);
            this.groupBox3.Controls.Add(this.MostrarTodos);
            this.groupBox3.Controls.Add(this.VencendoHoje);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(650, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 112);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtrar por:";
            // 
            // Pagos
            // 
            this.Pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pagos.Location = new System.Drawing.Point(6, 80);
            this.Pagos.Name = "Pagos";
            this.Pagos.Size = new System.Drawing.Size(117, 29);
            this.Pagos.TabIndex = 12;
            this.Pagos.Text = "Pagos";
            this.Pagos.UseVisualStyleBackColor = true;
            // 
            // MostrarTodos
            // 
            this.MostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarTodos.Location = new System.Drawing.Point(6, 51);
            this.MostrarTodos.Name = "MostrarTodos";
            this.MostrarTodos.Size = new System.Drawing.Size(117, 29);
            this.MostrarTodos.TabIndex = 11;
            this.MostrarTodos.Text = "Mostrar Todos";
            this.MostrarTodos.UseVisualStyleBackColor = true;
            // 
            // VencendoHoje
            // 
            this.VencendoHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VencendoHoje.Location = new System.Drawing.Point(7, 22);
            this.VencendoHoje.Name = "VencendoHoje";
            this.VencendoHoje.Size = new System.Drawing.Size(117, 29);
            this.VencendoHoje.TabIndex = 10;
            this.VencendoHoje.Text = "Vencendo Hoje";
            this.VencendoHoje.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // frmPesquisaContasAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 428);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmPesquisaContasAPagar";
            this.Text = "Pesquisa";
            //this.Load += new System.EventHandler(this.frmPesquisaContasAPagar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContasPagar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox documentoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCredorPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdContasPagar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Pagos;
        private System.Windows.Forms.Button MostrarTodos;
        private System.Windows.Forms.Button VencendoHoje;
        private System.Windows.Forms.Label label3;
    }
}