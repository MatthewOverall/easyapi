using EasyApi2.Api.Models;
using SimpleFixture;

namespace EasyApi2.Api.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EasyApi2.Api.Models.EasyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EasyApi2.Api.Models.EasyContext context)
        {
			//var fixture = new Fixture();

		
	  //      for (int i = 5; i < 90; i++)
	  //      {
		 //       context.Products.Add(new Product()
		 //       {
			//		Name = "Product " + i,
			//		OrderId = i,
			//		Price = i * 23,
					
						 
		 //       });
	  //      }
	  //      context.SaveChanges();

        }
    }
}
