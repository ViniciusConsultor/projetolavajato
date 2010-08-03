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
    public partial class frmCredor : Form
    {
        private Credor credor = new Credor();
        private CredorBL credorBL = new CredorBL();

        public frmCredor()
        {
            InitializeComponent();
            CarregaDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (razaoSocial.TextLength == 0)
            {
                MessageBox.Show("Favor digitar razão social", "Atenção");
                return;
            }

            SetUpCredor();
            this.credor = credorBL.Add(this.credor);
            MessageBox.Show("Adicionado com sucesso", "Atenção");
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.credor.ID == 0)
            {
                MessageBox.Show("Nenhum credor encontrado", "Atenção");
                return;
            }

            SetUpCredor();
            credorBL.Update(this.credor);
            MessageBox.Show("Alterado com sucesso", "Atenção");
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.credor.ID == 0)
            {
                MessageBox.Show("Favor escolher um credor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show("Deseja realmente apagar o credor?", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            credorBL.Delete(this.credor);
            MessageBox.Show("Cliente apagado com sucesso!", "Atenção");
            CarregaDados();
            LimpaCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdCredor_DoubleClick(object sender, EventArgs e)
        {
            this.credor.ID = int.Parse(grdCredor.Rows[grdCredor.CurrentRow.Index].Cells[0].Value.ToString());
            this.credor = this.credorBL.ByID(this.credor);
            SetUpCampos();
            tabControl1.SelectedTab = tabPage2;
        }

        private void razaoSocialPesquisa_TextChanged(object sender, EventArgs e)
        {
            Credor crd = new Credor();
            crd.RazaoSocial = razaoSocialPesquisa.Text;
            grdCredor.DataSource = credorBL.ByRazaoSocial(crd);
        }

        private void NomeFantasiaPesquisa_TextChanged(object sender, EventArgs e)
        {
            Credor crd = new Credor();
            crd.NomeFantasia = nomeFantasiaPesquisa.Text;
            grdCredor.DataSource = credorBL.ByNomeFantasia(crd);
        }

        private void LimpaCampos()
        {
            razaoSocial.Text = "";
            nomeFantasia.Text = "";
            representante.Text = "";
            email.Text = "";
            site.Text = "";
            tipoPessoa.SelectedItem = "";

            endereco.Text = "";
            numero.Text = "";
            bairro.Text = "";
            cep.Text = "";
            uf.SelectedItem = "";
            complemento.Text = "";
            telefone.Text = "";
            fax.Text = "";
            cnpj.Text = "";
            inscEstadual.Text = "";
            cpf.Text = "";
            rg.Text = "";
        }

        private void SetUpCredor()
        {
            credor.RazaoSocial = razaoSocial.Text;
            credor.NomeFantasia = nomeFantasia.Text;
            credor.Representante = representante.Text;
            credor.Email = email.Text;
            credor.Site = site.Text;
            credor.TipoPessoa = tipoPessoa.SelectedItem.ToString().Length > 0 ? tipoPessoa.SelectedItem.ToString() : "Pessoa Jurídica";

            credor.Pessoa.Endereco = endereco.Text;
            credor.Pessoa.Numero = numero.Text;
            credor.Pessoa.Bairro = bairro.Text;
            credor.Pessoa.Cep = cep.Text;
            credor.Pessoa.UF = uf.SelectedItem != null && uf.SelectedItem.ToString().Length > 0 ? uf.SelectedItem.ToString() : "MG";
            credor.Pessoa.Complemento = complemento.Text;
            credor.Pessoa.Telefone = telefone.Text;
            credor.Pessoa.Fax = fax.Text;
            credor.Pessoa.Cnpj = cnpj.Text;
            credor.Pessoa.InsEstadual = inscEstadual.Text;
            credor.Pessoa.Cpf = cpf.Text;
            credor.Pessoa.Rg = rg.Text;
        }

        private void SetUpCampos()
        {
            razaoSocial.Text = credor.RazaoSocial;
            nomeFantasia.Text = credor.NomeFantasia;
            representante.Text = credor.Representante;
            email.Text = credor.Email;
            site.Text = credor.Site;
            tipoPessoa.SelectedItem = credor.TipoPessoa.Length == 0 ? "Pessoa Jurídica" : credor.TipoPessoa;

            endereco.Text = credor.Pessoa.Endereco;
            numero.Text = credor.Pessoa.Numero;
            bairro.Text = credor.Pessoa.Bairro;
            cep.Text = credor.Pessoa.Cep;
            uf.SelectedItem = credor.Pessoa.UF.Length > 0 ? credor.Pessoa.UF : "MG";
            complemento.Text = credor.Pessoa.Complemento;
            telefone.Text = credor.Pessoa.Telefone;
            fax.Text = credor.Pessoa.Fax;
            cnpj.Text = credor.Pessoa.Cnpj;
            inscEstadual.Text = credor.Pessoa.InsEstadual;
            cpf.Text = credor.Pessoa.Cpf;
            rg.Text = credor.Pessoa.Rg;
        }

        private void CarregaDados()
        {
            grdCredor.DataSource = credorBL.GetAll();
        }

        
    }
}
