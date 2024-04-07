﻿using ETicaretPlatformu.Application.Models.DTOs.Order_Details;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Domain.Entities;
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
        Task<OrderVm> GetOrderVm(int id);
        Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId);
        Task Update(UpdateOrderDetailDto model);
        Task Delete(int orderDetailsId);
    }
}
