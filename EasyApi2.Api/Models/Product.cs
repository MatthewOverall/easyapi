using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace EasyApi2.Api.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int OrderId { get; set; }

		public Order Order { get; set; }
					
	}

	public class Order
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		public List<Product> Products { get; set; } 
	}

	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

		public List<Order> Orders { get; set; } 

	}
}