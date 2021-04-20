using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MovieApp.Models;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Net.Http.Formatting;

namespace MovieApp
{
    public class Program
    {
        // Instantiating a single instance of httpclient for req/res
        // private static readonly HttpClient client = new HttpClient();
        
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();

            var host = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, builder) =>
                {
                    if (hostContext.HostingEnvironment.IsDevelopment())
                    {
                        builder.AddUserSecrets<Program>();
                    } 
                    else 
                    {
                        CreateHostBuilder(args).Build().Run();
                    }
                })
                .Build();
            
            host.Run();
            
        }      

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}
