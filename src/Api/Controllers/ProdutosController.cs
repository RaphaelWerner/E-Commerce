using Api.Model;
using Api.Object;
using Api.Promocao.Enum;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 
namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProdutosController : ControllerBase
	{
        readonly ProdutosModel produtosModel;
		public ProdutosController()
        {
			produtosModel = new ProdutosModel();

		}
		[HttpPut("{idDoProduto}/Promocao/{idDaPromocao}")]
		public void VincularPromocaoAoProduto(EnumPromocao idDaPromocao, int idDoProduto)
		{
			produtosModel.VincularPromocaoAoProduto(idDaPromocao, idDoProduto);
			
		}
	}
}
