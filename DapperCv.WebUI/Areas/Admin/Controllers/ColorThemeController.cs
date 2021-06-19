using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.ColorDto;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Developer")]
    public class ColorThemeController : Controller
    {

        private readonly IGenericService<ColorTheme> _colorService;
        private readonly IMapper _mapper;

        public ColorThemeController(IGenericService<ColorTheme> certificationService, IMapper mapper)
        {
            _colorService = certificationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Update()
        {
            TempData["active"] = "color";
            var selectedColor = _colorService.GetAll().FirstOrDefault();
            var model = _mapper.Map<ColorThemeUpdateDto>(selectedColor);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ColorThemeUpdateDto model)
        {
            var selectedColor = _mapper.Map<ColorTheme>(model);
            _colorService.Update(selectedColor);
            TempData["message"] = "Renk Başarıyla değiştirildi";
            return RedirectToAction("Update");
        }

        [HttpPost]
        public IActionResult Default()
        {
            var selectedColor = _colorService.GetAll().FirstOrDefault();
            selectedColor.Color = "#BD5D38";
            _colorService.Update(selectedColor);
            TempData["message"] = "Renk Başarıyla Default Değere Atandı";
            return RedirectToAction("Update");
        }
    }
}
