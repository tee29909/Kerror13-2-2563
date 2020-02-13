using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedManufacture
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Manufacture.Any())
                {
                    return;   // DB has been seeded
                }


                context.Manufacture.AddRange(
               new Manufacture
               {
                   Quantity = 7,
                   Date = DateTime.Parse("2020-8-19"),
                   ProductID = 3,
                   EmployeeID = 3,
                   //CompanyID = 1

               }
               );
                context.Manufacture.AddRange(
               new Manufacture
               {
                   Quantity = 5,
                   Date = DateTime.Parse("2020-9-19"),
                   ProductID = 5,
                   EmployeeID = 2,
                  // CompanyID = 2
               }
               );
                context.Manufacture.AddRange(
               new Manufacture
               {
                   Quantity = 6,
                   Date = DateTime.Parse("2020-9-19"),
                   ProductID = 4,
                   EmployeeID = 5,
                  // CompanyID = 1
               }
               );
                context.Manufacture.AddRange(
               new Manufacture
               {
                   Quantity = 6,
                   Date = DateTime.Parse("2020-10-19"),
                   ProductID = 3,
                   EmployeeID = 8,
                   //CompanyID = 2

               }
               );
                context.Manufacture.AddRange(
               new Manufacture
               {
                   Quantity = 5,
                   Date = DateTime.Parse("2020-11-19"),
                   ProductID = 2,
                   EmployeeID = 15,
                   //CompanyID = 1
               }
               );
                context.Manufacture.AddRange(
               new Manufacture
               {
                   Quantity = 4,
                   Date = DateTime.Parse("2020-12-19"),
                   ProductID = 1,
                   EmployeeID = 20,
                   //CompanyID = 1
               }
               );
                context.SaveChanges();
            }
        }
    }
}
