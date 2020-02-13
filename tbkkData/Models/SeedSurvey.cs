using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedSurvey
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Survey.Any())
                {
                    return;   // DB has been seeded
                }


                context.Survey.AddRange(
               new Survey
               {
                   NameSurvey = "PD1"

               }
               );
                context.Survey.AddRange(
              new Survey
              {
                  NameSurvey = "PD2"

              }
              );
                context.Survey.AddRange(
              new Survey
              {
                  NameSurvey = "PD3"

              }
              );
                context.Survey.AddRange(
              new Survey
              {
                  NameSurvey = "PD4"

              }
              );
                context.Survey.AddRange(
              new Survey
              {
                  NameSurvey = "PD5"

              }
              );
                context.SaveChanges();
            }
        }
    }
}
