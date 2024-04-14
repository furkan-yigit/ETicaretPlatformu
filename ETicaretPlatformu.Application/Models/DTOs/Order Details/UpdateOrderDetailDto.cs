using ETicaretPlatformu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.Order_Details
{
    public class UpdateOrderDetailDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        [Required (ErrorMessage = "Product is required!")]
        public int ProductId { get; set; }
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
