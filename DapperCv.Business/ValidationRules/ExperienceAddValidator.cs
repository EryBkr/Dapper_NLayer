using DapperCv.DTO.DTOs.ExperienceDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class ExperienceAddValidator:AbstractValidator<ExperienceAddDto>
    {
        public ExperienceAddValidator()
        {
            RuleFor(i => i.Title).NotEmpty().WithMessage("Başlık Boş Olamaz");
            RuleFor(i => i.SubTitle).NotEmpty().WithMessage("Alt Başlık Boş Olamaz");
            RuleFor(i => i.StartDate).NotEmpty().WithMessage("Başlıngıç Tarihi Boş Olamaz");
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama Boş Olamaz");
        }
    }
}
