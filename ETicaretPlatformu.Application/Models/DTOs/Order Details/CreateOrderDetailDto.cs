
using ETicaretPlatformu.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ETicaretPlatformu.Application.Models.DTOs.Order_Details
{
    public class CreateOrderDetailDto
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }

        [Range(1,int.MaxValue)]
        public int Quantity { get; set; }
    }
}
