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

        [Required(ErrorMessage = "Enter your username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Image File")]
        public string? ImagePath { get; set; }


        [PictureFileExtensionAttiribute]
        public IFormFile UploadPath { get; set; }
        public DateTime UpdateDate => DateTime.Now;
        public Status Status => Status.Modified;
        //public PaymentMethod PaymentMethod { get; set; }
    }
}
