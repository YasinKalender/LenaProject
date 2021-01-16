using FluentValidation;
using LenaProject.Business.Abstract;
using LenaProject.Business.Concrete;
using LenaProject.Business.FluentValidation.AppUserValidatior;
using LenaProject.Business.FluentValidation.FormsDetailsValidator;
using LenaProject.DAL.Context;
using LenaProject.DAL.Repository.Abstract;
using LenaProject.DAL.Repository.Concrete;
using LenaProject.DAL.UnitOFWorks;
using LenaProject.Dto.AppUserDtos;
using LenaProject.Dto.FormsDetailsDto;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.DependencyService
{
    public static class ServiceConfigure
    {

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddDbContext<ProjectContext>();

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseManager<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFormsRepository, FormsRepository>();
            services.AddScoped<IFormService, FormManager>();


            services.AddTransient<IValidator<AppUserRegisterDto>, AppUserRegisterValidatior>();
            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginValidator>();
            services.AddTransient<IValidator<FormsDetailAddDto>, FormsDetailsAddValidaton>();




        }
    }
}
