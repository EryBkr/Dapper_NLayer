using DapperCv.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class SocialMediaIconAddValidator:AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddValidator()
        {
            RuleFor(i => i.Icon).NotEmpty().WithMessage("Icon Boş Olamaz");
            RuleFor(i => i.Link).NotEmpty().WithMessage("Link Boş Olamaz");
        }
    }
}
