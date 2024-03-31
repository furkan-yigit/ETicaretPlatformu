using ETicaretPlatformu.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Status Status { get; set; }

        public ICollection<Order> Orders { get; set; }



        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile? UploadPath { get; set; }
    }
}
