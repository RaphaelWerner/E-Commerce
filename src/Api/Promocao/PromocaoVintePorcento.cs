using Api.Object;
using Api.Promocao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Promocao
{
    public class PromocaoVintePorcento : ICalculaDescontoPromocao
    {
        public decimal CalcularDescontoPromocao(Produto produto, int qtdProduto)
        {
            return produto.Preco * qtdProduto * (decimal)0.20;
        }
    }
}
