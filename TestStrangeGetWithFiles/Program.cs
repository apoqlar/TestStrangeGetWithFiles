using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TestStrangeGetWithFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel(options => { options.Limits.MaxRequestBodySize = null; })
                        .UseSetting("detailedErrors", "true")
                        .CaptureStartupErrors(true)
                        .UseStartup<Startup>();
                });
    }
}
