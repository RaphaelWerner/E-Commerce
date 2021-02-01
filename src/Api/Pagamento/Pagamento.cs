using Api.Pagamento.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Pagamento
{
    public class Pagamento
    {
        public bool ProcessarPagamento(EnumPagamento enumPagamento, decimal valor, int parcelas)
        {
            string descricao = new Util.Util().GetEnumDescription(enumPagamento);

            var retorno = new Util.Util().MetodoGenerico(descricao,"", new Type[] { typeof(decimal), typeof(int) }, new object[] { valor, parcelas });

            return (bool)retorno;
        }
    }
}
