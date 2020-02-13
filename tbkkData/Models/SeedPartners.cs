using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedPartners
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Partners.Any())
                {
                    return;   // DB has been seeded
                }


                context.Partners.AddRange(
                new Partners
                {
                    FirstName = "Serafim",
                    LastName = "William",
                    Address = "Ancient Britain ",
                    Email = "Serafim@hotmail.com",
                    Telephone = "0987654321"
                }
                );
  
                context.Partners.AddRange(
                new Partners
                {
                    FirstName = "Nicholas",
                    LastName = "Oscar",
                    Address = "Manchester",
                    Email = "Nicholas@gmail.com",
                    Telephone = "0809101112"
                }
                );

                context.Partners.AddRange(
                new Partners
                {
                    FirstName = "Aaron",
                    LastName = "Ethan",
                    Address = "Nottingham",
                    Email = "Aaron_Ethan@co.th.com",
                    Telephone = "0678910111"
                }
                );

                context.Partners.AddRange(
                new Partners
                {
                    FirstName = "Keith",
                    LastName = "Maverick",
                    Address = "Norwich",
                    Email = "Keith@hotmail.com",
                    Telephone = "09123456789"
                }
                );

                context.Partners.AddRange(
                new Partners
                {
                    FirstName = "Seth",
                    LastName = "Todd",
                    Address = "Plymouth",
                    Email = "Plymouth@gmail.com",
                    Telephone = "0807060504"
                }
                );








                context.SaveChanges();
            }
        }
    }
    
}
