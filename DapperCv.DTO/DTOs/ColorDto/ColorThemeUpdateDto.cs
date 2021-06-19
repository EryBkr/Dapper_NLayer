using DapperCv.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DTO.DTOs.ColorDto
{
    public class ColorThemeUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Color { get; set; }
    }
}
