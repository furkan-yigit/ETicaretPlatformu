using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Kullanici adinizi giriniz")]
        [Display(Name = "Kullanici Adi")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Sifrenizi giriniz")]
        [Display(Name = "Sifre")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
