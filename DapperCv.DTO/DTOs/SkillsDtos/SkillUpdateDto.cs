using DapperCv.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DTO.DTOs.SkillsDtos
{
    public class SkillUpdateDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
