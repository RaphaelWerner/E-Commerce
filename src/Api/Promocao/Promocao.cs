using Api.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Promocao
{
    public class Promocao
    {
        public decimal GetDesconto(Produto produto, int qtdProduto)
        {
            try
            {
                //Pega a descrição do EnumPromocao, que contém o nome da Classe da Promocao   
                string descricao = new Util.Util().GetDescricaoEnum(produto.Promocao);

                var retorno = new Util.Util().MetodoGenerico(descricao, "CalcularDescontoPromocao", new Type[] { typeof(Produto), typeof(int) }, new object[] { produto, qtdProduto });

                return (decimal)retorno;

            }
            catch
            {
                return 0;
            }
             
        }
    }
}
