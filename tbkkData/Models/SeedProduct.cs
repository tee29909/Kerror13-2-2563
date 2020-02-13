using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedProduct
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }


                    context.Product.AddRange(
               new Product
               {
                   Name = "Hydraulic cylinder",
                   //Stock = 100,
                   CostPrice = 1500,
                   SellingPrice = 2000,
                   Status = "Manufacture",
                   PartnersID = 1,

               }
               );
                    context.Product.AddRange(
                   new Product
                   {
                       Name = "Shock absorber",
                       //Stock = 100,
                       CostPrice = 2500,
                       SellingPrice = 3000,
                       Status = "Manufacture",
                       PartnersID = 2,

                   }
                   );
                    context.Product.AddRange(
                   new Product
                   {
                       Name = "Brake cylinder",
                       //Stock = 100,
                       CostPrice = 1000,
                       SellingPrice = 1500,
                       Status = "Manufacture",
                       PartnersID = 3,

                   }
                   );
                    context.Product.AddRange(
                   new Product
                   {
                       Name = "Caliper",
                       //Stock = 100,
                       CostPrice = 500,
                       SellingPrice = 1000,
                       Status = "Manufacture",
                       PartnersID = 4,

                   }
                   );
                    context.Product.AddRange(
                   new Product
                   {
                       Name = "Disc brakes",
                       //Stock = 100,
                       CostPrice = 2000,
                       SellingPrice = 2500,
                       Status = "Manufacture",
                       PartnersID = 5,

                   }
                   );



                context.SaveChanges();
            }
        }
    }
}
