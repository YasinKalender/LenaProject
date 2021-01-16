using FluentValidation;
using LenaProject.Dto.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.FluentValidation.AppUserValidatior
{
    public class AppUserRegisterValidatior:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidatior()
        {
            RuleFor(i => i.FirstName).NotNull().WithMessage("İsim alanı boş geçilemez");
        }

    }
}
