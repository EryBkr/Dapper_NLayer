using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.CertificationDtos;
using DapperCv.DTO.DTOs.InterestDtos;
using DapperCv.DTO.DTOs.SkillsDtos;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DapperCv.WebUI.ViewComponents
{
    public class CertificationComponent : ViewComponent
    {
        private readonly IGenericService<Certification> _certificationService;
        private readonly IMapper _mapper;

        public CertificationComponent(IGenericService<Certification> genericService,IMapper mapper)
        {
            _certificationService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_certificationService.GetAll()));
        }
    }
}
