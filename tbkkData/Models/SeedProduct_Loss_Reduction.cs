using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedProduct_Loss_Reduction
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Product_Loss_Reduction.Any())
                {
                    return;   // DB has been seeded
                }


                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-1-1"),
                   Limits = 2.58,
                   Man_Hr_Per_pc = 1.65,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-2-1"),
                   Limits = 1.78,
                   Man_Hr_Per_pc = 1.85,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-3-1"),
                   Limits = 1.98,
                   Man_Hr_Per_pc = 2.05,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-4-1"),
                   Limits = 1.75,
                   Man_Hr_Per_pc = 2.91,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-5-1"),
                   Limits = 1.78,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-6-1"),
                  Limits = 2.18,
                  Man_Hr_Per_pc = 2.45,
                  type_productLoossID = 1

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-7-1"),
                   Limits = 1.58,
                   Man_Hr_Per_pc = 1.25,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-8-1"),
                   Limits = 1.48,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-9-1"),
                   Limits = 1.75,
                   Man_Hr_Per_pc = 1.91,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-10-1"),
                   Limits = 2.78,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-11-1"),
                  Limits = 2.18,
                  Man_Hr_Per_pc = 1.45,
                  type_productLoossID = 1

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-12-1"),
                   Limits = 1.58,
                   Man_Hr_Per_pc = 1.25,
                   type_productLoossID = 1

               }
               );

                context.Product_Loss_Reduction.AddRange(
            new Product_Loss_Reduction
            {
                Date = DateTime.Parse("2020-1-1"),
                Limits = 2.18,
                Man_Hr_Per_pc = 1.45,
                type_productLoossID = 2

            }
            );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-2-1"),
                   Limits = 1.58,
                   Man_Hr_Per_pc = 1.25,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-3-1"),
                   Limits = 1.48,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-4-1"),
                   Limits = 1.75,
                   Man_Hr_Per_pc = 1.91,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-5-1"),
                   Limits = 2.78,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-6-1"),
                  Limits = 2.18,
                  Man_Hr_Per_pc = 1.45,
                  type_productLoossID = 2

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-7-1"),
                   Limits = 1.58,
                   Man_Hr_Per_pc = 1.25,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-8-1"),
                   Limits = 1.48,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-9-1"),
                   Limits = 1.75,
                   Man_Hr_Per_pc = 1.91,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-10-1"),
                   Limits = 2.78,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-11-1"),
                  Limits = 2.18,
                  Man_Hr_Per_pc = 1.45,
                  type_productLoossID = 2

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-12-1"),
                   Limits = 2.58,
                   Man_Hr_Per_pc = 1.25,
                   type_productLoossID = 2

               }
               );

                context.Product_Loss_Reduction.AddRange(
            new Product_Loss_Reduction
            {
                Date = DateTime.Parse("2020-1-1"),
                Limits = 2.18,
                Man_Hr_Per_pc = 1.45,
                type_productLoossID = 3

            }
            );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-2-1"),
                   Limits = 1.58,
                   Man_Hr_Per_pc = 1.25,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-3-1"),
                   Limits = 2.48,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-4-1"),
                   Limits = 2.10,
                   Man_Hr_Per_pc = 1.10,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-5-1"),
                   Limits = 2.79,
                   Man_Hr_Per_pc = 2.99,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-6-1"),
                  Limits = 2.18,
                  Man_Hr_Per_pc = 1.48,
                  type_productLoossID = 3

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-7-1"),
                   Limits = 1.57,
                   Man_Hr_Per_pc = 1.27,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-8-1"),
                   Limits = 1.46,
                   Man_Hr_Per_pc = 2.96,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-9-1"),
                   Limits = 1.75,
                   Man_Hr_Per_pc = 1.95,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-10-1"),
                   Limits = 2.74,
                   Man_Hr_Per_pc = 2.94,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-11-1"),
                  Limits = 2.13,
                  Man_Hr_Per_pc = 1.43,
                  type_productLoossID = 3

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-12-1"),
                   Limits = 1.53,
                   Man_Hr_Per_pc = 1.23,
                   type_productLoossID = 3

               }
               );

                context.Product_Loss_Reduction.AddRange(
            new Product_Loss_Reduction
            {
                Date = DateTime.Parse("2020-1-1"),
                Limits = 2.12,
                Man_Hr_Per_pc = 1.42,
                type_productLoossID = 4

            }
            );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-2-1"),
                   Limits = 1.51,
                   Man_Hr_Per_pc = 1.21,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-3-1"),
                   Limits = 2.48,
                   Man_Hr_Per_pc = 2.95,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-4-1"),
                   Limits = 1.95,
                   Man_Hr_Per_pc = 1.91,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-5-1"),
                   Limits = 2.88,
                   Man_Hr_Per_pc = 2.85,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-6-1"),
                  Limits = 2.78,
                  Man_Hr_Per_pc = 1.75,
                  type_productLoossID = 4

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-7-1"),
                   Limits = 1.68,
                   Man_Hr_Per_pc = 1.65,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-8-1"),
                   Limits = 1.58,
                   Man_Hr_Per_pc = 2.55,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-9-1"),
                   Limits = 1.45,
                   Man_Hr_Per_pc = 1.41,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-10-1"),
                   Limits = 2.38,
                   Man_Hr_Per_pc = 2.35,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-11-1"),
                  Limits = 2.28,
                  Man_Hr_Per_pc = 1.25,
                  type_productLoossID = 4

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-12-1"),
                   Limits = 1.18,
                   Man_Hr_Per_pc = 1.15,
                   type_productLoossID = 4

               }
               );

                context.Product_Loss_Reduction.AddRange(
            new Product_Loss_Reduction
            {
                Date = DateTime.Parse("2020-1-1"),
                Limits = 2.11,
                Man_Hr_Per_pc = 1.42,
                type_productLoossID = 5

            }
            );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-2-1"),
                   Limits = 1.53,
                   Man_Hr_Per_pc = 1.24,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-3-1"),
                   Limits = 1.45,
                   Man_Hr_Per_pc = 2.96,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-4-1"),
                   Limits = 1.77,
                   Man_Hr_Per_pc = 1.98,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-5-1"),
                   Limits = 2.79,
                   Man_Hr_Per_pc = 2.90,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-6-1"),
                  Limits = 2.10,
                  Man_Hr_Per_pc = 1.40,
                  type_productLoossID = 5

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-7-1"),
                   Limits = 1.50,
                   Man_Hr_Per_pc = 1.20,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-8-1"),
                   Limits = 1.40,
                   Man_Hr_Per_pc = 2.90,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-9-1"),
                   Limits = 1.70,
                   Man_Hr_Per_pc = 1.90,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-10-1"),
                   Limits = 2.70,
                   Man_Hr_Per_pc = 2.90,
                   type_productLoossID = 5

               }
               );

                context.Product_Loss_Reduction.AddRange(
              new Product_Loss_Reduction
              {
                  Date = DateTime.Parse("2020-11-1"),
                  Limits = 2.10,
                  Man_Hr_Per_pc = 1.20,
                  type_productLoossID = 5

              }
              );

                context.Product_Loss_Reduction.AddRange(
               new Product_Loss_Reduction
               {
                   Date = DateTime.Parse("2020-12-1"),
                   Limits = 1.30,
                   Man_Hr_Per_pc = 1.40,
                   type_productLoossID = 5

               }
               );
                context.SaveChanges();
            }
        }
    }
}
