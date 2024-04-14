using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Models.VMs.CartVMs;
using ETicaretPlatformu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.CartService
{
    public interface ICartService
    {
        Task Create(string userId);
        Task RemoveProductFromCart(string userId, int productId);
        Task AddProductToCart(string userId, int productId);
        Task<Cart> GetCartByUserId(string userId);
        Task DeleteCart(Cart cart);
    }
}
