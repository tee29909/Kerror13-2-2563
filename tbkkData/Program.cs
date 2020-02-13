using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using tbkkData.Models;

namespace tbkkData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();


            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogDebug("5916054259160338");
                    Seedtype_productLooss.Initialize(services);
                    
                    //SeedAgeGroup.Initialize(services);
                    SeedData.Initialize(services);
                    SeedPartners.Initialize(services);
                    SeedProduct.Initialize(services);
                    SeedOrder_Product.Initialize(services);
                    SeedProject_Product.Initialize(services);
                    SeedRival_Product.Initialize(services);
                    SeedTypeSurvey.Initialize(services);
                    //SeedStatus_Claim.Initialize(services);
                    SeedSurvey.Initialize(services);
                    SeedSafety.Initialize(services);
                    SeedProduct_Loss_Reduction.Initialize(services);
                    //SeedComplain.Initialize(services);
                    //SeedClaim.Initialize(services);
                    SeedDelivery_performance.Initialize(services);
                    SeedSurveyOperators.Initialize(services);
                    SeedManufacture.Initialize(services);



                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();




        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
