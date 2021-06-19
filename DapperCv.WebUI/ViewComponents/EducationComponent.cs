using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.EducationDtos;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.ViewComponents
{
    public class EducationComponent:ViewComponent
    {

        private readonly IGenericService<Educations> _eduService;
        private readonly IMapper _mapper;

        public EducationComponent(IGenericService<Educations> genericService, IMapper mapper)
        {
            _eduService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_eduService.GetAll()));
        }
    }
}
