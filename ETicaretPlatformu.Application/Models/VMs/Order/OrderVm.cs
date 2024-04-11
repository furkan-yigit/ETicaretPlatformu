using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.VMs.Order
{
    public class OrderVm
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<OrderDetailVm> OrderDetails { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserId { get; set; }
    }
}
