using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Order_Details;
using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using ETicaretPlatformu.InfraStructure.Repositories;
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
        private readonly IProductRepo _productRepo;

        public OrderDetailService(IMapper mapper, IOrderRepo orderRepo, IOrderDetailRepo orderDetailRepo,IProductRepo productRepo)
        {
            _mapper = mapper;
            _orderRepo = orderRepo;
            _orderDetailRepo = orderDetailRepo;
            _productRepo = productRepo;
        }

        public async Task Create(CreateOrderDetailDto model)
        {
            var order = _mapper.Map<OrderDetail>(model);
            order.Product =await _productRepo.GetDefault(x=>x.Id==model.ProductId);
            await _orderDetailRepo.Create(order);
        }

        public async Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId)
        {
            var orderDet =
                await _orderDetailRepo.GetDefaults(x=>x.OrderId==orderId && x.Status!=Status.Passive);
              

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

        public async Task<OrderVm> GetOrderVm(int id)
        {
            var order=await _orderRepo.GetDefault(x=>x.Id==id);
            OrderVm model=_mapper.Map<OrderVm>(order);
            return model;
        }

        public async Task<bool> DoesDetailExist(int orderId,int productId)
        {
            var orderdetail =await _orderDetailRepo.GetFilteredFirstOrDefault
                (select:x=>_mapper.Map<UpdateOrderDetailDto>(x),
                where:x=>x.OrderId==orderId&& x.ProductId==productId
                );

            return orderdetail==null?true:false;
        }
        public async Task<int> GetDetailId(int orderId, int productId)
        {

            var orderdetail = await _orderDetailRepo.GetFilteredFirstOrDefault
                (select: x => _mapper.Map<UpdateOrderDetailDto>(x),
                where: x => x.OrderId == orderId && x.ProductId == productId
                );

            return orderdetail.Id;
        }

        public async Task ChangeQuantity(int detailId, int quantity)
        {
            var order = await _orderDetailRepo.GetFilteredFirstOrDefault(
                select:x=>_mapper.Map<OrderDetail>(x),
                where:x=>x.Id==detailId
                );

            order.Quantity = quantity;
            order.Status = Status.Modified;
            await _orderDetailRepo.Update(order);
        }
    }
}
