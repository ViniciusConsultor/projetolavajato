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
    public partial class frmUsuario : Form
    {
        private Usuario usuario = new Usuario();
        private UsuarioBL usuarioBL = new UsuarioBL();
        
        public frmUsuario()
        {
            InitializeComponent();
            CarregaTipoUsuario();
            CarregaUsuarios();
            
        }
        
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            nomePesquisa.Focus();
        }

        private void CarregaTipoUsuario()
        {
            cmbTipoUsuario.DataSource = new TipoFuncionarioBL().GetAll();
            cmbTipoUsuario.DisplayMember = "Descricao";
            cmbTipoUsuario.ValueMember = "ID";
        }

        public frmUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.usuario = ProcuraUsuario(this.usuario);
            tabControl.SelectedTab = tabUsuario;
            CarregaCampos(this.usuario);
            CarregaUsuarios();
        }

        private void CarregaUsuarios()
        {
            grdUsuarios.DataSource = usuarioBL.GetAll().Tables[0];
            grdUsuarios.Columns[0].Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if ((login.Enabled && senha.Enabled))
            {
                if (login.Text.Length == 0 || senha.Text.Length == 0)
                {
                    MessageBox.Show("Favor preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                    return;
                }
            }

            if (nome.TextLength == 0)
            {
                MessageBox.Show("Favor preencher o campo nome!", "Atenção"); 
            }

            if (usuario.ID > 0)
            {
                MessageBox.Show("Para alterar o usuário click em ALTERAR", "Atenção");
                return;
            }
                       
            SetUsuario();
            this.usuario = usuarioBL.Insert(this.usuario);
            CarregaUsuarios();
            MessageBox.Show("Usuário salvo com sucesso!", "Atenção") ;
            LimpaCampos();

        }

        private void SetUsuario()
        {
            this.usuario.Nome = nome.Text;
            this.usuario.Endereco = endereco.Text;
            this.usuario.Numero = numero.Text;
            this.usuario.UF = uf.SelectedItem  != null ? uf.SelectedItem.ToString() : "MG";
            this.usuario.Cidade = cidade.Text;
            this.usuario.Cep = cep.Text;
            this.usuario.Bairro = bairro.Text;
            this.usuario.Telefone = fone.Text;
            this.usuario.Celular = celular.Text;
            this.usuario.Email = email.Text;

            this.usuario.Login = login.Text;
            this.usuario.Password = senha.Text;
            this.usuario.Cpf = cpf.Text;
            this.usuario.RG = rg.Text;
            this.usuario.TipoFuncionario = ((TipoFuncionario)cmbTipoUsuario.SelectedItem);

            this.usuario.Permissao.OrdemServico = Convert.ToInt32(checkBoxOrdemServico.Checked);
            this.usuario.Permissao.Servico = Convert.ToInt32(checkBoxServico.Checked);
            this.usuario.Permissao.Produto = Convert.ToInt32(checkBoxProduto.Checked);
            this.usuario.Permissao.Relatorio = Convert.ToInt32(checkBoxRelatorio.Checked);
            this.usuario.Permissao.Usuario = Convert.ToInt32(checkBoxUsuario.Checked);
            this.usuario.Permissao.Caixa = Convert.ToInt32(checkBoxCaixa.Checked);
            this.usuario.Permissao.CategoriaProduto = Convert.ToInt32(checkBoxCategoriaProduto.Checked);
        }

        private void grdUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.usuario.ID = int.Parse(grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells[0].Value.ToString());
            this.usuario = ProcuraUsuario(this.usuario);
            tabControl.SelectedTab = tabUsuario;
            CarregaCampos(this.usuario);
            nome.Focus();
        }

        private void CarregaCampos(HenryCorporation.Lavajato.DomainModel.Usuario usuario)
        {
            nome.Text = this.usuario.Nome;
            endereco.Text = this.usuario.Endereco;
            numero.Text = this.usuario.Numero;
            uf.SelectedItem = this.usuario.UF.Trim();
            cep.Text = this.usuario.Cep;
            bairro.Text = this.usuario.Bairro;
            fone.Text = this.usuario.Telefone;
            celular.Text = this.usuario.Celular;
            email.Text = this.usuario.Email;
            cidade.Text = this.usuario.Cidade;
            login.Text = this.usuario.Login;
            senha.Text = this.usuario.Password;
            cpf.Text = this.usuario.Cpf;
            rg.Text = this.usuario.RG;
            cmbTipoUsuario.SelectedValue = this.usuario.TipoFuncionario.ID;


            checkBoxOrdemServico.Checked = Convert.ToBoolean(this.usuario.Permissao.OrdemServico);
            checkBoxServico.Checked = Convert.ToBoolean(this.usuario.Permissao.Servico);
            checkBoxProduto.Checked = Convert.ToBoolean(this.usuario.Permissao.Produto);
            checkBoxRelatorio.Checked = Convert.ToBoolean(this.usuario.Permissao.Relatorio);
            checkBoxUsuario.Checked = Convert.ToBoolean(this.usuario.Permissao.Usuario);
            checkBoxCaixa.Checked = Convert.ToBoolean(this.usuario.Permissao.Caixa);
            checkBoxCategoriaProduto.Checked = Convert.ToBoolean(this.usuario.Permissao.CategoriaProduto);
        }

        private HenryCorporation.Lavajato.DomainModel.Usuario ProcuraUsuario(HenryCorporation.Lavajato.DomainModel.Usuario usuario)
        {
            return usuarioBL.ByID(usuario);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.usuario.ID == 0)
            {
                MessageBox.Show("Nenhum usuário selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                return;
            }

            if (login.Text.Length == 0 || senha.Text.Length == 0)
            {
                MessageBox.Show("Favor preencher todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
                return;
            }

            SetUsuario();
            usuarioBL.Update(this.usuario);
            MessageBox.Show("Usuario alterado com sucesso!", "Atenção");
            CarregaUsuarios();
        }

        private void nomePesquisa_TextChanged(object sender, EventArgs e)
        {
            HenryCorporation.Lavajato.DomainModel.Usuario usuario = new HenryCorporation.Lavajato.DomainModel.Usuario();
            usuario.Nome = nomePesquisa.Text;
            grdUsuarios.DataSource = usuarioBL.ByName(usuario);
            OcultaCampo();
        }

        private void loginPesquisa_TextChanged(object sender, EventArgs e)
        {
            grdUsuarios.DataSource = usuarioBL.ByLogin(loginPesquisa.Text);
            OcultaCampo();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private void LimpaCampos()
        {
            nome.Clear();
            endereco.Clear();
            numero.Clear();
            uf.SelectedItem = "";
            cidade.Clear();
            cep.Clear();
            bairro.Clear();
            fone.Clear();
            celular.Clear();
            email.Clear();

            login.Clear();
            senha.Clear();
            cpf.Clear();
            rg.Clear();
            this.usuario = new HenryCorporation.Lavajato.DomainModel.Usuario();

            checkBoxOrdemServico.Checked = false;
            checkBoxServico.Checked = false;
            checkBoxProduto.Checked = false;
            checkBoxRelatorio.Checked = false;
            checkBoxUsuario.Checked = false;
            checkBoxCaixa.Checked = false;
            checkBoxCategoriaProduto.Checked = false;
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedValue == null)
                return;

            var tipoDeUsuario = cmbTipoUsuario.SelectedValue.ToString();
            if (tipoDeUsuario.Equals("3"))
            {
                login.Enabled = false;
                senha.Enabled = false;
            }
            else
            {
                login.Enabled = true;
                senha.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.usuario.ID == 0)
            {
                MessageBox.Show("Nennhum usuário selecionado", "Atenção!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente desativar o usuário", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            
            usuarioBL.Delete(this.usuario);
            MessageBox.Show("Usuário desativado com sucesso", "Atenção!");
            LimpaCampos();
            CarregaUsuarios();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nome_Enter(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
        }

        private void nome_Leave(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
        }

        private void login_Enter(object sender, EventArgs e)
        {
            login.BackColor = Color.Yellow;
        }

        private void login_Leave(object sender, EventArgs e)
        {
            login.BackColor = Color.White;
        }

        private void senha_Enter(object sender, EventArgs e)
        {
            senha.BackColor = Color.Yellow;
        }

        private void senha_Leave(object sender, EventArgs e)
        {
            senha.BackColor = Color.White;
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

        private void bairro_Enter(object sender, EventArgs e)
        {
            bairro.BackColor = Color.Yellow;
        }

        private void bairro_Leave(object sender, EventArgs e)
        {
            bairro.BackColor = Color.White;
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

        private void fone_Enter(object sender, EventArgs e)
        {
            fone.BackColor = Color.Yellow;
        }

        private void fone_Leave(object sender, EventArgs e)
        {
            fone.BackColor = Color.White;
        }

        private void celular_Enter(object sender, EventArgs e)
        {
            celular.BackColor = Color.Yellow;
        }

        private void celular_Leave(object sender, EventArgs e)
        {
            celular.BackColor = Color.White;
        }

        private void email_Enter(object sender, EventArgs e)
        {
            email.BackColor = Color.Yellow;
        }

        private void email_Leave(object sender, EventArgs e)
        {
            email.BackColor = Color.White;
        }

        private void cpf_Enter(object sender, EventArgs e)
        {
            cpf.BackColor = Color.Yellow;
        }

        private void cpf_Leave(object sender, EventArgs e)
        {
            cpf.BackColor = Color.White;
        }

        private void rg_Enter(object sender, EventArgs e)
        {
            rg.BackColor = Color.Yellow;
        }

        private void rg_Leave(object sender, EventArgs e)
        {
            rg.BackColor = Color.White;
        }

        private void OcultaCampo()
        {
            grdUsuarios.Columns[0].Visible = false;
        }

        private void nomePesquisa_Enter(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.Yellow;
        }

        private void nomePesquisa_Leave(object sender, EventArgs e)
        {
            nomePesquisa.BackColor = Color.White;
        }

        private void loginPesquisa_Enter(object sender, EventArgs e)
        {
            loginPesquisa.BackColor = Color.Yellow;
        }

        private void loginPesquisa_Leave(object sender, EventArgs e)
        {
            loginPesquisa.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
