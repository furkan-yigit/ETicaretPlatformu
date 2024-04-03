using ETicaretPlatformu.Domain.Entities;
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

      public ICollection<OrderDetailVm> OrderDetails { get; set; }
        public string UserId { get; set; }
    }
}
