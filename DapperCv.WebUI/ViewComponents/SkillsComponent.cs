using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.SkillsDtos;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DapperCv.WebUI.ViewComponents
{
    public class SkillsComponent:ViewComponent
    {
        private readonly IGenericService<Skill> _skillService;
        private readonly IMapper _mapper;

        public SkillsComponent(IGenericService<Skill> genericService,IMapper mapper)
        {
            _skillService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_skillService.GetAll()));
        }
    }
}
