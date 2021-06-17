using DapperCv.Business.Concrete;
using DapperCv.Business.Interfaces;
using DapperCv.Business.ValidationRules;
using DapperCv.DataAccess.Concrete.Dapper;
using DapperCv.DataAccess.Interfaces;
using DapperCv.DTO.DTOs.AppUserDtos;
using DapperCv.DTO.DTOs.CertificationDtos;
using DapperCv.DTO.DTOs.EducationDtos;
using DapperCv.DTO.DTOs.ExperienceDtos;
using DapperCv.DTO.DTOs.InterestDtos;
using DapperCv.DTO.DTOs.SkillsDtos;
using DapperCv.DTO.DTOs.SocialMediaIconDtos;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.IOC.Microsoft
{
    public static class MicrosoftDependencyResolvers
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //DpGenericRepository kısmında IDbConnection nesnemiz DI ile verilecektir.Connection String ve hangi database türünün kullanılacağı burada belirtilmiştir.
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("connectionMssql")));

            //Hangi Entity için olacağından bağımsız olarak bu şekilde DI ile bağımlılığı çözebiliyoruz
            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));

            //Aynı yöntem bunun içinde geçerlidir.
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IUserDal, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<ISocialMediaDal, DpSocialMediaRepository>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();


            //Validasyon Çözümleri
            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateValidator>();
            services.AddTransient<IValidator<AppUserPasswordDto>, AppUserPasswordValidator>();

            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateValidator>();

            services.AddTransient<IValidator<EducationAddDto>, EducationAddValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateValidator>();

            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateValidator>();

            services.AddTransient<IValidator<InterestsAddDto>, InterestAddValidator>();
            services.AddTransient<IValidator<InterestsUpdateDto>, InterestUpdateValidator>();

            services.AddTransient<IValidator<SkillAddDto>, SkillAddValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateValidator>();

            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateValidator>();
        }
    }
}
