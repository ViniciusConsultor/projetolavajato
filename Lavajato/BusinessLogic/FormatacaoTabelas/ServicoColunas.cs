using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HenryCorporation.Lavajato.DomainModel;

namespace HenryCorporation.Lavajato.BusinessLogic
{
    public static class ServicoColunas
    {
        
        public static DataColumn[] GetColumns()
        {
            DataColumn[] columns = new DataColumn[2];

            DataColumn id = new DataColumn();
            id.ColumnName = "ID";
            columns[0] = id;

            DataColumn desc = new DataColumn();
            desc.ColumnName = "Servico";
            columns[1] = desc;

            return columns;
        }

        public static DataColumn[] CarregaColunasOrdemServico()
        {
            DataColumn[] columns = new DataColumn[6];

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Descricao";
            columns[1] = Descricao;

            DataColumn Quantidade = new DataColumn();
            Quantidade.ColumnName = "Quantidade";
            columns[2] = Quantidade;

            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Valor";
            columns[3] = Valor;

            DataColumn Total = new DataColumn();
            Total.ColumnName = "Total";
            columns[4] = Total;
            return columns;

        }

        public static DataColumn[] GetLavados()
        {
            DataColumn[] columns = new DataColumn[5];

            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Cliente";
            columns[1] = Descricao;

            DataColumn Quantidade = new DataColumn();
            Quantidade.ColumnName = "Placa";
            columns[2] = Quantidade;

            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Lavado";
            columns[3] = Valor;

        
            return columns;
        }


        public static DataColumn[] ServicoCarregaColunas()
        {
            DataColumn[] columns = new DataColumn[6];

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Descricao = new DataColumn();
            Descricao.ColumnName = "Descricao";
            columns[1] = Descricao;

            DataColumn Quantidade = new DataColumn();
            Quantidade.ColumnName = "Quantidade";
            columns[2] = Quantidade;

            DataColumn Valor = new DataColumn();
            Valor.ColumnName = "Valor";
            columns[3] = Valor;

            DataColumn Total = new DataColumn();
            Total.ColumnName = "Total";
            columns[4] = Total;

            DataColumn Lavador = new DataColumn();
            Total.ColumnName = "Lavador";
            columns[5] = Lavador;
            return columns;


        }

        public static DataColumn[] ColunasCarroLavando()
        {
            DataColumn[] columns = new DataColumn[4];

            DataColumn placa = new DataColumn();
            placa.ColumnName = "Placa";
            columns[0] = placa;

            DataColumn clie = new DataColumn();
            clie.ColumnName = "Carro";
            columns[1] = clie;

            DataColumn sai = new DataColumn();
            sai.ColumnName = "Saida";
            columns[2] = sai;

            return columns;
        }

        public static DataColumn[] GetOrdemServico(Servico servico)
        {
            DataColumn[] columns = new DataColumn[4];

            DataColumn ID = new DataColumn();
            ID.ColumnName = "ID";
            columns[0] = ID;

            DataColumn Cliente = new DataColumn();
            Cliente.ColumnName = "Cliente";
            columns[1] = Cliente;

            DataColumn Placa = new DataColumn();
            Placa.ColumnName = "Placa";
            columns[2] = Placa;

            DataColumn Data = new DataColumn();
            Data.ColumnName = "Data";
            columns[3] = Data;


            return columns;
        }


    }
}
