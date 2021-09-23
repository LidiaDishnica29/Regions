using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RegionsTask;
using RegionsTask.Context;
using System;
using System.Linq;

namespace RegionTest
{
    public class CustomWebApplicationFactory<TStartup> : WebApplicationFactory<Startup> 
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var configuration = new ConfigurationBuilder().Build();

            var coonnn = configuration.GetSection("ConnectionStrings").GetSection("RegionCS").Value;
            builder.ConfigureServices(services =>
            {
            

                services.AddScoped(typeof(RegionsTaskContext), (provider) =>
                {
                    services.AddDbContext<RegionsTaskContext>((provider, options) =>
                    {
                        options.UseInternalServiceProvider(provider);
                    });

                    var res = Activator.CreateInstance(typeof(RegionsTaskContext), coonnn);

                    return res;
                });
            });
        }
        //override methods here as needed
        protected override IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureWebHostDefaults(builder =>
            builder
            .UseStartup<Startup>());
        }
    }
}
