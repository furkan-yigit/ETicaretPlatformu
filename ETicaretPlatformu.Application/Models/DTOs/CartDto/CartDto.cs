using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.Cart
{
    public class CartDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<ProductDto> Products { get; set; }
        //public DateTime CreateDate { get; set; }
        //public DateTime? UpdateDate { get; set; }
        //public Status Status { get; set; }
    }
}
