using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedComplain
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Complain.Any())
                {
                    return;   // DB has been seeded
                }

                context.Complain.AddRange(
                new Complain
                {
                    DateComplain = DateTime.Parse("2020-9-19"),
                    Status = "InComplete",
                   OrderID = 6
                }
                );

                context.Complain.AddRange(
                new Complain
                {
                    DateComplain = DateTime.Parse("2020-10-19"),
                    Status = "InComplete",
                    OrderID = 16
                }
                );
                context.Complain.AddRange(
              new Complain
              {
                  DateComplain = DateTime.Parse("2020-11-19"),
                  Status = "InComplete",
                  OrderID = 30
              }
              );

                context.Complain.AddRange(
                new Complain
                {
                    DateComplain = DateTime.Parse("2020-12-19"),
                    Status = "InComplete",
                    OrderID = 9
                }
                );

                context.SaveChanges();
            }
        }
    }
}

