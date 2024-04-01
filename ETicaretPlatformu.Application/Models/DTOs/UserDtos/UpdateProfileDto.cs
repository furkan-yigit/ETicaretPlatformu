using ETicaretPlatformu.Application.Extensions;
using ETicaretPlatformu.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.UserDtos
{
    public class UpdateProfileDto
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Kullanici adinizi giriniz")]
        [Display(Name = "Kullanici Adi")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Sifrenizi giriniz")]
        [Display(Name = "Sifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrari girisi zorunludur")]
        [Display(Name = "Kullanici Sifresi Tekrar")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Sifreler birbirine esit olmalidir")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "email adresi girilmesi zorunludur")]
        [Display(Name = "E-Posta")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Resim Dosyasi")]
        public string? ImagePath { get; set; }


        [PictureFileExtensionAttiribute]
        public IFormFile UploadPath { get; set; }
        public DateTime UpdateDate => DateTime.Now;
        public Status Status => Status.Modified;
        public PaymentMethod PaymentMethod { get; set; }
    }
}
