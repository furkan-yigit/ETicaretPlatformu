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

        public async Task<CartDto> Create(string userId)
        {
            var cart = await _cartRepo.GetDefault(x => x.UserId == userId);

            if (cart == null)
            {
                cart = Cart.Instance(userId);
            }
            return _mapper.Map<CartDto>(cart);
        }

        public async Task<CartDto> GetCartById(string cartId)
        {

            var cart = await _cartRepo.GetDefault(c => c.Id == cartId);
            if (cart != null)
            {
                return _mapper.Map<CartDto>(cart);
            }
            return null;

        }


        public async Task<CartDto> GetCartByUserId(string userId)
        {
            var cart = await _cartRepo.GetDefault(x => x.UserId == userId);
            if (cart != null)
                return _mapper.Map<CartDto>(cart);
            else
                return null;
        }

        public async Task RemoveProductFromCart(string userId, int productId)
        {
            var cart = await _cartRepo.GetDefault(x => x.UserId == userId);
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


        public async Task AddProductToCart(string userId, int productId)
        {
            var cart = await _cartRepo.GetDefault(x => x.UserId == userId);
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

        public async Task RemoveAllProductFromCart(string userId, int productId)
        {
            var cart = await _cartRepo.GetDefault(x => x.UserId == userId);
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

