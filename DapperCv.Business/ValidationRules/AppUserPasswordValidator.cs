using DapperCv.DTO.DTOs.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.ValidationRules
{
    public class AppUserPasswordValidator:AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordValidator()
        {
            RuleFor(i => i.Password).NotEmpty().WithMessage("Parola alanı boş olamaz");
            RuleFor(i => i.ConfirmPassword).NotEmpty().WithMessage("Parola onay alanı boş olamaz");
            RuleFor(i => i.ConfirmPassword).Equal(i=>i.Password).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
