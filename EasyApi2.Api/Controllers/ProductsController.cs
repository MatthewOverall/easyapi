using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyApi2.Api.Models;

namespace EasyApi2.Api.Controllers
{
	public class ProductsController : ApiController
	{
		EasyContext context = new EasyContext();
		public IEnumerable<Product> Get()
		{
			return context.Products;
		}
	}
}
