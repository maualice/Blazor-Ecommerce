﻿using System.Net.Http.Json;
using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services.ProductService
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _http;

		public ProductService(HttpClient http)
		{
			_http = http;
		}

		public List<Product> Products { get; set; } = new List<Product>();//by default we set this to a new list of products

		public async Task GetProducts()
		{
			var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
			if (result != null && result.Data != null)
				Products = result.Data;
		}
	}
}
