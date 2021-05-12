using DapperCv.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Certifications")]
    public class Certification : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
