using DapperCv.DTO.DTOs.AppUserDtos;
using DapperCv.DTO.DTOs.ColorDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Models
{
    public class NavbarComponentViewModel
    {
        public AppUserListDto AppUserListDto { get; set; }
        public ColorThemeUpdateDto ColorThemeUpdateDto { get; set; }
    }
}
