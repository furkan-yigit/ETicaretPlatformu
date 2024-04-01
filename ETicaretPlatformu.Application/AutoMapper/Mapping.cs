using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs;
using ETicaretPlatformu.Application.Models.DTOs.CatagoryDto;
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

            //CreateMap<Product, CreateAuthorDto>().ReverseMap();

            //CreateMap<Order, CreateGenreDTO>().ReverseMap();

            //CreateMap<OrderDetail, CreatePostDto>().ReverseMap();

            //CreateMap<Cart, UpdatePostDto>().ReverseMap();

            //CreateMap<Category, PostVm>().ReverseMap();
        }
    }
}
