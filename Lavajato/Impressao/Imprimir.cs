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
                string quantidadeItens = "", valorUnitario = "", total = "", descricao = "";

                descricao = FormataDescricao(item);

                quantidadeItens = SetQuantidadeDeItens(item);

                valorUnitario = SetValorDoItem(item);
                valorUnitario = FormataValorUnitario(valorUnitario);

                total = SetValorTotal(item);
                total = FormataTotal(total);

                somaTotal += Configuracao.ConverteParaDecimal(total);

                recibo += descricao + quantidadeItens + valorUnitario + total + enter;

            }
            recibo += FormataSomaTotal(somaTotal) + enter;
            recibo += "Não nos responsabilizamos parte Elétrica/Mecânica do veículo"+enter;
            recibo += FormataCabecalho();
            
            return recibo;
        }

        private string FormataDescricao(ServicoItem item)
        {
            string desc = "";
            if (item.Produto.Descricao.Length > 17)
            {
                item.Produto.Descricao.Substring(0, 17);
            }
            else
            {
                for (int i = item.Produto.Descricao.Length; i < 18 ; i++)
                {
                    desc += " ";
                }
            }

            return item.Produto.Descricao + desc;
        }

        private string SetQuantidadeDeItens(ServicoItem item)
        {
            return item.Quantidade.ToString();
        }

        private string SetDateInput(Servico servico)
        {
            string hora = servico.Entrada.Hour.ToString().Length == 1 ? "0" + servico.Entrada.Hour.ToString() : servico.Entrada.Hour.ToString();
            string minuto = servico.Entrada.Minute.ToString().Length == 1 ? "0" + servico.Entrada.Minute.ToString() : servico.Entrada.Minute.ToString();
            string entrada = servico.Entrada.ToShortDateString() + " " + hora + ":" + minuto;
            return entrada;
        }

        private string FormataValorUnitario(string valUni)
        {
            if (valUni.Length == 5)
                valUni = "          " + valUni;
            else if (valUni.Length == 6)
                valUni = "         " + valUni;
            else if (valUni.Length == 4)
                valUni = "           " + valUni;

            return valUni;
        }

        private string SetValorTotal(ServicoItem item)
        {
            string tot = (item.Produto.ValorUnitario * item.Quantidade).ToString("C");
            tot = tot.Replace("R$", "");
            return tot;
        }

        private string SetValorDoItem(ServicoItem item)
        {
            string valUni = item.Produto.ValorUnitario.ToString("C");
            valUni = valUni.Replace("R$", "");

            return valUni;
        }

        private string FormataSomaTotal(decimal somaTotal)
        {
            return "                                        Valor Total: " + somaTotal;
        }

        private string FormataTotal(string tot)
        {
            if (tot.Length == 5)
                tot = "     " + tot;
            else if (tot.Length == 6)
                tot = "    " + tot;
            else if (tot.Length == 4)
                tot = "      " + tot;

            return tot;


        }

        private string FormataCabecalho()
        {
            string strCabecalho = "";
            strCabecalho += enter;
            strCabecalho += enter;
            strCabecalho += enter;
            strCabecalho += enter;
            strCabecalho += enter;
            strCabecalho += enter;
            strCabecalho += enter;
            strCabecalho += enter;

            strCabecalho += "    LAVEVIP - Estética Automotiva " + enter;
            strCabecalho += "      O melhor amigo do seu veículo" + enter;
            strCabecalho += "Av. Pres. Carlos Luz, 3001, Caiçara" + enter;
            strCabecalho += "            (31)3415-8085" + enter;
            strCabecalho += "Aberto de segunda à sabado das 10 às 22 horas" + enter;
            strCabecalho += "E domingo de 12 às 19 horas" + enter;

            return strCabecalho;
        }

        public string MontaCorpoRecibo(Servico servico)
        {
            string corpoRecibo = "";
            corpoRecibo += "------------------------------------------------------------" + enter;
            corpoRecibo += "Nº O.S.:" + FormataEspacamentoEm20(servico.OrdemServico.ToString()) + "Placa:" + servico.Cliente.Placa + enter;
            corpoRecibo += "Veículo:" + FormataEspacamentoEm20(servico.Cliente.Veiculo) +          "Cor:  " + servico.Cliente.Cor + "" + enter;
            corpoRecibo += "Nome:   " + FormataEspacamentoEm20(servico.Cliente.Nome) +            "Fone: " + servico.Cliente.Telefone + "" + enter;
            corpoRecibo += "Entrada:" + FormataEspacamentoEm20(SetDateInput(servico)) +           "Saida:" + servico.Saida.Hour + ":" + servico.Saida.Minute+ "" + enter;
            corpoRecibo += "------------------------------------------------------------" + enter;
            corpoRecibo += "SERVICO             QTDE.     VALOR   TOTAL" + enter;
            return corpoRecibo;
        }

        private string FormataEspacamentoEm20(string p)
        {
            string temp="";
            p = p.Trim();

            if (p.Length < 21)
            {
                for (int i = p.Length; i < 20; i++)
                {
                    temp += " ";
                }

                p += temp;
            }
            else if (p.Length > 20)
            {
                p = p.Substring(0, 20);
            }

            return p;

        }
    }
}
