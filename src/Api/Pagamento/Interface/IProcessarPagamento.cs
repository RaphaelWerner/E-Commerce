using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Pagamento.Interfaces
{
    interface IProcessaPagamento
    {
        public bool ProcessarPagamento(decimal valor, int parcela);
    }
}
