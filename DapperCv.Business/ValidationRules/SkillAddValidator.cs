using DapperCv.DTO.DTOs.SkillsDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class SkillAddValidator:AbstractValidator<SkillAddDto>
    {
        public SkillAddValidator()
        {
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama boş olamaz");
        }
    }
}
