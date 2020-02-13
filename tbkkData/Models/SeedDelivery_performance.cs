using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedDelivery_performance
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Delivery_performance.Any())
                {
                    return;   // DB has been seeded
                }


                context.Delivery_performance.AddRange(
               new Delivery_performance
               {
                   Complains_Delivery = 4,
                   Claim_Delivery = 6,
                   DateDelivery = DateTime.Parse("2020-9-19"),
                   EmployeeID = 1

               }
               );
                context.Delivery_performance.AddRange(
               new Delivery_performance
               {
                   Complains_Delivery = 4,
                   Claim_Delivery = 6,
                   DateDelivery = DateTime.Parse("2020-10-19"),
                   EmployeeID = 2

               }
               );
                context.Delivery_performance.AddRange(
               new Delivery_performance
               {
                   Complains_Delivery = 4,
                   Claim_Delivery = 6,
                   DateDelivery = DateTime.Parse("2020-11-19"),
                   EmployeeID = 3

               }
               );

                context.SaveChanges();
            }
        }
    }
}
