﻿using DapperCv.Business.Interfaces;
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
        private readonly IGenericService<Skill> _skillService;

        public HomeController(IGenericService<Skill> skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            return View(_skillService.GetAll());
        }
    }
}
