using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Extensions
{
    public class PictureFileExtensionAttiribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            IFormFile file = value as IFormFile;

            var extension = Path.GetExtension(file.FileName).ToLower();

            string[] extensions = { "jpg", "jpeg", "png" };

            bool result = extensions.Any(x => extension.EndsWith(x));

            if (!result)
            {
                return new ValidationResult("gecerli bir dosya yukleyin. jpg,jpeg veya png");
            }

            return ValidationResult.Success;
        }
    }
}
