using DapperCv.DTO.DTOs.EducationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class EducationAddValidator:AbstractValidator<EducationAddDto>
    {
        public EducationAddValidator()
        {
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama Boş Olamaz");
            RuleFor(i => i.StartDate).NotEmpty().WithMessage("Giriş Tarihi Boş Olamaz");
            RuleFor(i => i.Title).NotEmpty().WithMessage("Başlık Boş Olamaz");
            RuleFor(i => i.SubTitle).NotEmpty().WithMessage("Alt Başlık Boş Olamaz");
        }
    }
}
