using AutoMapper;
using DapperCv.Business.Concrete;
using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.SocialMediaIconDtos;
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
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialService;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialService, IMapper mapper, IAppUserService appUserService)
        {
            _mapper = mapper;
            _socialService = socialService;
            _appUserService = appUserService;
        }


        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var user = _appUserService.FindByName(userName);

            var icons = _socialService.GetByUserId(user.Id);
            var models = _mapper.Map<IEnumerable<SocialMediaIconListDto>>(icons);

            TempData["active"] = "social";

            return View(models);
        }

        public IActionResult Delete(int id)
        {
            var model = _socialService.GetById(id);
            _socialService.Delete(model);
            TempData["message"] = "Ikon Başarıyla Silindi";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Add()
        {
            TempData["active"] = "social";
            return View(new SocialMediaIconAddDto());
        }


        [HttpPost]
        public IActionResult Add(SocialMediaIconAddDto model)
        {
            TempData["active"] = "social";

            if (ModelState.IsValid)
            {
                var userName = User.Identity.Name;
                var user = _appUserService.FindByName(userName);

                var entity = _mapper.Map<SocialMediaIcon>(model);
                entity.AppUserId = user.Id;

                _socialService.Insert(entity);

                TempData["message"] = "İkon Başarıyla Kaydedildi";
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            TempData["active"] = "social";
            var model = _mapper.Map<SocialMediaIconUpdateDto>(_socialService.GetById(id));
            
            return View(model);
        }


        [HttpPost]
        public IActionResult Update(SocialMediaIconUpdateDto model)
        {
            TempData["active"] = "social";

            if (ModelState.IsValid)
            {
                var userName = User.Identity.Name;
                var user = _appUserService.FindByName(userName);

                var entity = _mapper.Map<SocialMediaIcon>(model);
                entity.AppUserId = user.Id;

                _socialService.Update(entity);

                TempData["message"] = "İkon Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
