using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Models.VMs.CartVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.CartService
{
    public interface ICartService
    {
        Task Create(CreateCartDto model);
        Task Update(UpdateCartDto model);
        Task RemoveProductFromCart(int cartId, int productId);
        Task RemoveAllProductFromCart(int cartId, int productId);
        Task AddProductToCart(int cartId, int productId);
        Task<CartDto> GetCartById(int cartId);

    }
}
