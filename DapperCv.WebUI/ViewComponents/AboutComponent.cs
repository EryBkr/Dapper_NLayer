using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.AppUserDtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.ViewComponents
{
    public class AboutComponent:ViewComponent
    {
        private readonly IAppUserService _userService;
        private readonly IMapper mapper;

        public AboutComponent(IAppUserService appUserService,IMapper mapper)
        {
            _userService = appUserService;
            this.mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userService.GetById(1);
            var model = mapper.Map<AppUserListDto>(user);
            return View(model);
        }
    }
}
