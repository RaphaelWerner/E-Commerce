using Api.Object;
using Api.Promocao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Promocao
{
    public class PromocaoDoisPorUm : ICalculaDescontoPromocao
    {
        public decimal CalcularDescontoPromocao(Produto produto, int qtdProduto)
        {
            int resto, qtdPromocional;
            decimal desconto;

            var valorSemDesconto = qtdProduto * produto.Preco;

            resto = qtdProduto % 2;
            qtdPromocional = qtdProduto - resto;

            desconto = ((resto * produto.Preco) + (qtdPromocional * (produto.Preco / 2)));

            return valorSemDesconto - desconto;
        }
    }
}
