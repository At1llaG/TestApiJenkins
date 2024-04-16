using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace TestApi
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            while (true)
            {
                Console.WriteLine("hello");
                Thread.Sleep(1000); // Sleep for 1 second to avoid excessive output
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://localhost:6001"); // Change port as needed
                });
    }
}
