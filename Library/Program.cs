using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Library
{
    // Entry point for the application
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set up the web host that we want to run when the app starts
            var host = new WebHostBuilder()
                .UseKestrel() // Lightweight server
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration() // Full fledge server
                .UseStartup<Startup>() // Startup class (.cs) where we set up configurations and middlewares for the application 
                .UseApplicationInsights()
                .Build();

            host.Run();
        }
    }
}
