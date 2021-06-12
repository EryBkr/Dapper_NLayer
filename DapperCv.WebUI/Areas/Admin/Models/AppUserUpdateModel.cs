using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI.Areas.Admin.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "FirstName Gereklidir")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName Gereklidir")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address Gereklidir")]
        public string Address { get; set; }

        public string Email { get; set; }

        public string ImageUrl { get; set; }
        public IFormFile Picture { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortDescription { get; set; }
    }
}
