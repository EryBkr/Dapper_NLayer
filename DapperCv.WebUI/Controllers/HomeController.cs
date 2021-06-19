using DapperCv.Business.Interfaces;
using DapperCv.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //Uygulamamız tek sayfa üzerinden oluştuğu için her bir kısım ViewComponent aracılığıyla oluşturulmuştur
        public IActionResult Index()
        {
            return View();
        }
    }
}
