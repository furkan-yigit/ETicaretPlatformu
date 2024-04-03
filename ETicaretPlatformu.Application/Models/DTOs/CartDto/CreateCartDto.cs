using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.Cart
{
    public class CreateCartDto
    {
        public string UserId { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
