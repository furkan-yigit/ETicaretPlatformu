using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Order_Details;
using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.OrderDetailService
{
    public class OrderDetailService:IOrderDetailService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepo _orderRepo;
        private readonly IOrderDetailRepo _orderDetailRepo;

        public OrderDetailService(IMapper mapper, IOrderRepo orderRepo, IOrderDetailRepo orderDetailRepo)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
            _orderDetailRepo = orderDetailRepo;
        }

        public async Task Create(CreateOrderDetailDto model)
        {
            var order = _mapper.Map<OrderDetail>(model);

            await _orderDetailRepo.Create(order);
        }

        public async Task<OrderDetailVm> GetOrderDetailByOrderId(int orderId)
        {
            var orderDet = 
                await _orderDetailRepo.GetFilteredFirstOrDefault
                (
                    select: x => _mapper.Map<OrderDetailVm>(x),
           where: x => x.OrderId == orderId && x.Status != Status.Passive);


            return orderDet;
        }
        public async Task Update(UpdateOrderDetailDto model)
        {
            var order = _mapper.Map<OrderDetail>(model);
            order.Status = Status.Modified;
            await _orderDetailRepo.Update(order);
        }
        public async Task Delete(int orderDetailsId)
        {
            var orderDetail = await _orderDetailRepo.GetDefault(x=>x.Id==orderDetailsId);
            if (orderDetail == null)
            {
                return;
            }
            orderDetail.DeleteDate = DateTime.Now;
            orderDetail.Status = Status.Passive;
        }


    }
}
