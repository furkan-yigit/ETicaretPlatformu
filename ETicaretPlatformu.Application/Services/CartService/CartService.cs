using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Models.VMs.CartVMs;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
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
        private readonly ICartLineRepo _cartLineRepo;
        private readonly IProductRepo _productRepo;
        private readonly IMapper _mapper;

        public CartService(ICartRepo cartRepo, IProductRepo productRepo, ICartLineRepo cartLineRepo, IMapper mapper)
        {
            _cartRepo = cartRepo;
            _productRepo = productRepo;
            _cartLineRepo = cartLineRepo;
            _mapper = mapper;
        }

        public async Task Create(string userId)
        {
            var cart = await _cartRepo.GetDefault(x => x.UserId == userId);

            if (cart == null)
            {
                cart = new Cart { UserId = userId };
                await _cartRepo.Create(cart);
            }
        }

        public async Task AddProductToCart(string userId, int productId)
        {
            var cart = await GetCartByUserId(userId);

            if (cart == null)
                await Create(userId);
            else
            {
                var cartLine = await _cartLineRepo.GetDefault(x => x.CartId == cart.Id && x.ProductId == productId);
                if (cartLine != null)
                {
                    cartLine.Quantity++;
                    await _cartLineRepo.Update(cartLine);
                }
                else
                {
                    var product = await _productRepo.GetDefault(x => x.Id == productId);
                    if (product != null)
                    {
                        cartLine = new CartLine
                        {
                            ProductId = productId,
                            CartId = cart.Id,
                            Quantity = 1,
                        };
                        await _cartLineRepo.Create(cartLine);
                    }
                    else
                        throw new Exception("Product not found !");
                }
            }
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {

            var cart = await _cartRepo.GetFilteredFirstOrDefault(
                select: x => _mapper.Map<Cart>(x),
                where: x => x.UserId == userId,
                include: x => x.Include(c => c.CartLines).ThenInclude(p => p.Product).ThenInclude(ct => ct.Category)
                );

            if (cart == null)
            {
                await Create(userId);
                cart = await GetCartByUserId(userId);
                return cart;
            }
            else
                return cart;
        }

        public async Task DeleteCart(Cart cart)
        {
            List<CartLine> list = cart.CartLines.ToList();

            foreach (var cartLine in list)
            {
              await  _cartLineRepo.Delete(cartLine);
            }
             await _cartRepo.Update(cart);
        }

        public async Task RemoveProductFromCart(string userId, int productId)
        {
            var cart = await GetCartByUserId(userId);

            if (cart != null)
            {
                var productToRemove = cart.CartLines.FirstOrDefault(p => p.ProductId == productId);

                if (productToRemove != null)
                {
                    if (productToRemove.Quantity == 1)
                        await _cartLineRepo.Delete(productToRemove);
                    else
                    {
                        productToRemove.Quantity--;
                        await _cartLineRepo.Update(productToRemove);
                    }
                }
                else
                    throw new Exception("Product not found !");
            }
            else
                throw new Exception("Cart not found !");

            await _cartRepo.Update(cart);
        }
    }
}