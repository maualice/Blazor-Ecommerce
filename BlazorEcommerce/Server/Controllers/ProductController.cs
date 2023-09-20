using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private static List<Product> Products = new List<Product>
		{
			new Product
			{
			Id=1,
			Title="The Hitchhiker's Guide to the Galaxy",
			Description="The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
			ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
			Price=9.99m
			},
			new Product
			{
			Id=2,
			Title="Ready Player One",
			Description="Ready Player One es una novela de ciencia ficción escrita por el autor estadounidense Ernest Cline y cuya edición original en inglés fue publicada el 16 de agosto de 2011 por la editorial Crown Publishers (una filial de Random House).1​ La edición en español fue publicada por primera vez en 2011 por Ediciones B.2​ También se realizó una adaptación para el cine dirigida por Steven Spielberg, la cual se estrenó mundialmente el 30 de marzo de 2018. El libro fue un superventas de The New York Times.3​",
			ImageUrl="https://th.bing.com/th/id/OIP.uqT9-RP8uTi6R7UC1S8uRgAAAA?pid=ImgDet&rs=1",
			Price=9.99m
			},
			new Product
			{
			Id=3,
			Title="Nineteen Eighty-Four",
			Description="Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
			ImageUrl="https://th.bing.com/th/id/OIP.yU-ZjTsJ6PznQQWbFmhJlAAAAA?pid=ImgDet&rs=1",
			Price=9.99m
			}
		};

	[HttpGet]

		public async Task<ActionResult<List<Product>>> GetProduct ()
		{
			return Ok(Products);
		}

	}
}
