using DapperCv.DTO.DTOs.ColorDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class ColorThemeValidator:AbstractValidator<ColorThemeUpdateDto>
    {
        public ColorThemeValidator()
        {
            RuleFor(i => i.Id).NotNull().WithMessage("Id Alanı Boş Olamaz");
            RuleFor(i => i.Color).NotEmpty().WithMessage("Lütfen Renk Seçiniz");
        }
    }
}
