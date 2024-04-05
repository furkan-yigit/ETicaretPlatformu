using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.UserDtos
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "Your password does not meet the required criteria")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please check your email address and enter a valid one")]
        public string Email { get; set; }

        public DateTime CreateDate => DateTime.Now;
        public Status Status => Status.Active;

    }
}
