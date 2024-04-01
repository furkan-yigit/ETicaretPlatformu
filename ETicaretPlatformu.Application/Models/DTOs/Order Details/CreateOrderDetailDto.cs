
using ETicaretPlatformu.Domain.Entities;

namespace ETicaretPlatformu.Application.Models.DTOs.Order_Details
{
    public class CreateOrderDetailDto
    {
        Order Order { get; set; }
        public int OrderId { get; set; }
        Product Product { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
