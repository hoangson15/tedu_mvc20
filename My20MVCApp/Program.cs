using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using My20MVCApp.Data.EF;
using System;

namespace My20MVCApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // build web host
            var host = BuildWebHost(args);
            using (var scope = host.Services.CreateScope())
            {
                // get service provider
                var services = scope.ServiceProvider;
                try
                {
                    // from service provider, get dbInitializer
                    // then seed data
                    var dbInitializer = services.GetService<DbInitializer>();
                    dbInitializer.Seed().Wait();
                }
                catch (Exception ex)
                {
                    var logger = services.GetService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database");
                }
            }

            // run web host
            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
