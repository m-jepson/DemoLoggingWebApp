using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace LoggingWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((webHostBuilder, loggingBuilder) =>
                {
                    loggingBuilder.AddConfiguration(webHostBuilder.Configuration.GetSection("Logging"));
                    loggingBuilder.AddNLog();
                })
                .UseStartup<Startup>()
                .Build();
    }
}
