using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedProject_Product
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
               

                if (context.Project_Product.Any())
                    {
                        return;   // DB has been seeded
                    }


                context.Project_Product.AddRange(
           new Project_Product
           {
               Qty = 10,
               ProductID = 1,
               ProjectID = 1
           }
           );
                context.Project_Product.AddRange(
              new Project_Product
              {
                  Qty = 15,
                  ProductID = 2,
                  ProjectID = 1
              }
              );
                context.Project_Product.AddRange(
              new Project_Product
              {
                  Qty = 20,
                  ProductID = 3,
                  ProjectID = 1
              }
              );
                context.Project_Product.AddRange(
              new Project_Product
              {
                  Qty = 5,
                  ProductID = 4,
                  ProjectID = 1
              }
              );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 15,
                       ProductID = 5,
                       ProjectID = 2
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 1,
                       ProjectID = 2
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 15,
                       ProductID = 2,
                       ProjectID = 2
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 5,
                       ProductID = 3,
                       ProjectID = 2
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 20,
                       ProductID = 4,
                       ProjectID = 3
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 5,
                       ProjectID = 3
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 20,
                       ProductID = 1,
                       ProjectID = 3
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 2,
                       ProjectID = 3
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 20,
                       ProductID = 3,
                       ProjectID = 3
                   }
                   );


                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 5,
                       ProductID = 4,
                       ProjectID = 4
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 15,
                       ProductID = 5,
                       ProjectID = 4
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 5,
                       ProductID = 1,
                       ProjectID = 4
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 15,
                       ProductID = 2,
                       ProjectID = 4
                   }
                   );


                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 3,
                       ProjectID = 5
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 4,
                       ProjectID = 5
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 5,
                       ProjectID = 5
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 1,
                       ProjectID = 5
                   }
                   );


                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 15,
                       ProductID = 2,
                       ProjectID = 6
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 3,
                       ProjectID = 6
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 15,
                       ProductID = 4,
                       ProjectID = 6
                   }
                   );

                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 5,
                       ProjectID = 7
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 20,
                       ProductID = 1,
                       ProjectID = 7
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 10,
                       ProductID = 2,
                       ProjectID = 7
                   }
                   );
                context.Project_Product.AddRange(
                   new Project_Product
                   {
                       Qty = 20,
                       ProductID = 3,
                       ProjectID = 7
                   }
                   );


                context.Project_Product.AddRange(
                 new Project_Product
                 {
                     Qty = 5,
                     ProductID = 4,
                     ProjectID = 8
                 }
                 );
                context.Project_Product.AddRange(
                 new Project_Product
                 {
                     Qty = 5,
                     ProductID = 5,
                     ProjectID = 8
                 }
                 );
                context.Project_Product.AddRange(
                 new Project_Product
                 {
                     Qty = 5,
                     ProductID = 1,
                     ProjectID = 8
                 }
                 ); context.Project_Product.AddRange(
                  new Project_Product
                  {
                      Qty = 15,
                      ProductID = 2,
                      ProjectID = 8
                  }
                  );



                context.SaveChanges();
            }
        }
    }
}
