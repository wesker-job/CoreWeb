using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace CoreWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureLogging((hostingContext, logging) =>
            {
                //logging.ClearProviders();
                //logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddDebug();
                logging.AddNLog();
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    }
}
