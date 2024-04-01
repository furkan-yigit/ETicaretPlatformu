using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
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
            //CreateMap<User, RegisterDto>().ReverseMap();

            CreateMap<Product, AddProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();

            //CreateMap<Order, CreateGenreDTO>().ReverseMap();

            //CreateMap<OrderDetail, CreatePostDto>().ReverseMap();

            //CreateMap<Cart, UpdatePostDto>().ReverseMap();

            //CreateMap<Category, PostVm>().ReverseMap();
        }
    }
}
