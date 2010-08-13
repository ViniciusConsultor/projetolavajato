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
using System.Drawing.Printing;
using System.IO;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmOrdemServico : login
    {
        private ClienteBL clienteBL = new ClienteBL();
        private Cliente cliente = new Cliente();
        private Servico servico = new Servico();
        private ServicoItem servicoItem = new ServicoItem();
        private ServicoBL servicoBL = new ServicoBL();
        
        private DataSet dst = new DataSet();
        private DataTable table = new DataTable();

        public frmOrdemServico()
        {
            InitializeComponent();
            btnCadastraCliente.Enabled = false;
        }

        private void frmOrdemServico_Load(object sender, EventArgs e)
        {
            CarregaHora();
            CarregaProdutos();
        }

        private void CarregaProdutos()
        {
            cmdServico.DataSource = new ProdutoBL().TipoServico(EnumCategoriaProduto.Servico);
            cmdServico.DisplayMember = "Descricao";
            cmdServico.ValueMember = "ID";
        }

        private void CarregaItensDoServico(Servico servico)
        {
            grdServico.DataSource = servicoBL.CriaGrid(this.servico).DefaultView;
            grdServico.Columns[0].Visible = false;
            grdServico.Columns[1].Width = 150;
            grdServico.Columns[2].Width = 150;
            grdServico.Columns[3].Width = 100;
            grdServico.Columns[4].Width = 100;

            for (int i = 0; i < grdServico.Rows.Count; i++)
            {
                decimal div = (i % 2);
                if (div == 0)
                {
                    grdServico.BackgroundColor = Color.AntiqueWhite;
                }
            }
        }

        private void CarregaCliente(DomainModel.Cliente cliente)
        {
            placa.Text = this.cliente.Placa;
            veiculo.Text = this.cliente.Veiculo;
            telefone.Text = this.cliente.Telefone;
            nome.Text = this.cliente.Nome;
            corVeiculo.Text = this.cliente.Cor;
        }

        private DomainModel.Cliente ProcuraCliente(DomainModel.Cliente cliente)
        {
            return clienteBL.ByPlaca(cliente);
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            FormataPlaca();
        }

        private void FormataPlaca()
        {
            int tamanhoPlaca = placa.Text.Length - 1;
            if (tamanhoPlaca == 2)
            {
                placa.Text = placa.Text + "-";
                placa.SelectionStart = placa.TextLength;
            }

            tamanhoPlaca = placa.Text.Length;
            int tamanhoMaximoDaPlaca = 8;
            if (tamanhoPlaca == tamanhoMaximoDaPlaca)
            {
                placa.Text = placa.Text.Remove(placa.Text.Length - 1);
                placa.SelectionStart = placa.TextLength;
            }
        }

        private void adicionarServico_Click(object sender, EventArgs e)
        {
            if (!ExisteServico(this.servico))
            {
                this.servico = ServicoSalva();
                ItemDoServicoSalva(this.servico);
            }
            else 
            {
                ItemDoServicoSalva(this.servico);
            }

            CarregaItensDoServico();
            CarregaItensDoServico(this.servico);
        }

        private bool ExisteServico(Servico servico)
        {
            return servicoBL.ExisteServico(servico);
        }

        private void CarregaItensDoServico()
        {
            ServicoBL servBL = new ServicoBL();
            this.servico = servBL.ByID(this.servico);
        }

        private void ItemDoServicoSalva(Servico servico)
        {
            ServicoItem servicoItem = new ServicoItem();
            servicoItem.Produto.ID = ((Produto)cmdServico.SelectedItem).ID;
            servicoItem.Quantidade = 1;
            servicoItem.Servico = servico;
            servicoBL.ServicoItemInsert(servicoItem);
        }

        private Servico ServicoSalva()
        {
            Servico servico = new Servico();
            servico.Cliente = this.cliente;
            servico.Total = 0;
            servico.SubTotal = 0;
            servico.Desconto = 0;
            servico.Entrada = DateTime.Now;
            servico.Saida = servico.Entrada.AddHours(double.Parse( hora.SelectedItem.ToString())).AddMinutes( double.Parse(min.SelectedItem.ToString()));
            servico.OrdemServico = this.cliente.ID;
            servico.FormaPagamento.ID = 1;
            servico.Usuario = this.Usuario;

            servico.Cancelado = 0;
            servico.Delete = 0;
            servico.Finalizado = 0;
            servico.Lavado = 0;

            return servicoBL.Add(servico);
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            SetUpFieldsCliente();
            ClienteInsert();
            MessageBox.Show("Cliente salvo com sucesso!", "Atenção");
            btnCadastraCliente.Enabled = false;
        }

        private void ClienteInsert()
        {
            this.cliente = clienteBL.Insert(this.cliente);
        }

        private void SetUpFieldsCliente()
        {
            this.cliente.Placa = placa.Text;
            this.cliente.Veiculo = veiculo.Text;
            this.cliente.Telefone = telefone.Text;
            this.cliente.Nome = nome.Text;
            this.cliente.Cor = corVeiculo.Text;
        }
      
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ExisteServico(this.servico))
            {
                MessageBox.Show("Nenhum item encontrado!", "Atenção");
                return;
            }

            DialogResult res = MessageBox.Show("Deseja realmente apagar o item de pedido", "Atenção", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            servicoBL.ServicoItemDelete(this.servicoItem);
            MessageBox.Show("Item deletado com sucesso!", "Atenção");
            CarregaItensDoServico();
            CarregaItensDoServico(this.servico);

        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdServico.CurrentRow == null)
                return;

           this.servicoItem.ID = int.Parse(grdServico.Rows[grdServico.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void btnGerarOrdemServico_Click(object sender, EventArgs e)
        {
            if (!ExisteServico(this.servico))
            {
                MessageBox.Show("Nenhum serviço encontrado!", "Atenção");
                return;
            }

            SomaTotal();
            this.servico.OrdemServico = servico.ID;
            this.servico.Saida = dataEntrada.Value.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse( min.SelectedItem.ToString()));
            servicoBL.Update(this.servico);

            //Imprimir recibo
            EmiteRecibo();
            //print();
        }

        
        private void EmiteRecibo()
        {
            PrintDocument recibo = new PrintDocument();
            recibo.PrintPage += new PrintPageEventHandler(this.recibo_PrintPage);
            recibo.Print();
        }

        private void recibo_PrintPage(object sender, PrintPageEventArgs ev)
        {
            string enter = "\n";
            Pen myPen = new Pen(Brushes.Black);
            Point pt1 = new Point(30, 53);
            Font myFont1 = new Font("Arial", 9);
 
            StringBuilder strCabecalho = new StringBuilder();
            strCabecalho.Append("LAVEVIP LAVAJATO" + enter);
            strCabecalho.Append("Rua da Bahia, 2244, Lourdes" + enter);
            strCabecalho.Append("Minas Tenis Clube-Piso 1" + enter);
            strCabecalho.Append("(31)xxxx-xxxx" + enter);
            strCabecalho.Append("----------------------------------------------" + enter);
            strCabecalho.Append("Placa: " + servico.Cliente.Placa + "  Veículo:" + servico.Cliente.Veiculo + "  Cor:" + servico.Cliente.Cor + "" + enter);
            strCabecalho.Append("Nome:  " + servico.Cliente.Nome + "      Fone:" + servico.Cliente.Telefone + "" + enter);
            strCabecalho.Append("Entrada:  " + servico.Entrada + "   Saida:" + servico.Saida.Hour.ToString() + "" + enter);
            strCabecalho.Append("----------------------------------------------" + enter);
            strCabecalho.Append("SERVICO             QTDE.     VALOR   TOTAL" + enter);

            string desc = "";
            foreach (var item in servico.ServicoItem)
            {
                if (item.Produto.Descricao.Length >= 16)
                {
                    desc = item.Produto.Descricao;
                }
                else
                {
                    for (int i = 0; i < 16 - item.Produto.Descricao.Length; i++)
                    {
                        desc  += " ";
                    }
                }

                string qtde = item.Quantidade.ToString();
                string valUni = item.Produto.ValorUnitario.ToString("C").Replace("R$", "");
                string tot = (item.Produto.ValorUnitario * item.Quantidade).ToString("C").Replace("R$", "");
                strCabecalho.Append(desc + qtde + "       " + valUni + tot + enter);
            }

            ev.Graphics.DrawString(strCabecalho.ToString(), myFont1, Brushes.Black, 30, 30);
            ev.HasMorePages = false;
        }

        //private void cabecalho_PrintPage(object sender, PrintPageEventArgs ev)
        //{
        //    string enter = "\r\n";
        //    Pen myPen = new Pen(Brushes.Black);

        //    Point pt1 = new Point(30, 53);
        //    Font myFont1 = new Font("Arial", 9);

        //    StringBuilder strCabecalho = new StringBuilder();
        //    strCabecalho.Append("LAVEVIP LAVAJATO" + enter);
        //    strCabecalho.Append("Rua da Bahia, 2244, Lourdes" + enter);
        //    strCabecalho.Append("Minas Tenis Clube-Piso 1" + enter);
        //    strCabecalho.Append("(31)xxxx-xxxx" + enter);
        //    strCabecalho.Append("----------------------------------------------" + enter);


        //    ev.Graphics.DrawString(strCabecalho.ToString(), myFont1, Brushes.Black, 30, 30);
        //    ev.HasMorePages = false;
        //}

        private void SomaTotal()
        {
            decimal total = 0;
            decimal qtdeTotal = 0;
            foreach (ServicoItem si in this.servico.ServicoItem)
            {
                total += si.Produto.ValorUnitario * si.Quantidade;
                qtdeTotal += si.Quantidade;
            }

            this.servico.Total = total;
        }

        private void CarregaHora()
        {
            hora.Items.AddRange(Configuracao.CarregaHora());
            min.Items.AddRange(Configuracao.CarregaMinuto());
            hora.SelectedIndex = 0;
            min.SelectedIndex = 0;
        }
        

        private void veiculo_Enter(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.Yellow;
        }

        private void veiculo_Leave(object sender, EventArgs e)
        {
            veiculo.BackColor = Color.White;
        }

        private void nome_Enter(object sender, EventArgs e)
        {
            nome.BackColor = Color.Yellow;
        }

        private void nome_Leave(object sender, EventArgs e)
        {
            nome.BackColor = Color.White;
        }

        private void corVeiculo_Enter(object sender, EventArgs e)
        {
            corVeiculo.BackColor = Color.Yellow;
        }

        private void corVeiculo_Leave(object sender, EventArgs e)
        {
            corVeiculo.BackColor = Color.White;
        }

        private void dataEntrada_Enter(object sender, EventArgs e)
        {
            dataEntrada.BackColor = Color.Yellow;
        }

        private void dataEntrada_Leave(object sender, EventArgs e)
        {
            dataEntrada.BackColor = Color.White;
        }

        private void hora_Enter(object sender, EventArgs e)
        {
            hora.BackColor = Color.Yellow;
        }

        private void hora_Leave(object sender, EventArgs e)
        {
            hora.BackColor = Color.White;
        }

        private void cmdServico_Enter(object sender, EventArgs e)
        {
            cmdServico.BackColor = Color.Yellow;
        }

        private void cmdServico_Leave(object sender, EventArgs e)
        {
            cmdServico.BackColor = Color.White;
        }

        private void placa_Enter_1(object sender, EventArgs e)
        {
            placa.BackColor = Color.Yellow;
           
        }

        private void placa_Leave(object sender, EventArgs e)
        {
            placa.BackColor = Color.White;
            if (placa.Text == "   -")
            {
                return;
            }

            this.cliente.Placa = placa.Text;
            this.cliente = ProcuraCliente(this.cliente);

            if (this.cliente.ID == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Cliente não Cadastrado, deseja cadastrar?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    btnCadastraCliente.Enabled = true;
                    return;
                }
            }

            this.servico = servicoBL.ByCliente(this.cliente);
            if (this.servico.ID == 0)
            {
                CarregaCliente(this.cliente);
                return;
            }

            CarregaCliente(this.cliente);
            CarregaItensDoServico(this.servico);

            if (this.servico.Finalizado == 0)
                MessageBox.Show("Ordem de Serviço Aberto", "Atenção");

            if (this.servico.Lavado == 1)
                MessageBox.Show("Veículo já lavado", "Atenção");
        }

        private void min_Enter(object sender, EventArgs e)
        {
            min.BackColor = Color.Yellow;
        }

        private void min_Leave(object sender, EventArgs e)
        {
            min.BackColor = Color.White;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.servico = new Servico();
            this.cliente = new DomainModel.Cliente();
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            corVeiculo.Text = "";
            CarregaItensDoServico(this.servico);
        }

        private void telefone_Enter(object sender, EventArgs e)
        {
            telefone.BackColor = Color.Yellow;
        }

        private void telefone_Leave(object sender, EventArgs e)
        {
            telefone.BackColor = Color.White;
        }

        //StreamReader streamToPrint;
        //Font printFont;
        //private void print()
        //{
        //    try
        //    {
        //        streamToPrint = new StreamReader
        //           (@"G:\Documents and Settings\SANDRA\Meus documentos\MyFile.txt.txt");
        //        try
        //        {
        //           printFont = new Font("Arial", 10);
        //            PrintDocument pd = new PrintDocument();
        //            pd.PrintPage += new PrintPageEventHandler
        //               (this.pd_PrintPage);
        //            pd.Print();
        //        }
        //        finally
        //        {
        //            streamToPrint.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //// The PrintPage event is raised for each page to be printed.
        //private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        //{
        //    float linesPerPage = 0;
        //    float yPos = 0;
        //    int count = 0;
        //    float leftMargin = ev.MarginBounds.Left;
        //    float topMargin = ev.MarginBounds.Top;
        //    string line = null;

        //    // Calculate the number of lines per page.
        //    linesPerPage = ev.MarginBounds.Height /
        //       printFont.GetHeight(ev.Graphics);

        //    // Print each line of the file.
        //    while (count < linesPerPage &&
        //       ((line = streamToPrint.ReadLine()) != null))
        //    {
        //        yPos = topMargin + (count *
        //           printFont.GetHeight(ev.Graphics));
        //        ev.Graphics.DrawString(line, printFont, Brushes.Black,
        //           leftMargin, yPos, new StringFormat());
        //        count++;
        //    }
        //}

    }
}
