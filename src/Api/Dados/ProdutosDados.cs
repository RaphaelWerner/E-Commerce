using Api.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dados
{
    public static class ProdutosDados
    {
		public static readonly List<Produto> _produtos = new List<Produto>
		{
			new Produto { Id = 1, Nome = "PS5", Preco = 50 },
			new Produto { Id = 2, Nome = "TV do Edi 32 polegadas (Modelo 2002)", Preco = 30 },
			new Produto { Id = 3, Nome = "Sanfona do Buxin", Preco = 10 }
		};
	}


}
