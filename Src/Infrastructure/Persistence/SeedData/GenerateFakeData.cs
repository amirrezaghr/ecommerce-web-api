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
                if (!await context.ProductBrand.AnyAsync())
                {
                    var brands = ProductBrand();
                    await context.ProductBrand.AddRangeAsync(brands);
                    await context.SaveChangesAsync();
                }
                if (!await context.ProductType.AnyAsync())
                {
                    var types = ProductTypes();
                    await context.ProductType.AddRangeAsync(types);
                    await context.SaveChangesAsync();
                }
                if (!await context.Products.AnyAsync())
                {
                    //TODO picture url
                    var products = Products();
                    await context.Products.AddRangeAsync(products);
                    await context.SaveChangesAsync();
                }


            }
			catch (Exception e)
			{

				var logger = loggerFactory.CreateLogger<GenerateFakeData>();
				logger.LogError(e, "error in seed Data");
			}
        }

        private static IEnumerable<ProductType> ProductTypes()
        {
            return new List<ProductType>()
                    {
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            Title = "type1"
                        },
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            Title = "type2"
                        }
                    };
        }

        private static IEnumerable<ProductBrand> ProductBrand()
        {
            return new List<ProductBrand>()
                    {
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            Title = "brand1"
                        },
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            Title = "brand2"
                        }
                    };
        }

        private static IEnumerable<Product> Products()
        {
            return new List<Product>
                    {
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "product 1",
                            ProductTypeId = 1,
                            ProductBrandId = 1,
                        },
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "product 2",
                            ProductTypeId = 1,
                            ProductBrandId = 1,
                        },
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "product 3",
                            ProductTypeId = 1,
                            ProductBrandId = 1,
                        },
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "product 4",
                            ProductTypeId = 1,
                            ProductBrandId = 1,
                        },
                        new()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                            Summery = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit",
                            PictureUrl = "",
                            Price = 15000,
                            Title = "product 5",
                            ProductTypeId = 1,
                            ProductBrandId = 1,
                        },
                    };
        }
    }
}
