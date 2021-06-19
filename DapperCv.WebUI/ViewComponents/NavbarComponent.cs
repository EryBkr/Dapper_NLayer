using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.AppUserDtos;
using DapperCv.DTO.DTOs.ColorDto;
using DapperCv.Entities.Concrete;
using DapperCv.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.ViewComponents
{
    public class NavbarComponent:ViewComponent
    {

        private readonly IAppUserService _userService;
        private readonly IGenericService<ColorTheme> _colorService;
        private readonly IMapper mapper;

        public NavbarComponent(IAppUserService appUserService, IMapper mapper, IGenericService<ColorTheme> colorService)
        {
            _userService = appUserService;
            this.mapper = mapper;
            _colorService = colorService;
        }

        public IViewComponentResult Invoke()
        {
            var viewModel = new NavbarComponentViewModel();
            viewModel.AppUserListDto = mapper.Map<AppUserListDto>(_userService.GetById(1));

            var color = _colorService.GetAll()?.FirstOrDefault();

            if (color == null)
            {
                color = new ColorTheme() { Color = "#BD5D38" };
                _colorService.Insert(color);
            }
            viewModel.ColorThemeUpdateDto= mapper.Map<ColorThemeUpdateDto>(color);
            return View(viewModel);
        }
    }
}
