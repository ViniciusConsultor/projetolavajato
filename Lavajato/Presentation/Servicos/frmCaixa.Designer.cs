using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmCaixa
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
            System.Windows.Forms.Button btnAlterarQuantidade;
            System.Windows.Forms.CheckBox acertoFuturo;
            this.grdServico = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ordemServico = new System.Windows.Forms.TextBox();
            this.chbLavado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.TextBox();
            this.veiculo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.corVeiculo = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.quantidade = new System.Windows.Forms.TextBox();
            btnAlterarQuantidade = new System.Windows.Forms.Button();
            acertoFuturo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterarQuantidade
            // 
            btnAlterarQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAlterarQuantidade.Location = new System.Drawing.Point(158, 490);
            btnAlterarQuantidade.Name = "btnAlterarQuantidade";
            btnAlterarQuantidade.Size = new System.Drawing.Size(169, 40);
            btnAlterarQuantidade.TabIndex = 15;
            btnAlterarQuantidade.Text = "Alterar Quantidade (F3)";
            btnAlterarQuantidade.UseVisualStyleBackColor = true;
            btnAlterarQuantidade.Click += new System.EventHandler(this.btnAlterarQuantidade_Click);
            // 
            // acertoFuturo
            // 
            acertoFuturo.AutoSize = true;
            acertoFuturo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            acertoFuturo.Location = new System.Drawing.Point(144, 280);
            acertoFuturo.Name = "acertoFuturo";
            acertoFuturo.Size = new System.Drawing.Size(154, 29);
            acertoFuturo.TabIndex = 8;
            acertoFuturo.Text = "Acerto futuro";
            acertoFuturo.UseVisualStyleBackColor = true;
            acertoFuturo.Visible = false;
            acertoFuturo.CheckedChanged += new System.EventHandler(this.acertoFuturo_CheckedChanged);
            // 
            // grdServico
            // 
            this.grdServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServico.Location = new System.Drawing.Point(391, 1);
            this.grdServico.Name = "grdServico";
            this.grdServico.Size = new System.Drawing.Size(402, 413);
            this.grdServico.TabIndex = 27;
            this.grdServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdServico_KeyDown);
            this.grdServico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdServico_MouseClick);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(710, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 40);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(327, 490);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(129, 40);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir Item (F5)";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.Location = new System.Drawing.Point(2, 490);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(156, 40);
            this.btnConcluirVenda.TabIndex = 14;
            this.btnConcluirVenda.Text = "Concluir Venda (F2)";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.Location = new System.Drawing.Point(456, 490);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(146, 40);
            this.btnCancelarVenda.TabIndex = 17;
            this.btnCancelarVenda.Text = "Cancelar Venda (F6)";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ordemServico);
            this.groupBox2.Controls.Add(this.chbLavado);
            this.groupBox2.Controls.Add(acertoFuturo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.placa);
            this.groupBox2.Controls.Add(this.veiculo);
            this.groupBox2.Controls.Add(this.nome);
            this.groupBox2.Controls.Add(this.corVeiculo);
            this.groupBox2.Controls.Add(this.telefone);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblVeiculo);
            this.groupBox2.Controls.Add(this.lblPlaca);
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 413);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Incluir Lavador no Serviço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordemServico
            // 
            this.ordemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordemServico.Location = new System.Drawing.Point(142, 11);
            this.ordemServico.Name = "ordemServico";
            this.ordemServico.Size = new System.Drawing.Size(240, 31);
            this.ordemServico.TabIndex = 0;
            this.ordemServico.Enter += new System.EventHandler(this.ordemServico_Enter);
            this.ordemServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ordemServico_KeyDown);
            this.ordemServico.Leave += new System.EventHandler(this.ordemServico_Leave);
            // 
            // chbLavado
            // 
            this.chbLavado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLavado.Location = new System.Drawing.Point(144, 251);
            this.chbLavado.Name = "chbLavado";
            this.chbLavado.Size = new System.Drawing.Size(240, 29);
            this.chbLavado.TabIndex = 7;
            this.chbLavado.Text = "Lavado";
            this.chbLavado.UseVisualStyleBackColor = true;
            this.chbLavado.CheckedChanged += new System.EventHandler(this.chbLavado_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ord. Serv.:";
            // 
            // placa
            // 
            this.placa.Enabled = false;
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(142, 43);
            this.placa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(240, 35);
            this.placa.TabIndex = 1;
            // 
            // veiculo
            // 
            this.veiculo.Enabled = false;
            this.veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculo.Location = new System.Drawing.Point(142, 148);
            this.veiculo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.veiculo.Name = "veiculo";
            this.veiculo.Size = new System.Drawing.Size(240, 35);
            this.veiculo.TabIndex = 4;
            // 
            // nome
            // 
            this.nome.Enabled = false;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(142, 78);
            this.nome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(240, 35);
            this.nome.TabIndex = 2;
            // 
            // corVeiculo
            // 
            this.corVeiculo.Enabled = false;
            this.corVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corVeiculo.Location = new System.Drawing.Point(142, 183);
            this.corVeiculo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.Size = new System.Drawing.Size(240, 35);
            this.corVeiculo.TabIndex = 5;
            // 
            // telefone
            // 
            this.telefone.Enabled = false;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(142, 113);
            this.telefone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(240, 35);
            this.telefone.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(84, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 29);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(81, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tel.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(57, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nome:";
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVeiculo.Location = new System.Drawing.Point(43, 151);
            this.lblVeiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(99, 29);
            this.lblVeiculo.TabIndex = 25;
            this.lblVeiculo.Text = "Veiculo:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlaca.Location = new System.Drawing.Point(63, 43);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(79, 29);
            this.lblPlaca.TabIndex = 22;
            this.lblPlaca.Text = "Placa:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnAdicionar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbProduto);
            this.groupBox3.Controls.Add(this.quantidade);
            this.groupBox3.Location = new System.Drawing.Point(2, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 64);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 31);
            this.label14.TabIndex = 9;
            this.label14.Text = "Produto:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(673, 19);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 35);
            this.btnAdicionar.TabIndex = 13;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Qtde:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(123, 19);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(422, 33);
            this.cmbProduto.TabIndex = 10;
            this.cmbProduto.Enter += new System.EventHandler(this.cmbProduto_Enter);
            this.cmbProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduto_KeyDown);
            this.cmbProduto.Leave += new System.EventHandler(this.cmbProduto_Leave);
            // 
            // quantidade
            // 
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(617, 19);
            this.quantidade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(56, 35);
            this.quantidade.TabIndex = 12;
            this.quantidade.Enter += new System.EventHandler(this.quantidade_Enter);
            this.quantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantidade_KeyDown);
            this.quantidade.Leave += new System.EventHandler(this.quantidade_Leave);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(798, 537);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdServico);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(btnAlterarQuantidade);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnConcluirVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdServico;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ordemServico;
        private System.Windows.Forms.CheckBox chbLavado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox placa;
        private System.Windows.Forms.TextBox veiculo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox corVeiculo;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.ComboBox comboBox1;
        
        private Servico _servico = new Servico();
        private ServicoItem _servicoItem = new ServicoItem();
        private ServicoBL servicoBL = new ServicoBL();
        private string enter = "\r\n";

        private string total;
        private string valorServico;
        private string descontoServico;
        private string trocoServico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Button btnSair;
    }
}