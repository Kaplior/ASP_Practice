using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using WebApplication3.Services;

namespace WebApplication3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<TimeService>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TimeService timeService)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync(timeService?.GetTime());
            });
        }
    }
}
