using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedSafety
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Safety.Any())
                {
                    return;   // DB has been seeded
                }


                context.Safety.AddRange(
               new Safety
               {

                   DateIncident = DateTime.Parse("2020-1-1"),
                   incident = 4,
                   Total_Incident = 5

               }
               );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-2-1"),
                  incident = 2,
                  Total_Incident = 7
              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-3-1"),
                  incident = 2,
                  Total_Incident = 1

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-4-1"),
                  incident = 0,
                  Total_Incident = 1

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-5-1"),
                  incident = 2,
                  Total_Incident = 2

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-6-1"),
                  incident = 1,
                  Total_Incident = 6

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-7-1"),
                  incident = 3,
                  Total_Incident = 4

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-8-1"),
                  incident = 2,
                  Total_Incident = 5

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-9-1"),
                  incident = 5,
                  Total_Incident = 2

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-10-1"),
                  incident = 4,
                  Total_Incident = 3

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-11-1"),
                  incident = 3,
                  Total_Incident = 4

              }
              );

                context.Safety.AddRange(
              new Safety
              {

                  DateIncident = DateTime.Parse("2020-12-1"),
                  incident = 1,
                  Total_Incident = 5

              }
              );
                context.SaveChanges();
            }
        }
    }
}
