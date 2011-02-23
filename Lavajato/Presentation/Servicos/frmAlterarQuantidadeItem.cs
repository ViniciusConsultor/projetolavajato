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
    public partial class frmAlterarQuantidadeItem : Form
    {
        private ServicoItem _servicoItem;
        private ServicoBL servicoBL = new ServicoBL();
        public ServicoItem ServicoItem { get; set; }

        public frmAlterarQuantidadeItem()
        {
            InitializeComponent();
        }

        public frmAlterarQuantidadeItem(ServicoItem servicoItem)
        {
            InitializeComponent();
            _servicoItem = servicoItem;
            CarregaServicoItem(this._servicoItem);
        }

        private void CarregaServicoItem(ServicoItem servicoItem)
        {
            if (servicoItem.ID == 0)
            {
                quantidade.Value = decimal.Parse(servicoItem.Quantidade.ToString());
            }
            else
            {
                lblProduto.Text = servicoItem.Produto.Descricao;
                quantidade.Value = decimal.Parse(servicoItem.Quantidade.ToString());
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_servicoItem.ID > 0)
            {
                _servicoItem.Quantidade = Convert.ToInt32(quantidade.Value);
                servicoBL.ItemUpdate(_servicoItem);
                MessageBox.Show("Quantidade alterada com sucesso", "Atenção");
            }
            else
            {
                _servicoItem.Quantidade = Convert.ToInt32(quantidade.Value);
                ServicoItem = _servicoItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
