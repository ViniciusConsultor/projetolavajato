using System.Data;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation
{
    partial class frmOrdemServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdServico = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantidadeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.placa = new System.Windows.Forms.MaskedTextBox();
            this.min = new System.Windows.Forms.ComboBox();
            this.hora = new System.Windows.Forms.ComboBox();
            this.adicionarServico = new System.Windows.Forms.Button();
            this.btnCadastraCliente = new System.Windows.Forms.Button();
            this.cmdServico = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.corVeiculo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.veiculo = new System.Windows.Forms.TextBox();
            this.lblVeiculo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnGerarOrdemServico = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdServico
            // 
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.grdServico.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.grdServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdServico.DefaultCellStyle = dataGridViewCellStyle47;
            this.grdServico.Location = new System.Drawing.Point(3, 201);
            this.grdServico.MultiSelect = false;
            this.grdServico.Name = "grdServico";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.grdServico.Size = new System.Drawing.Size(788, 332);
            this.grdServico.TabIndex = 69;
            this.grdServico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdServico_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantidadeProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.telefone);
            this.groupBox1.Controls.Add(this.placa);
            this.groupBox1.Controls.Add(this.min);
            this.groupBox1.Controls.Add(this.hora);
            this.groupBox1.Controls.Add(this.adicionarServico);
            this.groupBox1.Controls.Add(this.btnCadastraCliente);
            this.groupBox1.Controls.Add(this.cmdServico);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dataEntrada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.corVeiculo);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.veiculo);
            this.groupBox1.Controls.Add(this.lblVeiculo);
            this.groupBox1.Controls.Add(this.lblPlaca);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 194);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.quantidadeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeProduto.Location = new System.Drawing.Point(539, 153);
            this.quantidadeProduto.Name = "quantidadeProduto";
            this.quantidadeProduto.Size = new System.Drawing.Size(91, 31);
            this.quantidadeProduto.TabIndex = 11;
            this.quantidadeProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.quantidadeProduto.Leave += new System.EventHandler(this.textBox1_Leave);
            this.quantidadeProduto.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 97;
            this.label2.Text = "Qtde:";
            // 
            // telefone
            // 
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(92, 83);
            this.telefone.Mask = "(99) 0000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(258, 31);
            this.telefone.TabIndex = 5;
            this.telefone.Leave += new System.EventHandler(this.telefone_Leave);
            this.telefone.Enter += new System.EventHandler(this.telefone_Enter);
            // 
            // placa
            // 
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placa.Location = new System.Drawing.Point(92, 21);
            this.placa.Mask = "AAA-0000";
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(258, 31);
            this.placa.TabIndex = 1;
            this.placa.Leave += new System.EventHandler(this.placa_Leave);
            this.placa.Enter += new System.EventHandler(this.placa_Enter_1);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.FormattingEnabled = true;
            this.min.Location = new System.Drawing.Point(630, 113);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(150, 33);
            this.min.TabIndex = 8;
            this.min.Leave += new System.EventHandler(this.min_Leave);
            this.min.Enter += new System.EventHandler(this.min_Enter);
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hora.FormattingEnabled = true;
            this.hora.Location = new System.Drawing.Point(464, 113);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(166, 33);
            this.hora.TabIndex = 7;
            this.hora.Leave += new System.EventHandler(this.hora_Leave);
            this.hora.Enter += new System.EventHandler(this.hora_Enter);
            // 
            // adicionarServico
            // 
            this.adicionarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarServico.Location = new System.Drawing.Point(630, 149);
            this.adicionarServico.Name = "adicionarServico";
            this.adicionarServico.Size = new System.Drawing.Size(150, 37);
            this.adicionarServico.TabIndex = 12;
            this.adicionarServico.Text = "Adicionar";
            this.adicionarServico.UseVisualStyleBackColor = true;
            this.adicionarServico.Click += new System.EventHandler(this.adicionarServico_Click);
            // 
            // btnCadastraCliente
            // 
            this.btnCadastraCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraCliente.Location = new System.Drawing.Point(92, 116);
            this.btnCadastraCliente.Name = "btnCadastraCliente";
            this.btnCadastraCliente.Size = new System.Drawing.Size(258, 34);
            this.btnCadastraCliente.TabIndex = 9;
            this.btnCadastraCliente.Text = "Cadastrar Cliente";
            this.btnCadastraCliente.UseVisualStyleBackColor = true;
            this.btnCadastraCliente.Click += new System.EventHandler(this.btnCadastraCliente_Click);
            // 
            // cmdServico
            // 
            this.cmdServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmdServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdServico.FormattingEnabled = true;
            this.cmdServico.Location = new System.Drawing.Point(105, 151);
            this.cmdServico.Name = "cmdServico";
            this.cmdServico.Size = new System.Drawing.Size(356, 33);
            this.cmdServico.TabIndex = 10;
            this.cmdServico.Leave += new System.EventHandler(this.cmdServico_Leave);
            this.cmdServico.Enter += new System.EventHandler(this.cmdServico_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 29);
            this.label11.TabIndex = 89;
            this.label11.Text = "Serviço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 29);
            this.label10.TabIndex = 88;
            this.label10.Text = "Saida:";
            // 
            // dataEntrada
            // 
            this.dataEntrada.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataEntrada.Enabled = false;
            this.dataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataEntrada.Location = new System.Drawing.Point(464, 80);
            this.dataEntrada.Name = "dataEntrada";
            this.dataEntrada.Size = new System.Drawing.Size(317, 31);
            this.dataEntrada.TabIndex = 6;
            this.dataEntrada.Leave += new System.EventHandler(this.dataEntrada_Leave);
            this.dataEntrada.Enter += new System.EventHandler(this.dataEntrada_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 86;
            this.label1.Text = "Entrada:";
            // 
            // corVeiculo
            // 
            this.corVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corVeiculo.Location = new System.Drawing.Point(464, 49);
            this.corVeiculo.Name = "corVeiculo";
            this.corVeiculo.Size = new System.Drawing.Size(317, 31);
            this.corVeiculo.TabIndex = 4;
            this.corVeiculo.Leave += new System.EventHandler(this.corVeiculo_Leave);
            this.corVeiculo.Enter += new System.EventHandler(this.corVeiculo_Enter);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(92, 52);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(258, 31);
            this.nome.TabIndex = 3;
            this.nome.Leave += new System.EventHandler(this.nome_Leave);
            this.nome.Enter += new System.EventHandler(this.nome_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 29);
            this.label9.TabIndex = 82;
            this.label9.Text = "Cor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 81;
            this.label8.Text = "Tel.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 80;
            this.label7.Text = "Nome:";
            // 
            // veiculo
            // 
            this.veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculo.Location = new System.Drawing.Point(464, 18);
            this.veiculo.Name = "veiculo";
            this.veiculo.Size = new System.Drawing.Size(316, 31);
            this.veiculo.TabIndex = 2;
            this.veiculo.Leave += new System.EventHandler(this.veiculo_Leave);
            this.veiculo.Enter += new System.EventHandler(this.veiculo_Enter);
            // 
            // lblVeiculo
            // 
            this.lblVeiculo.AutoSize = true;
            this.lblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculo.Location = new System.Drawing.Point(362, 21);
            this.lblVeiculo.Name = "lblVeiculo";
            this.lblVeiculo.Size = new System.Drawing.Size(99, 29);
            this.lblVeiculo.TabIndex = 78;
            this.lblVeiculo.Text = "Veiculo:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(9, 20);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(79, 29);
            this.lblPlaca.TabIndex = 76;
            this.lblPlaca.Text = "Placa:";
            // 
            // btnGerarOrdemServico
            // 
            this.btnGerarOrdemServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarOrdemServico.Location = new System.Drawing.Point(690, 535);
            this.btnGerarOrdemServico.Name = "btnGerarOrdemServico";
            this.btnGerarOrdemServico.Size = new System.Drawing.Size(101, 40);
            this.btnGerarOrdemServico.TabIndex = 15;
            this.btnGerarOrdemServico.Text = "Concluir";
            this.btnGerarOrdemServico.UseVisualStyleBackColor = true;
            this.btnGerarOrdemServico.Click += new System.EventHandler(this.btnGerarOrdemServico_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(105, 535);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(151, 40);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Limpar Campos";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(4, 535);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 40);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 578);
            this.Controls.Add(this.btnGerarOrdemServico);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdServico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOrdemServico";
            this.Load += new System.EventHandler(this.frmOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdServico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox min;
        private System.Windows.Forms.ComboBox hora;
        private System.Windows.Forms.Button adicionarServico;
        private System.Windows.Forms.Button btnCadastraCliente;
        private System.Windows.Forms.ComboBox cmdServico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dataEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox corVeiculo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox veiculo;
        private System.Windows.Forms.Label lblVeiculo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnGerarOrdemServico;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox placa;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantidadeProduto;
        
        private ClienteBL clienteBL = new ClienteBL();
        private Cliente clienteInformacao = new Cliente();
        private Servico servico = new Servico();
        private ServicoItem servicoItem = new ServicoItem();
        private ServicoBL servicoBL = new ServicoBL();
        private DataSet dataSetItens = new DataSet();
        private DataTable dataTable = new DataTable();
        private int indexColumaDataGrid;
    }
}