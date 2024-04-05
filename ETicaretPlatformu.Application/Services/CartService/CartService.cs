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
        private readonly ICartLineRepo _cartLineRepo;
        private readonly IProductRepo _productRepo;

        public CartService(ICartRepo cartRepo, IProductRepo productRepo, ICartLineRepo cartLineRepo)
        {
            _cartRepo = cartRepo;
            _productRepo = productRepo;
            _cartLineRepo = cartLineRepo;
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
            var cart = await _cartRepo.GetDefaultIncluding(
                            x => x.UserId == userId,
                            c => c.CartLines
                        );

            if (cart == null)
            {
                await Create(userId);
                cart =  await GetCartByUserId(userId);
                return cart;
            }
            else
            {
                foreach (var cartLine in cart.CartLines)
                {
                    cartLine.Product = await _productRepo.GetDefaultIncluding(
                            p => p.Id == cartLine.ProductId,
                            p => p.Category
                        );
                }
                return cart;
            }
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

