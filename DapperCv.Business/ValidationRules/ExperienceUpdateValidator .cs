using DapperCv.DTO.DTOs.ExperienceDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class ExperienceUpdateValidator:AbstractValidator<ExperienceUpdateDto>
    {
        public ExperienceUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş olamaz");
        }
    }
}
