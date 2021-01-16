using FluentValidation;
using LenaProject.Dto.FormsDetailsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.FluentValidation.FormsDetailsValidator
{
    public class FormsDetailsAddValidaton:AbstractValidator<FormsDetailAddDto>
    {

        public FormsDetailsAddValidaton()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("Bu alan zorunludur");
            RuleFor(i => i.Description).NotNull().WithMessage("Bu alan zorunludur");
        }
    }
}
