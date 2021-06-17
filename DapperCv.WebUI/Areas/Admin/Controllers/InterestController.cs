using AutoMapper;
using DapperCv.Business.Interfaces;
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
    public class InterestController : Controller
    {

        private readonly IGenericService<Interest> _interestService;
        private readonly IMapper _mapper;

        public InterestController(IGenericService<Interest> interestService, IMapper mapper)
        {
            _interestService = interestService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "interest";
            return View(_mapper.Map<List<InterestsListDto>>(_interestService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var model = _interestService.GetById(id);
            _interestService.Delete(model);
            TempData["message"] = "İlgi Alanı Başarıyla Silindi";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            TempData["active"] = "interest";
            return View(new InterestsAddDto());
        }

        [HttpPost]
        public IActionResult Add(InterestsAddDto model)
        {
            TempData["active"] = "interest";

            if (ModelState.IsValid)
            {
                var interest = _mapper.Map<Interest>(model);
                _interestService.Insert(interest);
                TempData["message"] = "İlgi Alanı Başarıyla Kaydedildi";
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            TempData["active"] = "interest";
            var interest = _interestService.GetById(id);
            var model = _mapper.Map<InterestsUpdateDto>(interest);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(InterestsUpdateDto model)
        {
            TempData["active"] = "interest";

            if (ModelState.IsValid)
            {
                var interest = _mapper.Map<Interest>(model);
                _interestService.Update(interest);
                TempData["message"] = "İlgi Alanı Başarıyla Düzenlendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
