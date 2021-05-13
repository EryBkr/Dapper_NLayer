using DapperCv.DTO.DTOs.CertificationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class CertificationUpdateValidator:AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateValidator()
        {
            RuleFor(i => i.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id Boş Olamaz");
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama Boş olamaz");
        }
    }
}
