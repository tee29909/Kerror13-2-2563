using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedSurveyOperators
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.SurveyOperators.Any())
                {
                    return;   // DB has been seeded
                }


                context.SurveyOperators.AddRange(
               new SurveyOperators
               {
                   Type_SurveyID = 1,
                   Date = DateTime.Parse("2020-9-19"),
                   SurveyCount = 5,
                   SurveyID = 1

               }
               );

                context.SurveyOperators.AddRange(
               new SurveyOperators
               {
                   Type_SurveyID = 2,
                   Date = DateTime.Parse("2020-10-19"),
                   SurveyCount = 5,
                   SurveyID = 2

               }
               );
                context.SurveyOperators.AddRange(
               new SurveyOperators
               {
                   Type_SurveyID = 1,
                   Date = DateTime.Parse("2020-11-19"),
                   SurveyCount = 6,
                   SurveyID = 3

               }
               );

                context.SurveyOperators.AddRange(
               new SurveyOperators
               {
                   Type_SurveyID = 2,
                   Date = DateTime.Parse("2020-12-19"),
                   SurveyCount = 4,
                   SurveyID = 4

               }
               );
                context.SaveChanges();
            }
        }
    }
}
