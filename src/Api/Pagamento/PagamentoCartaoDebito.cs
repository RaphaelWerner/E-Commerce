using Api.Pagamento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Pagamento
{
    public class PagamentoCartaoDebito : IProcessaPagamento
    {
        public bool ProcessarPagamento(decimal valor, int parcela)
        {
            throw new NotImplementedException();
        }
    }
}
