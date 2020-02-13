using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedClaim
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                    // Look for any movies.

                    if (context.Claim.Any())
                    {
                        return;   // DB has been seeded
                    }


                    context.Claim.AddRange(
                   new Claim
                   {
                       DateClaim = DateTime.Parse("2020-9-19"),
                       Status = "InComplete",
                       ComplainID = 6


                   }
                   );

                    context.Claim.AddRange(
                    new Claim
                    {
                        DateClaim = DateTime.Parse("2020-10-19"),
                        Status = "InComplete",
                        ComplainID = 16


                    }
                    );
                    context.Claim.AddRange(
                  new Claim
                  {
                      DateClaim = DateTime.Parse("2020-11-19"),
                      Status = "InComplete",
                      ComplainID = 30


                  }
                  );

                    context.Claim.AddRange(
                    new Claim
                    {
                        DateClaim = DateTime.Parse("2020-12-19"),
                        Status = "InComplete",
                        ComplainID = 9


                    }
                    );
                
                    context.SaveChanges();
            }
        }
    }
}

