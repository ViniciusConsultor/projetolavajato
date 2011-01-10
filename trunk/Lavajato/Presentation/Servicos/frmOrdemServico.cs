﻿using System;
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
using HenryCorporation.Lavajato.Presentation.Properties;
using Impressao;

namespace HenryCorporation.Lavajato.Presentation
{
    public partial class frmOrdemServico : login
    {
        public frmOrdemServico()
        {
            InitializeComponent();
            btnCadastraCliente.Enabled = false;
            dataTable.Columns.AddRange(ServicoBL.CarregaColunas());
            dataSetItens.Tables.Add(dataTable);
        }

        private void frmOrdemServico_Load(object sender, EventArgs e)
        {
            CarregaHora();
            CarregaProdutos();
        }

        private void placa_Leave(object sender, EventArgs e)
        {
            placa.BackColor = Color.White;
            if (Equals(placa.Text, Resources.Placa_vazia))
                return;

            this.clienteParaCarregarAsInformacoes.Placa = placa.Text;

            this.clienteParaCarregarAsInformacoes = ProcuraCliente(this.clienteParaCarregarAsInformacoes);
            if (clienteParaCarregarAsInformacoes.ID == 0)
            {
                var dialogResult = MessageBox.Show(Resources.Cliente_não_Cadastrado, Resources.Atencao, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    btnCadastraCliente.Enabled = true;
                    return;
                }
            }

            servico = servicoBL.ByCliente(this.clienteParaCarregarAsInformacoes);
            if (servico.ID == 0)
            {
                CarregaCliente(this.clienteParaCarregarAsInformacoes);
                return;
            }

            CarregaCliente(this.clienteParaCarregarAsInformacoes);
            
            if (this.servico.Lavado != 1)
            CarregaItens(this.servico);

            if (this.servico.Finalizado == 0)
                MessageBox.Show(Resources.Ordem_de_Serviço_Aberto + servico.OrdemServico, Resources.Atencao);
                
        }

        private void placa_TextChanged(object sender, EventArgs e)
        {
            FormataPlaca();
        }

        private void adicionarServico_Click(object sender, EventArgs e)
        {
            if (clienteParaCarregarAsInformacoes.ID == 0)
            {
                MessageBox.Show(Resources.Favor_escolher_um_cliente, Resources.Atencao);
                return;
            }
            AdicionaItem();
        }

        private void btnCadastraCliente_Click(object sender, EventArgs e)
        {
            var clientePlaca = new Cliente();
            clienteParaCarregarAsInformacoes.Placa = placa.Text;
            if (clienteBL.Existe(clienteParaCarregarAsInformacoes))
            {
                MessageBox.Show(Resources.Cliente_já_existente_na_base, Resources.Atencao);
                return;
            }

            SetUpFieldsCliente();
            ClienteInsert();
            MessageBox.Show(Resources.Cliente_salvo_com_sucesso, Resources.Atencao);
            btnCadastraCliente.Enabled = false;
        }
      
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(Resources.Apagar_item_de_pedido, Resources.Atencao, MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                return;
            }

            dataSetItens.Tables[0].Rows[dataSetItens.Tables[0].Rows.Count != 0 ? indexColumaDataGrid : 0].Delete();
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

            MessageBox.Show(Resources.Item_deletado, Resources.Atencao);
        }

        private void grdServico_MouseClick(object sender, MouseEventArgs e)
        {
            if (grdServico.CurrentRow != null) indexColumaDataGrid = grdServico.CurrentRow.Index;
        }

        private void btnGerarOrdemServico_Click(object sender, EventArgs e)
        {
            var servicoSalva = ServicoSalva();
            ServicoItemSalva(servicoSalva);
            IImprimir impressao = new ImprimirComprovantePagamento(this.servico);
        }

        private Servico ServicoSalva()
        {

            var servicoSalva = new Servico
            {
                Cliente = this.clienteParaCarregarAsInformacoes,
                Total = SomaTotal(),
                SubTotal = 0,
                Desconto = 0,
                Entrada = DateTime.Now
            };

            servicoSalva.Saida = servicoSalva.Entrada.AddHours(double.Parse(hora.SelectedItem.ToString())).AddMinutes(double.Parse(min.SelectedItem.ToString()));
            servicoSalva.OrdemServico = servicoBL.OrdemServicoMax();
            servicoSalva.FormaPagamento.ID = 1;
            servicoSalva.Usuario = this.Usuario;

            servicoSalva.Cancelado = 0;
            servicoSalva.Delete = 0;
            servicoSalva.Finalizado = 0;
            servicoSalva.Lavado = 0;

            try
            {
                return servicoBL.Add(servicoSalva);
            }
            catch (Exception)
            {
                servicoBL.Delete(servicoSalva);                
            }
            return new Servico();
        }

        private void ServicoItemSalva(Servico servico)
        {
            if (dataSetItens != null)
                foreach (DataRow row in dataSetItens.Tables[0].Rows)
                {
                    var item = new ServicoItem();
                    var produto = new Produto() { ID = int.Parse(row["ID"].ToString()) };
                    item.Produto = new ProdutoBL().ByID(produto);
                    item.Quantidade = int.Parse(row["Quantidade"].ToString());
                    item.Servico = servico;
                    servicoBL.ItemInsert(item);
                }
        }

        private decimal SomaTotal()
        {
            var qtdeTotal = dataSetItens.Tables[0].Rows.Cast<DataRow>().Sum(
                row => Configuracao.ConverteParaDecimal(row["Total"].ToString()));
            this.servico.Total = qtdeTotal;
            return  qtdeTotal;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            servico = new Servico();
            clienteParaCarregarAsInformacoes = new Cliente();
            placa.Text = "";
            veiculo.Text = "";
            telefone.Text = "";
            nome.Text = "";
            corVeiculo.Text = "";
            CarregaItens(servico);
            dataSetItens = new DataSet();
            dataTable = new DataTable();
            dataTable.Columns.AddRange(ServicoBL.CarregaColunas());
            dataSetItens.Tables.Add(dataTable);
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

        }

        private void ClienteInsert()
        {
            clienteParaCarregarAsInformacoes = clienteBL.Insert(clienteParaCarregarAsInformacoes);
        }

        private void SetUpFieldsCliente()
        {
            clienteParaCarregarAsInformacoes.Placa = placa.Text;
            clienteParaCarregarAsInformacoes.Veiculo = veiculo.Text;
            clienteParaCarregarAsInformacoes.Telefone = telefone.Text;
            clienteParaCarregarAsInformacoes.Nome = nome.Text;
            clienteParaCarregarAsInformacoes.Cor = corVeiculo.Text;
        }

        private void CarregaHora()
        {
            hora.Items.AddRange(Configuracao.CarregaHora());
            min.Items.AddRange(Configuracao.CarregaMinuto());
            hora.SelectedIndex = 0;
            min.SelectedIndex = 0;
        }

        private void CarregaItens(Servico servicoParaCarregarItens)
        {
            if (grdServico == null) return;

            grdServico.DataSource = CarregaItensNoGrid(servicoParaCarregarItens);
            grdServico.Columns[0].Width = 150;
            grdServico.Columns[1].Width = 150;
            grdServico.Columns[2].Width = 100;
            grdServico.Columns[3].Width = 100;
        }

        private void AdicionaItem()
        {
            var item = new Produto();
            item.ID = int.Parse(cmdServico.SelectedValue.ToString());
            item = new ProdutoBL().ByID(item);
            dataSetItens.Tables[0].Rows.Add(AdicionaLinhaDeItemAoGrid(item));
            grdServico.DataSource = dataSetItens.Tables[0].DefaultView;

            grdServico.Columns[0].Visible = false;
        }

        private DataRow AdicionaLinhaDeItemAoGrid(Produto item)
        {
            var quantidadeDeItens = string.IsNullOrEmpty(quantidadeProduto.Text) ? 1 : int.Parse(quantidadeProduto.Text);

            var row = dataSetItens.Tables[0].NewRow();
            row["ID"] = item.ID;
            row["Descricao"] = item.Descricao;
            row["Quantidade"] = quantidadeDeItens;
            row["Valor"] = item.ValorUnitario.ToString("C");
            row["Total"] = (item.ValorUnitario * quantidadeDeItens).ToString("C");

            return row;
        }

        private void ItemDoServicoSalva(Servico servicoDoItem)
        {
            var item = new ServicoItem();
            item.Produto.ID = int.Parse(cmdServico.SelectedValue.ToString());
            item.Quantidade = quantidadeProduto.TextLength == 0 ? 1 : Convert.ToDecimal(quantidadeProduto.Text);
            item.Servico = servicoDoItem;
            servicoBL.ItemInsert(item);
        }

        private void FormataPlaca()
        {
            var tamanhoPlaca = placa.Text.Length - 1;
            if (Equals(tamanhoPlaca, 2))
            {
                placa.Text = placa.Text + Resources.Separador_Placa;
                placa.SelectionStart = placa.TextLength;
            }

            tamanhoPlaca = placa.Text.Length;
            var tamanhoMaximoDaPlaca = 8;
            if (Equals(tamanhoPlaca, int.Parse(Resources.Tamanho_Maximo_Placa)))
            {

                placa.Text = placa.Text.Remove(placa.Text.Length - 1);
                placa.SelectionStart = placa.TextLength;
            }
        }

        private DataTable CarregaItensNoGrid(Servico servicoParaSerCarregado)
        {
            foreach (var si in servicoParaSerCarregado.ServicoItem)
            {
                var row = dataTable.NewRow();
                //row["ID"] = si.ID;
                row["Descricao"] = si.Produto.Descricao;
                row["Quantidade"] = si.Quantidade;
                row["Valor"] = si.Produto.ValorUnitario.ToString("C");
                row["Total"] = (si.Produto.ValorUnitario * si.Quantidade).ToString("C");
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (quantidadeProduto.Text.Contains("."))
            {
                quantidadeProduto.Text = quantidadeProduto.Text.Remove(quantidadeProduto.Text.Length - 1);
                quantidadeProduto.SelectionStart = quantidadeProduto.Text.Length;
            }
        }

        private void CarregaProdutos()
        {
            cmdServico.DataSource = new ProdutoBL().TipoServico(EnumCategoriaProduto.Servico);
            cmdServico.DisplayMember = "Descricao";
            cmdServico.ValueMember = "ID";
        }


        private void CarregaCliente(Cliente cliente)
        {
            if (cliente == null) 
                throw new ArgumentNullException("cliente");

            placa.Text = clienteParaCarregarAsInformacoes.Placa;
            veiculo.Text = clienteParaCarregarAsInformacoes.Veiculo;
            telefone.Text = clienteParaCarregarAsInformacoes.Telefone;
            nome.Text = clienteParaCarregarAsInformacoes.Nome;
            corVeiculo.Text = clienteParaCarregarAsInformacoes.Cor;
        }
        
        private Cliente ProcuraCliente(Cliente clienteProcurado)
        {
            return clienteBL.ByPlaca(clienteProcurado);
        }
        
        #region "Metodos de apoio"

        
        
        private void min_Enter(object sender, EventArgs e)
        {
            min.BackColor = Color.Yellow;
        }

        private void min_Leave(object sender, EventArgs e)
        {
            min.BackColor = Color.White;
        }

        private void telefone_Enter(object sender, EventArgs e)
        {
            telefone.BackColor = Color.Yellow;
        }

        private void telefone_Leave(object sender, EventArgs e)
        {
            telefone.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            quantidadeProduto.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            quantidadeProduto.BackColor = Color.White;
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

        #endregion
    }
}
