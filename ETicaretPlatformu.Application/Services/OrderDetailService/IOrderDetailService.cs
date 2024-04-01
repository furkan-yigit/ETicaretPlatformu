using ETicaretPlatformu.Application.Models.DTOs.Order_Details;
using ETicaretPlatformu.Application.Models.VMs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.OrderDetailService
{
    public interface IOrderDetailService
    {
        Task Create(CreateOrderDetailDto model);
        Task<OrderDetailVm> GetOrderDetailByOrderId(int orderId);
        Task Update(UpdateOrderDetailDto model);
        Task Delete(int orderDetailsId);
    }
}
