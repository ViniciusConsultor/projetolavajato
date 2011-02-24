namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmProdutoRetiradoEstoqueInterno
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
            this.btnRetirada = new System.Windows.Forms.Button();
            this.txtRetirada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetirada
            // 
            this.btnRetirada.Location = new System.Drawing.Point(6, 62);
            this.btnRetirada.Name = "btnRetirada";
            this.btnRetirada.Size = new System.Drawing.Size(75, 23);
            this.btnRetirada.TabIndex = 0;
            this.btnRetirada.Text = "Retirada";
            this.btnRetirada.UseVisualStyleBackColor = true;
            this.btnRetirada.Click += new System.EventHandler(this.btnRetirada_Click);
            // 
            // txtRetirada
            // 
            this.txtRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetirada.Location = new System.Drawing.Point(6, 25);
            this.txtRetirada.Name = "txtRetirada";
            this.txtRetirada.Size = new System.Drawing.Size(156, 31);
            this.txtRetirada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "blbQuantidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(87, 62);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmProdutoRetiradoEstoqueInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 92);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRetirada);
            this.Controls.Add(this.btnRetirada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProdutoRetiradoEstoqueInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto Retirado Estoque Interno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetirada;
        private System.Windows.Forms.TextBox txtRetirada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}