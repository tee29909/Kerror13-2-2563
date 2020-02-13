using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedOrder_Product
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Order_Product.Any())
                {
                    return;   // DB has been seeded
                }


                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                  // Price = 1990,
                   ProductID = 1,
                   OrderID = 1
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                  // Price = 1200,
                   ProductID = 1,
                   OrderID = 2
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                  // Price = 2000,
                   ProductID = 2,
                   OrderID = 3
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                  // Price = 2100,
                   ProductID = 2,
                   OrderID = 4
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                  // Price = 2200,
                   ProductID = 3,
                   OrderID = 5
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3700,
                   ProductID = 3,
                   OrderID = 6
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                  // Price = 4000,
                   ProductID = 4,
                   OrderID = 7
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3200,
                   ProductID = 4,
                   OrderID = 8
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                   //Price = 3100,
                   ProductID = 5,
                   OrderID = 9
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                  // Price = 2500,
                   ProductID = 5,
                   OrderID = 10
               }
               );
                context.Order_Product.AddRange(
              new Order_Product
              {
                  Qty = 10,
                 // Price = 1990,
                  ProductID = 1,
                  OrderID = 11
              }
              );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 1200,
                   ProductID = 2,
                   OrderID = 12
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                   //Price = 2000,
                   ProductID = 3,
                   OrderID = 13
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                   //Price = 2100,
                   ProductID = 4,
                   OrderID = 14
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                   //Price = 2200,
                   ProductID = 5,
                   OrderID = 15
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3700,
                   ProductID = 1,
                   OrderID = 16
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                   //Price = 4000,
                   ProductID = 1,
                   OrderID = 17
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3200,
                   ProductID = 1,
                   OrderID = 18
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                   //Price = 3100,
                   ProductID = 2,
                   OrderID = 19
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                  // Price = 2500,
                   ProductID = 2,
                   OrderID = 20
               }
               );
                context.Order_Product.AddRange(
              new Order_Product
              {
                  Qty = 10,
                  //Price = 1990,
                  ProductID = 2,
                  OrderID = 21
              }
              );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 1200,
                   ProductID = 3,
                   OrderID = 22
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                   //Price = 2000,
                   ProductID = 3,
                   OrderID = 23
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                   //Price = 2100,
                   ProductID = 3,
                   OrderID = 24
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                  // Price = 2200,
                   ProductID = 4,
                   OrderID = 25
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3700,
                   ProductID = 4,
                   OrderID = 26
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                   //Price = 4000,
                   ProductID = 4,
                   OrderID = 27
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3200,
                   ProductID = 5,
                   OrderID = 28
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                   //Price = 3100,
                   ProductID = 5,
                   OrderID = 29
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                  // Price = 2500,
                   ProductID = 5,
                   OrderID = 30
               }
               );


                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                   //Price = 1990,
                   ProductID = 1,
                   OrderID = 1
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 1200,
                   ProductID = 1,
                   OrderID = 2
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                   //Price = 2000,
                   ProductID = 2,
                   OrderID = 3
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                   //Price = 2100,
                   ProductID = 2,
                   OrderID = 4
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 4,
                   //Price = 2200,
                   ProductID = 3,
                   OrderID = 5
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 11,
                  // Price = 3700,
                   ProductID = 3,
                   OrderID = 6
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 16,
                   //Price = 4000,
                   ProductID = 4,
                   OrderID = 7
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 12,
                   //Price = 3200,
                   ProductID = 4,
                   OrderID = 8
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 10,
                   //Price = 3100,
                   ProductID = 5,
                   OrderID = 9
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 9,
                   //Price = 2500,
                   ProductID = 5,
                   OrderID = 10
               }
               );
                context.Order_Product.AddRange(
              new Order_Product
              {
                  Qty = 13,
                  //Price = 1990,
                  ProductID = 1,
                  OrderID = 11
              }
              );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 13,
                   //Price = 1200,
                   ProductID = 2,
                   OrderID = 12
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 18,
                   //Price = 2000,
                   ProductID = 3,
                   OrderID = 13
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 8,
                  // Price = 2100,
                   ProductID = 4,
                   OrderID = 14
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 11,
                   //Price = 2200,
                   ProductID = 5,
                   OrderID = 15
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 114,
                  // Price = 3700,
                   ProductID = 1,
                   OrderID = 16
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 19,
                 //  Price = 4000,
                   ProductID = 1,
                   OrderID = 17
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                   //Price = 3200,
                   ProductID = 1,
                   OrderID = 18
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 11,
                   //Price = 3100,
                   ProductID = 2,
                   OrderID = 19
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 6,
                   //Price = 2500,
                   ProductID = 2,
                   OrderID = 20
               }
               );
                context.Order_Product.AddRange(
              new Order_Product
              {
                  Qty = 10,
                 // Price = 1990,
                  ProductID = 2,
                  OrderID = 21
              }
              );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 15,
                  // Price = 1200,
                   ProductID = 3,
                   OrderID = 22
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 20,
                   //Price = 2000,
                   ProductID = 3,
                   OrderID = 23
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 5,
                  // Price = 2100,
                   ProductID = 3,
                   OrderID = 24
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 12,
                  // Price = 2200,
                   ProductID = 4,
                   OrderID = 25
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 12,
                   //Price = 3700,
                   ProductID = 4,
                   OrderID = 26
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 6,
                  // Price = 4000,
                   ProductID = 4,
                   OrderID = 27
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 12,
                   //Price = 3200,
                   ProductID = 5,
                   OrderID = 28
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 12,
                   //Price = 3100,
                   ProductID = 5,
                   OrderID = 29
               }
               );
                context.Order_Product.AddRange(
               new Order_Product
               {
                   Qty = 3,
                   //Price = 2500,
                   ProductID = 5,
                   OrderID = 30
               }
               );




                context.SaveChanges();
            }
        }
    }
}
