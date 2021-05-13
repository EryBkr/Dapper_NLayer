using DapperCv.DTO.DTOs.SkillsDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class SkillUpdateValidator:AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş olamaz");
        }
    }
}
