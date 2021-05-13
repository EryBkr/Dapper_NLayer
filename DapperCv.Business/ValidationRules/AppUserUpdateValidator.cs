using DapperCv.DTO.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class AppUserUpdateValidator:AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(1,int.MaxValue).WithMessage("Id boş olamaz");
        }
    }
}
