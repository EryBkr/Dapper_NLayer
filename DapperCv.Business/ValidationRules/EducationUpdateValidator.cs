using DapperCv.DTO.DTOs.EducationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
   public class EducationUpdateValidator:AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş olamaz");
        }
    }
}
