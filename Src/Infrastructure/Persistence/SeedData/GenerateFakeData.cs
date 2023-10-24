using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SeedData
{
    public  class GenerateFakeData
    {
        public static async Task SeedDataAsync(ApplicationDbContext context,ILoggerFactory loggerFactory)
        {
			try
			{
				if(!await context.Products.AnyAsync())
				{
                    var products = new List<Product>
                    {
                        new()
                        {
                            Description = "test",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "Test",
                            Summery = "summery test"
                        }
                    };
                    await context.Products.AddRangeAsync(products);
                    await context.SaveChangesAsync();
				}
                if (!await context.ProductBrand.AnyAsync())
                {

                }
                if (!await context.ProductType.AnyAsync())
                {

                }

            }
			catch (Exception e)
			{

				var logger = loggerFactory.CreateLogger<GenerateFakeData>();
				logger.LogError(e, "error in seed Data");
			}
        }
    }
}
