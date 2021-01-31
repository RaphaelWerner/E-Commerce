using Api.Model;
using Api.Object;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CarrinhoController : ControllerBase
	{
        readonly CarrinhoModel ModelCarrinho;
		public CarrinhoController()
        {
			ModelCarrinho = new CarrinhoModel();

		}
		[HttpPost("Item")]
		public void AdicionarItem(Item item)
		{
			ModelCarrinho.AdicionarItem(item);
		}

		[HttpPost("LimparCarrinho")]
		public void LimparCarrinho()
		{
			ModelCarrinho.LimparCarrinho();
		}

		[HttpGet("Total")]
		public decimal ObterTotalDoCarrinho()
		{
			return ModelCarrinho.ObterTotalDoCarrinho(); ;
		}
	}

}
