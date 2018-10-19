﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using ChildhoodVaccination.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ChildhoodVaccination.Data;

namespace ChildhoodVaccination
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreater, GreatingService>();
            services.AddDbContext<ChildhoodVaccinationDbContext>(
                options => options.UseNpgsql(_configuration.GetConnectionString("PostgreSqlConnection")));
            services.AddScoped<IChildData, PostgreSqlChildData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } 

            app.UseStaticFiles();

            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Async Write");
            });            
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // Using MapRoute I can define one or more routes
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
