using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Seedtype_productLooss
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.type_productLooss.Any())
                {
                    return;   // DB has been seeded
                }


                context.type_productLooss.AddRange(
               new type_productLooss
               {
                   Name = "pd1 Overall"

               }
               );
               
                context.type_productLooss.AddRange(
              new type_productLooss
              {
                  Name = "A26"

              }
              );
                context.type_productLooss.AddRange(
              new type_productLooss
              {
                  Name = "A25"

              }
              );
                context.type_productLooss.AddRange(
              new type_productLooss
              {
                  Name = "A17"

              }
              );
                 context.type_productLooss.AddRange(
              new type_productLooss
              {
                  Name = "A19"

              }
              );
                context.SaveChanges();
            }
        }
    }
}

