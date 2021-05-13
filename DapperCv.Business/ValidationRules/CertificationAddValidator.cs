using DapperCv.DTO.DTOs.CertificationDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class CertificationAddValidator:AbstractValidator<CertificationAddDto>
    {
        public CertificationAddValidator()
        {
            RuleFor(i => i.Description).NotEmpty().WithMessage("Açıklama Boş olamaz");
        }
    }
}
