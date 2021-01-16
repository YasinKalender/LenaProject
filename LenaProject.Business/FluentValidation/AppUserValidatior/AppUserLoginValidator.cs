using FluentValidation;
using LenaProject.Dto.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.FluentValidation.AppUserValidatior
{
    public class AppUserLoginValidator:AbstractValidator<AppUserLoginDto>
    {

        public AppUserLoginValidator()
        {
            RuleFor(i => i.Username).NotNull().WithMessage("Kullanıcı alanı boş geçilemez");
            RuleFor(i => i.Password).NotNull().WithMessage("Şifre alanı boş geçilemez");
        }
    }
}
