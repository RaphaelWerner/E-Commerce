using Api.Promocao.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class ProdutosModel
    {
        public void VincularPromocaoAoProduto(EnumPromocao idDaPromocao, int idDoProduto)
        {
            Dados.ProdutosDados._produtos.First(x => x.Id == idDoProduto).Promocao = idDaPromocao;
            
        }
    }
}
