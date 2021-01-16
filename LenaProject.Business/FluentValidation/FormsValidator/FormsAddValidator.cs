using FluentValidation;
using LenaProject.Dto.FormsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.FluentValidation.FormsValidator
{
    public class FormsAddValidator:AbstractValidator<FormsAddDto>
    {

        public FormsAddValidator()
        {
            RuleFor(i => i.FormName).NotNull().WithMessage("Form alanı zorunlu alandır");
        }
    }
}
