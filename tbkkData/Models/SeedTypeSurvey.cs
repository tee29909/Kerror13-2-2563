using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedTypeSurvey
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Type_Survey.Any())
                {
                    return;   // DB has been seeded
                }


                context.Type_Survey.AddRange(
               new Type_Survey
               {
                   TypeSurvey = "Open"

               }
               );

                context.Type_Survey.AddRange(
                new Type_Survey
                {
                    TypeSurvey = "Close"

                }
                );
                context.SaveChanges();
            }
        }
    }
}
