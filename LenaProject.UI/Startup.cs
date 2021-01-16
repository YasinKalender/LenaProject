using AutoMapper;
using FluentValidation.AspNetCore;
using LenaProject.Business.DependencyService;
using LenaProject.Entites.ORM.Entities.Concrete;
using LenaProject.UI.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews().AddFluentValidation();
            services.ConfigureServices();
            services.IdentityOption();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            IdentitySeed.IdentityAdd(userManager, roleManager).Wait();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {

            

                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{Area}/{Controller=Home}/{Action=Index}/{id?}"

                   );
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{Controller=Home}/{Action=Index}/{id?}"

                    );
            });
        }
    }
}
