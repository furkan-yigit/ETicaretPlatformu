using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.OrderDto
{
    public class CreateOrderDto
    {
     
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
