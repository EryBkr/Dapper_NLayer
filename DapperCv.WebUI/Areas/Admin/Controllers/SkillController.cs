using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.SkillsDtos;
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
    public class SkillController : Controller
    {

        private readonly IGenericService<Skill> _skillService;
        private readonly IMapper _mapper;

        public SkillController(IGenericService<Skill> skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }

     

        public IActionResult Index()
        {
            TempData["active"] = "skill";
            return View(_mapper.Map<List<SkillListDto>>(_skillService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var model = _skillService.GetById(id);
            _skillService.Delete(model);
            TempData["message"] = "Yetenek Başarıyla Silindi";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            TempData["active"] = "skill";
            return View(new SkillAddDto());
        }

        [HttpPost]
        public IActionResult Add(SkillAddDto model)
        {
            TempData["active"] = "skill";

            if (ModelState.IsValid)
            {
                var skill = _mapper.Map<Skill>(model);
                _skillService.Insert(skill);
                TempData["message"] = "Yetenek Başarıyla Kaydedildi";
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            TempData["active"] = "skill";
            var skill = _skillService.GetById(id);
            var model = _mapper.Map<SkillUpdateDto>(skill);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(SkillUpdateDto model)
        {
            TempData["active"] = "skill";

            if (ModelState.IsValid)
            {
                var skill = _mapper.Map<Skill>(model);
                _skillService.Update(skill);
                TempData["message"] = "Yetenek Başarıyla Düzenlendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
