using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.Cart
{
    public class UpdateCartDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}
