using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.EducationDtos;
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
    public class EducationController : Controller
    {
        private readonly IGenericService<Educations> _eduService;
        private readonly IMapper _mapper;

        public EducationController(IGenericService<Educations> eduService,IMapper mapper)
        {
            _eduService = eduService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "education";
            return View(_mapper.Map<List<EducationListDto>>(_eduService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "education";

            var model = _eduService.GetById(id);
            _eduService.Delete(model);

            TempData["message"] = "Eğitim Bilgisi Başarıyla Silindi";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            TempData["active"] = "education";
            return View(new EducationAddDto());
        }

        [HttpPost]
        public IActionResult Add(EducationAddDto model)
        {
            TempData["active"] = "education";
            if (ModelState.IsValid)
            {
                _eduService.Insert(_mapper.Map<Educations>(model));
                TempData["message"] = "Eğitim Bilgisi Başarıyla Eklendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }



        [HttpGet]
        public IActionResult Update(int id)
        {
            TempData["active"] = "education";
            var model = _mapper.Map<EducationUpdateDto>(_eduService.GetById(id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(EducationUpdateDto model)
        {
            TempData["active"] = "education";
            if (ModelState.IsValid)
            {
                _eduService.Update(_mapper.Map<Educations>(model));
                TempData["message"] = "Eğitim Bilgisi Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
