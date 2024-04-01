using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Kullanici adi girisi zorunludur")]
        [Display(Name = "Kullanici Adi")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Sifre girisi zorunludur")]
        [Display(Name = "Kullanici Sifresi")]
        [DataType(DataType.Password, ErrorMessage = "Sifreniz gerekli kriterleri karsilamiyor")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrari girisi zorunludur")]
        [Display(Name = "Kullanici Sifresi Tekrar")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Sifreler birbirine esit olmalidir")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "email adresi girilmesi zorunludur")]
        [Display(Name = "E-Posta")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-Posta bilgilerinizi kontrol edin, gecerli bir e-posta adresi girin")]
        public string Email { get; set; }


        public DateTime CreateDate => DateTime.Now;
        public Status Status { get; set; }

    }
}
