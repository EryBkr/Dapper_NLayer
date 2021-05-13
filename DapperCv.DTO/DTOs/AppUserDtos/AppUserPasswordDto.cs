using DapperCv.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DTO.DTOs.AppUserDtos
{
    public class AppUserPasswordDto:IDto
    {
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
