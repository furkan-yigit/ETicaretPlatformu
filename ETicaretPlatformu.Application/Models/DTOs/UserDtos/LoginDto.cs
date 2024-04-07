using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.UserDtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Enter your username")]
        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
