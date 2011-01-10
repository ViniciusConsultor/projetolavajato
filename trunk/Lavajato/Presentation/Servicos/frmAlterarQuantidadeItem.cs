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
        private ServicoItem servicoItem;
        private ServicoBL servicoBL = new ServicoBL();
        public frmAlterarQuantidadeItem()
        {
            InitializeComponent();
        }

        public frmAlterarQuantidadeItem(ServicoItem servicoItem)
        {
            InitializeComponent();
            this.servicoItem = servicoItem;
            CarregaServicoItem(this.servicoItem);
        }

        private void CarregaServicoItem(ServicoItem servicoItem)
        {
            if (servicoItem.ID == 0)
            {
                return;
            }

            lblProduto.Text = servicoItem.Produto.Descricao;
            quantidade.Value = decimal.Parse(servicoItem.Quantidade.ToString());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.servicoItem.Quantidade = Convert.ToInt32(quantidade.Value);
            servicoBL.ItemUpdate(this.servicoItem);
            MessageBox.Show("Quantidade alterada com sucesso", "Atenção");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}
