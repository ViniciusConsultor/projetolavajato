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

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmConvenios : Form
    {
        private Convenio convenio = new Convenio();
        private ConvenioBL convenioBL = new ConvenioBL();

        public frmConvenios()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
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
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SetUpConvenio();
            this.convenio = convenioBL.Add(convenio);
            SetUpFields(this.convenio);
            btnSalvar.Enabled = false;
            CarregaDados();
            MessageBox.Show("Dados salvos com sucesso!", "Atenção");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.convenio.ID == 0)
                MessageBox.Show("Nenhuma convênio encontrado", "Atenção");

            DialogResult res = MessageBox.Show("Deseja realmente apagar o cliente?", "Atenção", MessageBoxButtons.YesNo);
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
            this.convenio.Valor = desconto.TextLength > 0 ? Convert.ToDecimal(desconto.Text) : 0;
            this.convenio.Nome = nome.Text;
            this.convenio.Endereco = endereco.Text;
            this.convenio.Numero = numero.Text;
            this.convenio.Bairro = bairro.Text;
            this.convenio.Cep = cep.Text;
            this.convenio.Cidade = cidade.Text;
            this.convenio.UF = uf.SelectedItem.ToString().Length > 0 ? uf.SelectedItem.ToString() : "MG";
            this.convenio.Telefone = fone.Text;
            this.convenio.Celular = celular.Text;

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
            desconto.Text = this.convenio.Valor.ToString();
        }

      

    }
}
