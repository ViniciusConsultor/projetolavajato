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

             this.usuario.Permissao.cliente = Convert.ToInt32(checkBoxCliente.Checked);
             this.usuario.Permissao.Usuario = Convert.ToInt32(checkBoxUsuario.Checked);
            this.usuario.Permissao.Produto = Convert.ToInt32(checkBoxProduto.Checked);
            this.usuario.Permissao.Convenio = Convert.ToInt32(checkBoxConvenio.Checked);
            this.usuario.Permissao.Credor = Convert.ToInt32(checkBoxCredor.Checked);
            this.usuario.Permissao.Servico = Convert.ToInt32(checkBoxServico.Checked);
            this.usuario.Permissao.OrdemServico = Convert.ToInt32(checkBoxOrdemServico.Checked);
            this.usuario.Permissao.OrdemAberto = Convert.ToInt32(checkOrdemEmAberto.Checked);
            this.usuario.Permissao.IncluirLavadorNoServico =Convert.ToInt32(checkBoxIncluirLavadorNoServico.Checked);
            this.usuario.Permissao.CancelaOrdemServico = Convert.ToInt32(checkBoxCancelaOrdemServicoFinalizada.Checked);
            this.usuario.Permissao.relCaixa = Convert.ToInt32(checkBoxRelCaixa.Checked);
            this.usuario.Permissao.relCaixaPorData = Convert.ToInt32(checkBoxRelCaixaPorData.Checked);
            this.usuario.Permissao.relEstoque = Convert.ToInt32(checkBoxRelEstoque.Checked);
            this.usuario.Permissao.relCliente = Convert.ToInt32(checkBoxRelClientes.Checked);
            this.usuario.Permissao.relLavagemPorLavador =Convert.ToInt32(checkBoxRelLavagemPorLavador.Checked);
            this.usuario.Permissao.relCarrosNoLavajato = Convert.ToInt32(checkBoxCarrosNoLavajato.Checked);
            this.usuario.Permissao.relServicoPorOs = Convert.ToInt32(checkBoxServicoPorOS.Checked);
            this.usuario.Permissao.relServicoCancelado = Convert.ToInt32(checkBoxServicoCancelado.Checked);
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


            checkBoxCliente.Checked = Convert.ToBoolean(this.usuario.Permissao.cliente);
            checkBoxUsuario.Checked = Convert.ToBoolean(this.usuario.Permissao.Usuario);
            checkBoxProduto.Checked = Convert.ToBoolean(this.usuario.Permissao.Produto);
            checkBoxConvenio.Checked = Convert.ToBoolean(this.usuario.Permissao.Convenio);
            checkBoxCredor.Checked = Convert.ToBoolean(this.usuario.Permissao.Credor);
            checkBoxServico.Checked = Convert.ToBoolean(this.usuario.Permissao.Servico);
            checkBoxOrdemServico.Checked = Convert.ToBoolean(this.usuario.Permissao.OrdemServico);
            checkOrdemEmAberto.Checked = Convert.ToBoolean(this.usuario.Permissao.OrdemAberto);
            checkBoxIncluirLavadorNoServico.Checked = Convert.ToBoolean(this.usuario.Permissao.IncluirLavadorNoServico);
            checkBoxCancelaOrdemServicoFinalizada.Checked = Convert.ToBoolean(this.usuario.Permissao.CancelaOrdemServico);
            checkBoxRelCaixa.Checked = Convert.ToBoolean(this.usuario.Permissao.relCaixa);
            checkBoxRelCaixaPorData.Checked = Convert.ToBoolean(this.usuario.Permissao.relCaixaPorData);
            checkBoxRelEstoque.Checked = Convert.ToBoolean(this.usuario.Permissao.relEstoque);
            checkBoxRelClientes.Checked = Convert.ToBoolean(this.usuario.Permissao.relCliente);
            checkBoxRelLavagemPorLavador.Checked = Convert.ToBoolean(this.usuario.Permissao.relLavagemPorLavador);
            checkBoxCarrosNoLavajato.Checked = Convert.ToBoolean(this.usuario.Permissao.relCarrosNoLavajato);
            checkBoxServicoPorOS.Checked = Convert.ToBoolean(this.usuario.Permissao.relServicoPorOs);
            checkBoxServicoCancelado.Checked = Convert.ToBoolean(this.usuario.Permissao.relServicoCancelado);

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

            checkBoxCliente.Checked = false;
            checkBoxUsuario.Checked = false;
            checkBoxProduto.Checked = false;
            checkBoxConvenio.Checked = false;
            checkBoxCredor.Checked = false;
            checkBoxServico.Checked = false;
            checkBoxOrdemServico.Checked = false;
            checkOrdemEmAberto.Checked = false;
            checkBoxIncluirLavadorNoServico.Checked = false;
            checkBoxCancelaOrdemServicoFinalizada.Checked = false;
            checkBoxRelCaixa.Checked = false;
            checkBoxRelCaixaPorData.Checked = false;
            checkBoxRelEstoque.Checked = false;
            checkBoxRelClientes.Checked = false;
            checkBoxRelLavagemPorLavador.Checked = false;
            checkBoxCarrosNoLavajato.Checked = false;
            checkBoxServicoPorOS.Checked = false;
            checkBoxServicoCancelado.Checked = false;
        
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
