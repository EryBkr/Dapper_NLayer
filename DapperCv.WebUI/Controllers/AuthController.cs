using DapperCv.Business.Interfaces;
using DapperCv.WebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAppUserService _userService;

        public AuthController(IAppUserService appUserService)
        {
            _userService = appUserService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new UserLoginModel());
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (_userService.CheckUser(model.UserName,model.Password))
                {
                    //Giriş başarılı oldu.Kullanıcı bilgilerini Claims lere veriyoruz
                    var claims = new List<Claim> 
                    {
                        new Claim(ClaimTypes.Name,model.UserName),
                        new Claim(ClaimTypes.Role,"Developer") //Role bilgisi DB den de çekilebilirdi
                    };

                    //Claimsleri ve Auth türünü oluşturup ClaimsIdentity e tanımladık
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    //Auth özelliklerini belirliyoruz
                    var authProperties = new AuthenticationProperties 
                    { 
                        IsPersistent=model.RememberMe //Kullanıcı beni hatırla derse cookie ayarlarında ki süre kadar cookie saklanacaktır
                    };

                    //Claims bilgileri,cookie şema bilgileri ve auth özelliklerinin belirlendiği bir login işlemi yapıldı
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);


                    return RedirectToAction("Index", "Home", new { @area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("","Kullanıcı Adı veya Parola Hatalı");
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("Login");
        }
    }
}
