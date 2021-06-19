using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.ExperienceDtos;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.ViewComponents
{
    public class ExperienceComponent:ViewComponent
    {
        private readonly IGenericService<Experience> _exService;
        private readonly IMapper _mapper;

        public ExperienceComponent(IGenericService<Experience> genericService,IMapper mapper)
        {
            _exService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDto>>(_exService.GetAll()));
        }
    }
}
