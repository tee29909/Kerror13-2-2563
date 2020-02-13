using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedRival_Product
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Rival_Product.Any())
                {
                    return;   // DB has been seeded
                }

                        context.Rival_Product.AddRange(
                    new Rival_Product
                    {
                
                        RivDate = DateTime.Parse("2020-2-2"),
                        Price = 3500,
                        ProductID = 1,
                        RivalID = 1
                    }
                    ) ;
                    context.Rival_Product.AddRange(
                    new Rival_Product
                    {
                        
                        RivDate = DateTime.Parse("2020-4-2"),
                        Price = 1500,
                        ProductID = 2,
                        RivalID = 1
                    }
                    );
                    context.Rival_Product.AddRange(
                    new Rival_Product
                    {
                        
                        RivDate = DateTime.Parse("2020-6-2"),
                        Price = 2000,
                        ProductID = 3,
                        RivalID = 1
                    }
                    );
                    context.Rival_Product.AddRange(
                    new Rival_Product
                    {
                        
                        RivDate = DateTime.Parse("2020-8-2"),
                        Price = 2500,
                        ProductID = 4,
                        RivalID = 1
                    }
                    );
                    context.Rival_Product.AddRange(
                    new Rival_Product
                    {
                        
                        RivDate = DateTime.Parse("2020-10-2"),
                        Price = 3000,
                        ProductID = 5,
                        RivalID = 1
                    }
                    );
                context.Rival_Product.AddRange(
                   new Rival_Product
                   {

                       RivDate = DateTime.Parse("2020-2-2"),
                       Price = 1500,
                       ProductID = 1,
                       RivalID = 2
                   }
                   );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-4-2"),
                    Price = 2500,
                    ProductID = 2,
                    RivalID = 2
                }
                );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-6-2"),
                    Price = 1500,
                    ProductID = 3,
                    RivalID = 2
                }
                );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-8-2"),
                    Price = 2900,
                    ProductID = 4,
                    RivalID = 2
                }
                );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-10-2"),
                    Price = 2000,
                    ProductID = 5,
                    RivalID = 2
                }
                );
                context.Rival_Product.AddRange(
                   new Rival_Product
                   {

                       RivDate = DateTime.Parse("2020-2-2"),
                       Price = 3000,
                       ProductID = 1,
                       RivalID = 3
                   }
                   );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-4-2"),
                    Price = 2500,
                    ProductID = 2,
                    RivalID = 3
                }
                );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-6-2"),
                    Price = 2100,
                    ProductID = 3,
                    RivalID = 3
                }
                );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-8-2"),
                    Price = 3200,
                    ProductID = 4,
                    RivalID = 3
                }
                );
                context.Rival_Product.AddRange(
                new Rival_Product
                {

                    RivDate = DateTime.Parse("2020-10-2"),
                    Price = 2000,
                    ProductID = 5,
                    RivalID = 3
                }
                );



                context.SaveChanges();
            }
        }
    }
}
