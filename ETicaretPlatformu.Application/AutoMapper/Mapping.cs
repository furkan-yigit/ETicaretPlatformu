using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Models.DTOs;
using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Models.DTOs.CatagoryDto;
using ETicaretPlatformu.Application.Models.DTOs.UserDtos;
using ETicaretPlatformu.Application.Models.VMs.CartVMs;
using ETicaretPlatformu.Application.Models.VMs.CatagoryVM;
using ETicaretPlatformu.Domain.Entities;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.DTOs.Order_Details;

namespace ETicaretPlatformu.Application.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, RegisterDto>().ReverseMap();
            CreateMap<User, LoginDto>().ReverseMap();
            CreateMap<User, UpdateProfileDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Category,CatagoryVM>().ReverseMap();
            CreateMap<Category, CreateCatogoryDto>().ReverseMap();  
            CreateMap<CatagoryVM,UpdateCatagoryDto>().ReverseMap();
            CreateMap<UpdateCatagoryDto,Category>().ReverseMap();

            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<ProductVM, UpdateProductDto>().ReverseMap();

            //CreateMap<Order, CreateGenreDTO>().ReverseMap();

            //CreateMap<OrderDetail, CreatePostDto>().ReverseMap();

            CreateMap<Cart, CreateCartDto>().ReverseMap();
            CreateMap<Cart, UpdateCartDto>().ReverseMap();
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<CreateCartDto, Cart>().ReverseMap();
            CreateMap<CartDto, Cart>().ReverseMap();
            CreateMap<CartDto, CreateCartDto>().ReverseMap();
            CreateMap<CartVM, Cart>().ReverseMap();

            //CreateMap<Category, PostVm>().ReverseMap();


            //order
            CreateMap<Order, OrderVm>().ReverseMap();
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, UpdateOrderDto>().ReverseMap();
            //orderdetail
            CreateMap<OrderDetail, OrderDetailVm>().ReverseMap();
            CreateMap<OrderDetail, CreateOrderDetailDto>().ReverseMap();
            CreateMap<OrderDetail, UpdateOrderDetailDto > ().ReverseMap();
           // CreateMap<OrderDetail, UpdateOrderDto>().ReverseMap();
        }
    }
}
