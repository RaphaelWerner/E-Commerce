using Api.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dados;
using System.Reflection;
using Api.Promocao;

namespace Api.Model
{
    public class CarrinhoModel
    {
        readonly Carrinho carrinho;
		public CarrinhoModel()
        {
			carrinho = CarrinhoDados._carrinho;

		}
		public void AdicionarItem(Item item)
		{
			var itensCarrinho = carrinho.Items.FirstOrDefault(x => x.IdDoProduto == item.IdDoProduto);

			if (itensCarrinho == null)
				carrinho.Items.Add(item);
			else
				itensCarrinho.Quantidade += item.Quantidade;
		}

		public void LimparCarrinho()
		{
			carrinho.Items.Clear();
		}

		public decimal ObterTotalDoCarrinho()
		{
			decimal valorTotal = 0;
			
			foreach (var item in carrinho.Items)
			{
				var produto = Dados.ProdutosDados._produtos.First(produto => produto.Id == item.IdDoProduto);
				var valorDesconto = new Promocao.Desconto().GetDesconto(produto,item.Quantidade);

				valorTotal += (produto.Preco * item.Quantidade) - valorDesconto;

			}
			return valorTotal;
		}
	}
}
