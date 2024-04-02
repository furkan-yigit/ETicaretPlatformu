﻿using AutoMapper;
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

            //CreateMap<Order, CreateGenreDTO>().ReverseMap();

            //CreateMap<OrderDetail, CreatePostDto>().ReverseMap();

            CreateMap<Cart, CreateCartDto>().ReverseMap();
            CreateMap<Cart, UpdateCartDto>().ReverseMap();
            CreateMap<CartDto, Cart>().ReverseMap();
            CreateMap<CartVM, Cart>().ReverseMap();

            //CreateMap<Category, PostVm>().ReverseMap();
        }
    }
}
