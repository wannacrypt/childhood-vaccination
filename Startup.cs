using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Playground.Data;
using Playground.Services;

namespace Playground
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
            services.AddSession(); 
            services.AddSingleton<IGreetingService, Greeter>();
            services.AddDbContext<ChildVaccDbContext>
                    (options => options.UseNpgsql(_configuration.GetConnectionString("PostgreSqlConnection")));
            services.AddScoped<IChildService, SqlChildData>();
            services.AddScoped<IAdminService, SqlAdminData>();
            services.AddScoped<IDoctorService, SqlDoctorData>();
            services.AddScoped<INurseService, SqlNurseData>();
            services.AddScoped<IPrescriptionService, SqlPrescriptionData>();
            services.AddScoped<IScheduleService, SqlScheduleData>();
            services.AddScoped<ITicketService, SqlTicketData>();
            services.AddScoped<IVaccineListService, SqlVaccineListData>();
            services.AddMvc();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreetingService greeting)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(greeting.GetErrorMessage());
            });

        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Authorization}/{action=Login}/{id?}");
        }
    }
}
