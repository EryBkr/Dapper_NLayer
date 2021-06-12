using DapperCv.Business.Interfaces;
using DapperCv.DTO.DTOs.AppUserDtos;
using DapperCv.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Developer")] //Giriş yapılmış olması ve Rolünün Developer olması gerekiyor
    public class HomeController : Controller
    {
        private IAppUserService _userService;

        public HomeController(IAppUserService appUserService)
        {
            _userService = appUserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            TempData["active"] = "bilgilerim";

            //User Name bilgisini Cookie den aldık
            var userName = User.Identity.Name;

            //Kullanıcıyı username üzerinden aldık
            var user = _userService.FindByName(userName);

            var appUserDto = new AppUserUpdateModel
            {
                Email = user.Email,
                Address = user.Address,
                FirstName = user.FirstName,
                Id = user.Id,
                ImageUrl = user.ImageUrl,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
                UserName = user.UserName
            };

            return View(appUserDto);
        }

        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            TempData["active"] = "bilgilerim";

            if (ModelState.IsValid)
            {
                var updatedUser = _userService.GetById(model.Id);

                if (model.Picture!=null)
                {
                    var imgName= Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);

                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;

                    var stream = new FileStream(path, FileMode.Create);

                    model.Picture.CopyTo(stream);

                    updatedUser.ImageUrl = imgName;

                }

                updatedUser.Email = model.Email;
                updatedUser.LastName = model.LastName;
                updatedUser.FirstName = model.FirstName;
                updatedUser.PhoneNumber = model.PhoneNumber;
                updatedUser.ShortDescription = model.ShortDescription;
                updatedUser.Address = model.Address;

                _userService.Update(updatedUser);

                //Güncelleme işlemi başarılı ise feedback için tempdata oluşturuyorum
                TempData["message"] = "Güncelleme işleminiz başarılı";

                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult ChangePassword()
        {
            TempData["active"] = "changePassword";

            var user = _userService.FindByName(User.Identity.Name);

            return View(new AppUserPasswordDto {Id=user.Id});
        }

        [HttpPost]
        public IActionResult ChangePassword(AppUserPasswordDto model)
        {
            TempData["active"] = "changePassword";

            if (ModelState.IsValid)
            {
                var user = _userService.FindByName(User.Identity.Name);
                user.Password = model.Password;
                _userService.Update(user);

                //Kullanıcı eski cookie ile işlem yapamasın diye çıkış yaptırıyoruz
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                TempData["message"] = "Parola başarıyla değiştirildi";



                return RedirectToAction("Login","Auth",new {@area=""});
            }

            TempData["message"] = "Parolanız değiştirilemedi";
            return View();
        }
    }
}
