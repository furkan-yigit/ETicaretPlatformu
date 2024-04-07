
using ETicaretPlatformu.Domain.Entities;

namespace ETicaretPlatformu.Application.Models.DTOs.Order_Details
{
    public class CreateOrderDetailDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
