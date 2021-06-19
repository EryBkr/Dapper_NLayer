using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.InterestDtos;
using DapperCv.DTO.DTOs.SkillsDtos;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DapperCv.WebUI.ViewComponents
{
    public class InterestComponent:ViewComponent
    {
        private readonly IGenericService<Interest> _interestService;
        private readonly IMapper _mapper;

        public InterestComponent(IGenericService<Interest> genericService,IMapper mapper)
        {
            _interestService = genericService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestsListDto>>(_interestService.GetAll()));
        }
    }
}
