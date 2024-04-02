using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Models.VMs.CartVMs;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ICartRepo _cartRepo;
        private readonly IProductRepo _productRepo;

        private readonly IMapper _mapper;

        public CartService(ICartRepo cartRepo, IMapper mapper, IProductRepo productRepo)
        {
            _cartRepo = cartRepo;
            _mapper = mapper;
            _productRepo = productRepo;
        }

        public async Task Create(CreateCartDto model)
        {
            var cart = _mapper.Map<Cart>(model);

            //cart.UserId = model.UserId;
            //cart.Products = model.Products.Select(p => new Product
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Description = p.Description,
            //    Price = p.Price,
            //    StockQuantity = p.StockQuantity,
            //    CategoryId = p.CategoryId,
            //    ImagePath = p.ImagePath
            //}).ToList();
            cart.CreateDate = DateTime.Now;
            cart.Status = Status.Active;

            await _cartRepo.Create(cart);
        }


        public async Task Update(UpdateCartDto model)
        {
            var cart = await _cartRepo.GetDefault(c => c.Id == model.Id);
            if (cart != null)
            {
                _mapper.Map<Cart>(model);
                cart.UpdateDate = DateTime.Now;
                await _cartRepo.Update(cart);
            }

            //var cart = await _cartRepo.GetDefault(c => c.Id == model.Id);
            //if (cart != null)
            //{
            //    cart.UserId = model.UserId;
            //    cart.Products = model.Products.Select(p => new Product
            //    {
            //        Id = p.Id,
            //        Name = p.Name,
            //        Description = p.Description,
            //        Price = p.Price,
            //        StockQuantity = p.StockQuantity,
            //        CategoryId = p.CategoryId,
            //        ImagePath = p.ImagePath
            //    }).ToList();
            //    cart.UpdateDate = DateTime.Now;
            //    await _cartRepo.Update(cart);
            //}
        }

        public async Task RemoveProductFromCart(int cartId, int productId)
        {
            var cart = await _cartRepo.GetDefault(c => c.Id == cartId);
            if (cart != null)
            {
                var productToRemove = cart.Products.FirstOrDefault(p => p.Id == productId);
                if (productToRemove != null)
                {
                    cart.Products.Remove(productToRemove);
                    await _cartRepo.Update(cart);
                }
            }
        }

        public async Task<CartDto> GetCartById(int cartId)
        {

            var cart = await _cartRepo.GetDefault(c => c.Id == cartId);
            if (cart != null)
            {
                return _mapper.Map<CartDto>(cart);
            }
            return null;

            //    var cart = await _cartRepo.GetDefault(c => c.Id == cartId);
            //    if (cart != null)
            //    {
            //        var cartDto = new CartDto
            //        {
            //            Id = cart.Id,
            //            UserId = cart.UserId,
            //            Products = cart.Products.Select(p => new ProductDto
            //            {
            //                Id = p.Id,
            //                Name = p.Name,
            //                Description = p.Description,
            //                Price = p.Price,
            //                StockQuantity = p.StockQuantity,
            //                CategoryId = p.CategoryId,
            //                ImagePath = p.ImagePath
            //            }).ToList(),
            //            CreateDate = cart.CreateDate,
            //            UpdateDate = cart.UpdateDate,
            //            Status = cart.Status
            //        };
            //        return cartDto;
            //    }
            //    return null;
            //}

        }

        public async Task AddProductToCart(int cartId, int productId)
        {
            var cart = await _cartRepo.GetDefault(c => c.Id == cartId);
            if (cart != null)
            {
                var productToAdd = await _productRepo.GetDefault(p => p.Id == productId);
                if (productToAdd != null)
                {
                    cart.Products.Add(productToAdd);
                    await _cartRepo.Update(cart);
                }
            }
        }

        public async Task RemoveAllProductFromCart(int cartId, int productId)
        {
            var cart = await _cartRepo.GetDefault(c => c.Id == cartId);
            if (cart != null)
            {
                var productToRemove = cart.Products.Where(p => p.Id == productId).ToList();
                if (productToRemove != null)
                {
                    foreach (var item in productToRemove)
                    {
                        cart.Products.Remove(item);
                    }
                    await _cartRepo.Update(cart);
                }
            }
        }
    }
}

