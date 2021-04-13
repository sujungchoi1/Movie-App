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
            CreateHostBuilder(args).Build().Run();
            // RunAsync().Wait();
            // await ProcessRepositories();
            // GetData();
            // Console.ReadLine();
            // Console.ReadKey();
        }

        // static async Task RunAsync()
        // {
        //     using (var client = new HttpClient())
        //     {
        //         client.BaseAddress = new Uri("http://localhost:5000/");
        //         client.DefaultRequestHeaders.Accept.Clear();
        //         client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //          HttpResponseMessage response = await client.GetAsync("api/products/1");
        //         if (response.IsSuccessStatusCode)
        //         {
        //             Movie movie = await response.Content.ReadAsAsync>Movie>();
        //             Console.WriteLine("{0}\t${1}\t{2}", movie.Name, movie.Price, movie.Category);
        //         }
        //     }
        // }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


    }
}
