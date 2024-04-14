using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepo _orderRepo;
        private readonly IOrderDetailRepo _orderDetailRepo;

        public OrderService(IMapper mapper, IOrderRepo orderRepo, IOrderDetailRepo orderDetailRepo)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
            _orderDetailRepo = orderDetailRepo;
        }

        public async Task Create(CreateOrderDto model)
        {
            var order = _mapper.Map<Order>(model);
            await _orderRepo.Create(order);
        }



        public async Task Delete(int id)
        {
            Order order = await _orderRepo.GetDefault(x => x.Id == id);
            order.DeleteDate = DateTime.Now;
            order.Status = Status.Passive;

            List<OrderDetail> details = await _orderDetailRepo.GetDefaults(x => x.OrderId == id);

            foreach (OrderDetail detail in details)
            {
                detail.DeleteDate = DateTime.Now;
                detail.Status = Status.Passive;
            }
            await _orderRepo.Update(order);
        }

        public async Task<UpdateOrderDto> GetById(int id)
        {
            var order = await _orderRepo.GetFilteredFirstOrDefault
                 (select: x => _mapper.Map<UpdateOrderDto>(x),
            where: x => x.Id == id && x.Status != Status.Passive,
            include: x => x.Include(x => x.OrderDetails).ThenInclude(x=>x.Product).Include(x => x.User)
            );


            return order;
        }

        public async Task<OrderVm> GetVmById(int id)
        {
            var order = await _orderRepo.GetFilteredFirstOrDefault
                 (select: x => _mapper.Map<OrderVm>(x),
            where: x => x.Id == id && x.Status != Status.Passive,
            include: x => x.Include(x => x.OrderDetails).ThenInclude(x => x.Product).Include(x => x.User)
            );


            return order;
        }



        public async Task<List<OrderVm>> GetOrders()
        {
            var order = await _orderRepo.GetFilteredList
                 (
                select: x => _mapper.Map<OrderVm>(x),
            where: x => x.Status != Status.Passive,
            include:x=>x.Include(x => x.User).Include(x=> x.OrderDetails).ThenInclude(x=>x.Product),
            orderBy:x=>x.OrderBy(x=>x.OrderStatus)
            );

            


            return order;
        }
        public async Task<List<OrderVm>> GetOrdersForUser(string userId)
        {
            var order = await _orderRepo.GetFilteredList
                 (select: x => _mapper.Map<OrderVm>(x),
            where: x => x.Status != Status.Passive && x.UserId==userId,
            include: x => x.Include(x => x.OrderDetails).ThenInclude(x=>x.Product).Include(x => x.User)
            );


            return order;
        }


        public async Task Update(UpdateOrderDto model)
        {
            var order = _mapper.Map<Order>(model);

            order.Status = Status.Modified;
            await _orderRepo.Update(order);
        }
    }
}
