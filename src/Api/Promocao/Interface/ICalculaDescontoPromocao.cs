using Api.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Promocao.Interface
{
    interface ICalculaDescontoPromocao
    {
        public decimal CalcularDescontoPromocao(Produto produto, int qtdProduto);
    }
}
