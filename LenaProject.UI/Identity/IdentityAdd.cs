using LenaProject.DAL.Context;
using LenaProject.Entites.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI.Identity
{
    public static class IdentityAdd
    {
        public static void IdentityOption(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>().AddErrorDescriber<PasswordValidator>().AddEntityFrameworkStores<ProjectContext>();

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;


            });

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "Yasin";
                opt.LoginPath = "/Home/Login";
                opt.Cookie.HttpOnly = true;
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(1);



            });



        }

    }
}
