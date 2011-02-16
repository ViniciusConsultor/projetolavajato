using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HenryCorporation.Lavajato.BusinessLogic;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class ServicoLavador : Form
    {
        private UsuarioBL usuarioBL = new UsuarioBL();
        private ProdutoBL produtoBl = new ProdutoBL();

        public ServicoLavador()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            int quantidadeControles = this.Controls.Count - 3;
            int locationY = quantidadeControles * 21;

            ComboBox combox = new ComboBox();
            combox.Name = combox + locationY.ToString();
            combox.Location = new Point(61, locationY);
            combox.Height = (cmbServico.Height + cmbServico.Height) * quantidadeControles;
            combox.Width = cmbServico.Width;
            combox.DataSource = usuarioBL.GetUsuarioTipoLavador();
            combox.DisplayMember = "Nome";
            combox.ValueMember = "ID";
            this.Controls.Add(combox);

            Label label = new Label();
            label.Text = "Lavador:";
            label.Location = new Point(12, quantidadeControles * 21 );

            this.Controls.Add(label);


            ComboBox combox1 = new ComboBox();
            combox1.Name = combox1 + this.Location.Y.ToString();
            combox1.Location = new Point(61, locationY +21);
            combox1.Height = (cmbServico.Height + cmbServico.Height + 1) * quantidadeControles;
            combox1.Width = cmbServico.Width;
            combox1.DataSource = produtoBl.TipoServico(EnumCategoriaProduto.Produto);
            combox1.DisplayMember = "Descricao";
            combox1.ValueMember = "ID";
            this.Controls.Add(combox1);
            this.Height = 70 + (quantidadeControles * 21);
        }

        
    }
}
