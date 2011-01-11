using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DomainModel;
using HenryCorporation.Lavajato.Operacional;

namespace Impressao
{
    public class Imprimir
    {
        private const string enter = "\n";

        public Imprimir()
        { 

        }

        public string ExibeReciboFormatado(Servico servico)
        {
            decimal somaTotal = 0;
            string recibo = "";
            foreach (var item in servico.ServicoItem)
            {
                string quantidadeItens = "", valorUnitario = "", total = "";

                quantidadeItens = FormataQuantidadeDeItens(item);
                valorUnitario = FormataValorDoItem(item);
                valorUnitario = FormataValorUnitario(valorUnitario);
                total = FormataValorTotalDoItem(item);
                somaTotal += Configuracao.ConverteParaDecimal(total);
                total = FormataTotal(total);

                recibo = FormataDescricao(item) + FormataQuantidadeDeItens(item) +
                    FormataValorDoItem(item) + FormataValorDoItem(item) + enter;

            }
            recibo += FormataSomaTotal(somaTotal);
            recibo += FormataCabecalho();
            return recibo;
        }

        public string FormataDescricao(ServicoItem item)
        {
            string desc = "";
            if (item.Produto.Descricao.Length > 16)
            {
                desc = item.Produto.Descricao.Remove(16);
            }
            else if (item.Produto.Descricao.Length == 16)
            {

            }
            else
            {
                desc = item.Produto.Descricao;
                for (int i = 0; i < 17 - item.Produto.Descricao.Length; i++)
                {
                    desc += "  ";
                }
            }

            return desc;
        }

        public string MontaCorpoRecibo(Servico servico)
        {
            string corpoRecibo = "";
            corpoRecibo = "--------------------------------------------------";
            corpoRecibo = "Nº: " + servico.OrdemServico + enter;
            corpoRecibo = "Placa: " + servico.Cliente.Placa + "  Veículo:" + servico.Cliente.Veiculo + "  Cor:" + servico.Cliente.Cor + "" + enter;
            corpoRecibo = "Nome:  " + servico.Cliente.Nome + "      Fone:" + servico.Cliente.Telefone + "" + enter;
            corpoRecibo = "Entrada:  " + SetDateInput(servico) + "   Saida:" + servico.Saida.Hour + ":" + servico.Saida.Second + "" + enter;
            corpoRecibo = "--------------------------------------------------" + enter;
            corpoRecibo = "SERVICO             QTDE.     VALOR   TOTAL" + enter;
            return corpoRecibo;
        }

        public string FormataQuantidadeDeItens(ServicoItem item)
        {
            string qtde = item.Quantidade.ToString();
            return qtde;
        }


        public string SetDateInput(Servico servico)
        {
            string hora = servico.Entrada.Hour.ToString().Length == 1 ? "0" + servico.Entrada.Hour.ToString() : servico.Entrada.Hour.ToString();
            string minuto = servico.Entrada.Minute.ToString().Length == 1 ? "0" + servico.Entrada.Minute.ToString() : servico.Entrada.Minute.ToString();
            string entrada = servico.Entrada.ToShortDateString() + " " + hora + ":" + minuto;
            return entrada;
        }

        public string FormataValorUnitario(string valUni)
        {
            if (valUni.Length == 5)
                valUni = "              " + valUni;
            else if (valUni.Length == 4)
                valUni = "              " + valUni;
            else if (valUni.Length == 6)
                valUni = "              " + valUni;
            return valUni;
        }

        public string FormataValorTotalDoItem(ServicoItem item)
        {
            string tot = (item.Produto.ValorUnitario * item.Quantidade).ToString("C").Replace("R$", "");
            return tot;
        }

        public string FormataValorDoItem(ServicoItem item)
        {
            string valUni = item.Produto.ValorUnitario.ToString("C").Replace("R$", "");
            return valUni;
        }

        public string FormataCabecalho()
        {
            string strCabecalho = "";
            strCabecalho = enter;
            strCabecalho = enter;
            strCabecalho = enter;
            strCabecalho = enter;
            strCabecalho = enter;
            strCabecalho = enter;
            strCabecalho = enter;
            strCabecalho = enter;

            strCabecalho = "LAVEVIP - Estetica Automotiva " + enter;
            strCabecalho = "Av. Pres. Carlos Luz, 3001, Caiçara" + enter;
            strCabecalho = "Area QVip1 2ºP" + enter;
            strCabecalho = "               LAVEVIP" + enter;
            strCabecalho = "O melhor amigo do seu veiculo" + enter;
            strCabecalho = "(31)3415-8085" + enter;
            strCabecalho = "(31)9208-9977" + enter;

            return strCabecalho;

        }

        public string FormataSomaTotal(decimal somaTotal)
        {
            return "                                           Valor Total: " + somaTotal;
        }

        public string FormataTotal(string tot)
        {

            if (tot.Length == 5)
                tot = "    " + tot;
            else if (tot.Length == 4)
                tot = "      " + tot;
            else if (tot.Length == 6)
                tot = "   " + tot;
            return tot;
        }
    }
}
