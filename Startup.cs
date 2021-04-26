using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using MovieApp.Models;

namespace MovieApp
{
    public class Startup
    {
        private string _movieApiKey = null;
        private string _emailPw = null;
        // public Startup(IHostEnvironment env)
        // {
        //     var builder = new ConfigurationBuilder()
        //         .SetBasePath(env.ContentRootPath)
        //         .AddJsonFile("appsettings.json",
        //                     optional: false,
        //                     reloadOnChange: true)
        //         .AddEnvironmentVariables();


        //     if (env.IsDevelopment())
        //     {
        //         builder.AddUserSecrets<Startup>();
        //     }

        //     Configuration = builder.Build();
        // }
        // public IConfigurationRoot Configuration { get; }
        public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddControllersWithViews();
            // services.Configure<AppOptions>(options => Configuration.Bind(options));

            _movieApiKey = Configuration["TMDBApiKey"];
            _emailPw = Configuration["EmailPW"];
                        
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSession();
            services.AddDbContext<MyContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSession();
            // app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");
            });
            
            // app.Run(async (context) =>
            // {
            //     var result = string.IsNullOrEmpty(_movieApiKey) ? "Null" : "Not Null";
            //     // var result2 = string.IsNullOrEmpty(_emailPw) ? "Null" : "Not Null";
            //     await context.Response.WriteAsync($"Secret is {result}");
            //     return;
            // });
        }
    }
}
