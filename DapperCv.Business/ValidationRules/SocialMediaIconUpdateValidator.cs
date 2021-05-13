using DapperCv.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class SocialMediaIconUpdateValidator:AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş Olamaz");
            RuleFor(i => i.AppUserId).InclusiveBetween(1, int.MaxValue).WithMessage("Kullanıcı Boş Olamaz");
        }
    }
}
