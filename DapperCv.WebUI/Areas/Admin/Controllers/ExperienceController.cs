using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.ExperienceDtos;
using DapperCv.DTO.DTOs.InterestDtos;
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
    public class ExperienceController : Controller
    {

        private readonly IGenericService<Experience> _exService;
        private readonly IMapper _mapper;

        public ExperienceController(IGenericService<Experience> exService, IMapper mapper)
        {
            _exService = exService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "experience";
            return View(_mapper.Map<List<ExperienceListDto>>(_exService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "experience";

            var model = _exService.GetById(id);
            _exService.Delete(model);

            TempData["message"] = "Tecrübe Bilgisi Başarıyla Silindi";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            TempData["active"] = "experience";
            return View(new ExperienceAddDto());
        }

        [HttpPost]
        public IActionResult Add(ExperienceAddDto model)
        {
            TempData["active"] = "experience";
            if (ModelState.IsValid)
            {
                _exService.Insert(_mapper.Map<Experience>(model));
                TempData["message"] = "Tecrübe Bilgisi Başarıyla Eklendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            TempData["active"] = "experience";
            var model = _mapper.Map<ExperienceUpdateDto>(_exService.GetById(id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ExperienceUpdateDto model)
        {
            TempData["active"] = "education";
            if (ModelState.IsValid)
            {
                _exService.Update(_mapper.Map<Experience>(model));
                TempData["message"] = "Tecrübe Bilgisi Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
