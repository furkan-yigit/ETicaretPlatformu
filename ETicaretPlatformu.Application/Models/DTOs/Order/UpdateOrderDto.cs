using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.OrderDto
{
    public class UpdateOrderDto
    {
        public int Id { get; set; }

        public User User { get; set; }
        [Required(ErrorMessage ="User is required!")]
        public string UserId { get; set; }
        [Required]
        public OrderStatus OrderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
