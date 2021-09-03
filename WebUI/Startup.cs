using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility;

namespace WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var vBaseUrl = Configuration["API:url"].ToString();
            var vSiteVersion = Configuration["siteVersion"].ToString();

            GlobalVars.APIUrl = vBaseUrl;
            GlobalVars.siteVersion = vSiteVersion;
            GlobalVars.cookieUserNameKey = Configuration["cookieUserNameKey"].ToString();
            GlobalVars.cookiePasswordKey = Configuration["cookiePasswordKey"].ToString();

            services.AddMvc();
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(7200);
                //options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = "Cosmic.Session";
            });

            services.AddCors(options =>
             options.AddPolicy("CorsPolicy",
                 builder =>
                 {
                     builder.WithOrigins();
                 }));
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "Cosmic",
                pattern: "{area:exists}/{controller=default}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
