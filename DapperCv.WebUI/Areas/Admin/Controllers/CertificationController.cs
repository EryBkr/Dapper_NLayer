using AutoMapper;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.CertificationDtos;
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
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> _certificationService;
        private readonly IMapper _mapper;

        public CertificationController(IGenericService<Certification> certificationService, IMapper mapper)
        {
            _certificationService = certificationService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "certification";
            return View(_mapper.Map<List<CertificationListDto>>(_certificationService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var model = _certificationService.GetById(id);
            _certificationService.Delete(model);
            TempData["message"] = "Sertifika Başarıyla Silindi";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            TempData["active"] = "certification";
            return View(new CertificationAddDto());
        }

        [HttpPost]
        public IActionResult Add(CertificationAddDto model)
        {
            TempData["active"] = "certification";

            if (ModelState.IsValid)
            {
                var certification = _mapper.Map<Certification>(model);
                _certificationService.Insert(certification);
                TempData["message"] = "Sertifika Başarıyla Kaydedildi";
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            TempData["active"] = "certification";
            var certification = _certificationService.GetById(id);
            var model = _mapper.Map<CertificationUpdateDto>(certification);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(CertificationUpdateDto model)
        {
            TempData["active"] = "certification";

            if (ModelState.IsValid)
            {
                var certification= _mapper.Map<Certification>(model);
                _certificationService.Update(certification);
                TempData["message"] = "Sertifika Başarıyla Düzenlendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }

}
