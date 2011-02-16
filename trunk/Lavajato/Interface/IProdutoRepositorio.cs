using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HenryCorporation.Lavajato.DomainModel;
using System.Data;

namespace HenryCorporation.Lavajato.Interface
{
    public interface IProdutoRepositorio: IGeneric<Produto>
    {
        DataTable GetAll(List<Produto> produtos);
        DataTable ByName(Produto produto);
        DataTable TipoServico(int TipoProduto);
        DataTable GetProdutos(List<Produto> produtos);
    }
}
