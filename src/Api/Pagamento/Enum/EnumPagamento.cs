using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Pagamento.Enum
{
    public enum EnumPagamento
    {
        [Description("Pagamento.PagamentoBoleto")]
        Boleto,
        [Description("Pagamento.PagamentoCartaoDebito")]
        CartaoDebito,
        [Description("Pagamento.PagamentoCartaoCredito")]
        CartaoCredito,
        [Description("Pagamento.PagamentoBitcoin")]
        Bitcoin,
        [Description("Pagamento.PagamentoEthereum")]
        Ethereum,
    }
}
