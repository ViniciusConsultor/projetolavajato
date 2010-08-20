using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.Operacional;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmConvenios : Form
    {
        private Convenio convenio = new Convenio();
        private ConvenioBL convenioBL = new ConvenioBL();

        public frmConvenios()
        {
            InitializeComponent();
            CarregaDados();
        }
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.convenio.ID == 0)
                MessageBox.Show("Nenhuma convenio encontrado", "Atenção");

            SetUpConvenio();
            convenioBL.Update(convenio);
            CarregaDados();
            MessageBox.Show("Dados alterados com sucesso!", "Atenção");
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (porcentagem.TextLength > 0 && desconto.TextLength > 0)
            {
                MessageBox.Show("Deve haver somente um tipo de desconto, ou em Dinherio ou em Porcentagem", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            SetUpConvenio();
            this.convenio = convenioBL.Add(convenio);
            SetUpFields(this.convenio);
            CarregaDados();
            MessageBox.Show("Dados salvos com sucesso!", "Atenção");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.convenio.ID == 0)
                MessageBox.Show("Nenhuma convênio encontrado", "Atenção");

            DialogResult res = MessageBox.Show("Deseja realmente apagar o convênio?", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }
                      
            convenioBL.Delete(convenio);
            LimpaCampos();
            CarregaDados();
        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {

        }

        private void grdConvenios_DoubleClick(object sender, EventArgs e)
        {
            this.convenio.ID = int.Parse(grdConvenios.Rows[grdConvenios.CurrentRow.Index].Cells[0].Value.ToString());
            this.convenio = convenioBL.ByID(this.convenio);
            
            if (this.convenio.ID == 0 )
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Atenção");
                return;
            }

            SetUpFields(this.convenio);
            tabControl1.SelectedTab = tabPage2;

        }

        private void conveniadoPesquisa_TextChanged(object sender, EventArgs e)
        {
           
            Convenio con = new Convenio();
            con.Nome = conveniadoPesquisa.Text;
            grdConvenios.DataSource = convenioBL.ByName(con);
            OcultaCampos();
        }

        private void CarregaDados()
        {
            grdConvenios.DataSource = convenioBL.GetAll();
            OcultaCampos();
        }

        public void OcultaCampos()
        {
            grdConvenios.Columns[0].Visible = false;
        }


        private void LimpaCampos()
        {
            nome.Text = "";
            endereco.Text = "";
            numero.Text = "";
            bairro.Text = "";
            cep.Text = "";
            cidade.Text = "";
            uf.SelectedText = "";
            fone.Text = "";
            celular.Text = "";

            desconto.Text = "";
        }

        private Convenio SetUpConvenio()
        {
            decimal valorTemp = Configuracao.ConverteParaDecimal( desconto.Text.Trim());
            decimal porcentagemTemp = Configuracao.ConverteParaDecimal( porcentagem.Text.Trim());
            this.convenio.Valor = valorTemp;
            this.convenio.Nome = nome.Text;
            this.convenio.Endereco = endereco.Text;
            this.convenio.Numero = numero.Text;
            this.convenio.Bairro = bairro.Text;
            this.convenio.Cep = cep.Text;
            this.convenio.Cidade = cidade.Text;
            this.convenio.UF = uf.SelectedItem == null ? "MG" : uf.SelectedItem.ToString();
            this.convenio.Telefone = fone.Text;
            this.convenio.Celular = celular.Text;
            this.convenio.PorcentagemDesconto = porcentagemTemp;

            return convenio;
        }

        private void SetUpFields(Convenio convenio)
        {
            nome.Text = this.convenio.Nome;
            endereco.Text = this.convenio.Endereco;
            numero.Text = this.convenio.Numero;
            bairro.Text = this.convenio.Bairro;
            cep.Text = this.convenio.Cep;
            cidade.Text = this.convenio.Cidade;
            uf.SelectedItem = this.convenio.UF.Length > 0 ? this.convenio.UF : "MG";
            fone.Text = this.convenio.Telefone;
            celular.Text = this.convenio.Celular;
            desconto.Text = this.convenio.Valor.ToString("C").Replace("R$", "");
            porcentagem.Text = this.convenio.PorcentagemDesconto.ToString();
        }

        private void conveniadoPesquisa_Enter(object sender, EventArgs e)
        {
            conveniadoPesquisa.BackColor = Color.Yellow;
        }

        private void conveniadoPesquisa_Leave(object sender, EventArgs e)
        {
            conveniadoPesquisa.BackColor = Color.White;
        }

        private void nome_Enter(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
        }

        private void nome_Leave(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
        }

        private void endereco_Enter(object sender, EventArgs e)
        {
            endereco.BackColor = Color.Yellow;
        }

        private void endereco_Leave(object sender, EventArgs e)
        {
            endereco.BackColor = Color.White;
        }

        private void numero_Enter(object sender, EventArgs e)
        {
            numero.BackColor = Color.Yellow;
        }

        private void numero_Leave(object sender, EventArgs e)
        {
            numero.BackColor = Color.White;
        }

        private void cidade_Enter(object sender, EventArgs e)
        {
            cidade.BackColor = Color.Yellow;
        }

        private void cidade_Leave(object sender, EventArgs e)
        {
            cidade.BackColor = Color.White;
        }

        private void uf_Enter(object sender, EventArgs e)
        {
            uf.BackColor = Color.Yellow;
        }

        private void uf_Leave(object sender, EventArgs e)
        {
            uf.BackColor = Color.White;
        }

        private void cep_Enter(object sender, EventArgs e)
        {
            cep.BackColor = Color.Yellow;
        }

        private void cep_Leave(object sender, EventArgs e)
        {
            cep.BackColor = Color.White;
        }

        private void bairro_Enter(object sender, EventArgs e)
        {
            bairro.BackColor = Color.Yellow;
        }

        private void bairro_Leave(object sender, EventArgs e)
        {
            bairro.BackColor = Color.White;
        }

        private void celular_Enter(object sender, EventArgs e)
        {
            celular.BackColor = Color.Yellow;
        }

        private void celular_Leave(object sender, EventArgs e)
        {
            celular.BackColor = Color.White;
        }

        private void desconto_Enter(object sender, EventArgs e)
        {
            desconto.BackColor = Color.Yellow;
        }

        private void desconto_Leave(object sender, EventArgs e)
        {
            desconto.BackColor = Color.White;
        }

        private void fone_Enter(object sender, EventArgs e)
        {
            fone.BackColor = Color.Yellow;
        }
        
        private void fone_Leave(object sender, EventArgs e)
        {
        fone.BackColor = Color.White;
        }

        private void desconto_TextChanged(object sender, EventArgs e)
        {
            if (desconto.Text.Contains("."))
            {
                desconto.Text = desconto.Text.Remove(desconto.Text.Length - 1);
                desconto.SelectionStart = desconto.Text.Length;
            }
        }

        private void porcentagem_TextChanged(object sender, EventArgs e)
        {
            if (porcentagem.Text.Contains("."))
            {
                porcentagem.Text = desconto.Text.Remove(porcentagem.Text.Length - 1);
                porcentagem.SelectionStart = porcentagem.Text.Length;
            }
        }

    }
}
