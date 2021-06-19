using AutoMapper;
using DapperCv.DTO.DTOs.AppUserDtos;
using DapperCv.DTO.DTOs.CertificationDtos;
using DapperCv.DTO.DTOs.ColorDto;
using DapperCv.DTO.DTOs.EducationDtos;
using DapperCv.DTO.DTOs.ExperienceDtos;
using DapperCv.DTO.DTOs.InterestDtos;
using DapperCv.DTO.DTOs.SkillsDtos;
using DapperCv.DTO.DTOs.SocialMediaIconDtos;
using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Mapping
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>();
            CreateMap<AppUserListDto, AppUser>();

            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();

            CreateMap<Certification, CertificationAddDto>();
            CreateMap<CertificationAddDto, Certification>();

            CreateMap<Certification, CertificationUpdateDto>();
            CreateMap<CertificationUpdateDto, Certification>();

            CreateMap<Educations, EducationListDto>();
            CreateMap<EducationListDto, Educations>();

            CreateMap<Educations, EducationAddDto>();
            CreateMap<EducationAddDto, Educations>();

            CreateMap<Educations, EducationUpdateDto>();
            CreateMap<EducationUpdateDto, Educations>();

            CreateMap<Experience, ExperienceListDto>();
            CreateMap<ExperienceListDto, Experience>();

            CreateMap<Experience, ExperienceAddDto>();
            CreateMap<ExperienceAddDto, Experience>();

            CreateMap<Experience, ExperienceUpdateDto>();
            CreateMap<ExperienceUpdateDto, Experience>();

            CreateMap<Interest, InterestsListDto>();
            CreateMap<InterestsListDto, Interest>();

            CreateMap<Interest, InterestsAddDto>();
            CreateMap<InterestsAddDto, Interest>();

            CreateMap<Interest, InterestsUpdateDto>();
            CreateMap<InterestsUpdateDto, Interest>();

            CreateMap<Skill, SkillListDto>();
            CreateMap<SkillListDto, Skill>();

            CreateMap<Skill, SkillAddDto>();
            CreateMap<SkillAddDto, Skill>();

            CreateMap<Skill, SkillUpdateDto>();
            CreateMap<SkillUpdateDto, Skill>();


            CreateMap<SocialMediaIcon, SocialMediaIconListDto>();
            CreateMap<SocialMediaIconListDto, SocialMediaIcon>();

            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>();
            CreateMap<SocialMediaIconAddDto, SocialMediaIcon>();

            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>();
            CreateMap<SocialMediaIconUpdateDto, SocialMediaIcon>();

            CreateMap<ColorThemeUpdateDto, ColorTheme>();
            CreateMap<ColorTheme, ColorThemeUpdateDto > ();
        }
    }
}
