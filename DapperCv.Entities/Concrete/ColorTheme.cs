using DapperCv.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("ColorTheme")]
    public class ColorTheme:IEntity
    {
        [Dapper.Contrib.Extensions.Key]
        public int Id { get; set; }
        public string Color { get; set; }
    }
}
