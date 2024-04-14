using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.OrderService
{
    public interface IOrderService
    {
        Task Create(CreateOrderDto model);
        Task Update(UpdateOrderDto model);
        Task Delete(int id);
        Task<List<OrderVm>> GetOrders();
        Task<List<OrderVm>> GetOrdersForUser(string userId);
        Task<UpdateOrderDto> GetById(int id);
        Task<OrderVm> GetVmById(int id);        
    }
}
