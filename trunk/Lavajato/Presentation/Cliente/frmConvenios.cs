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
        private Convenio _convenio = new Convenio();
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
            if (_convenio.ID == 0)
                MessageBox.Show("Nenhuma convenio encontrado", "Atenção");

            SetUpConvenio();
            convenioBL.Update(_convenio);
            CarregaDados();
            MessageBox.Show("Dados alterados com sucesso!", "Atenção");
            nome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_convenio.ID > 0)
            {
                MessageBox.Show("Não é permitido salvar o mesmo cliente duas vezes! ", 
                    "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (porcentagem.TextLength > 0 && desconto.TextLength > 0)
            {
                MessageBox.Show("Deve haver somente um tipo de desconto, ou em Dinherio ou em Porcentagem", 
                    "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            
            SetUpConvenio();
            _convenio = convenioBL.Add(_convenio);
            SetUpFields(_convenio);
            CarregaDados();
            MessageBox.Show("Dados salvos com sucesso!", "Atenção");
            nome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_convenio.ID == 0)
                MessageBox.Show("Nenhuma convênio encontrado", "Atenção");

            DialogResult res = MessageBox.Show("Deseja realmente apagar o convênio?", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }
                      
            convenioBL.Delete(_convenio);
            LimpaCampos();
            CarregaDados();
            nome.Focus();
        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {

        }

        private void grdConvenios_DoubleClick(object sender, EventArgs e)
        {
            _convenio.ID = int.Parse(grdConvenios.Rows[grdConvenios.CurrentRow.Index].Cells[0].Value.ToString());
            _convenio = convenioBL.ByID(_convenio);
            
            if (_convenio.ID == 0 )
            {
                MessageBox.Show("Nenhum cliente encontrado!", "Atenção");
                return;
            }

            SetUpFields(_convenio);
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
            nome.Clear();
            endereco.Clear();
            numero.Clear();
            bairro.Clear();
            cep.Clear();
            cidade.Clear();
            uf.SelectedIndex = -1;
            fone.Clear();
            celular.Clear();
            porcentagem.Clear();
            desconto.Clear();
            _convenio = new Convenio();
        }

        private Convenio SetUpConvenio()
        {
            decimal valorTemp = Configuracao.ConverteParaDecimal( desconto.Text.Trim());
            decimal porcentagemTemp = Configuracao.ConverteParaDecimal( porcentagem.Text.Trim());
            _convenio.Valor = valorTemp;
            _convenio.Nome = nome.Text;
            _convenio.Endereco = endereco.Text;
            _convenio.Numero = numero.Text;
            _convenio.Bairro = bairro.Text;
            _convenio.Cep = cep.Text;
            _convenio.Cidade = cidade.Text;
            _convenio.UF = uf.SelectedItem == null ? "MG" : uf.SelectedItem.ToString();
            _convenio.Telefone = fone.Text;
            _convenio.Celular = celular.Text;
            _convenio.PorcentagemDesconto = porcentagemTemp;

            return _convenio;
        }

        private void SetUpFields(Convenio convenio)
        {
            nome.Text = _convenio.Nome;
            endereco.Text = _convenio.Endereco;
            numero.Text = _convenio.Numero;
            bairro.Text = _convenio.Bairro;
            cep.Text = _convenio.Cep;
            cidade.Text = _convenio.Cidade;
            uf.SelectedItem = _convenio.UF.Length > 0 ? _convenio.UF : "MG";
            fone.Text = _convenio.Telefone;
            celular.Text = _convenio.Celular;
            desconto.Text = _convenio.Valor.ToString("C").Replace("R$", "");
            porcentagem.Text = _convenio.PorcentagemDesconto.ToString();
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

        private void porcentagem_Enter(object sender, EventArgs e)
        {
            porcentagem.BackColor = Color.Yellow;
        }

        private void porcentagem_Leave(object sender, EventArgs e)
        {
            porcentagem.BackColor = Color.White;
        }

    }
}
