using AutoMapper;
using ETicaretPlatformu.Application.AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Services.CartService;
using ETicaretPlatformu.Application.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ETicaretPlatformu.UI.Controllers
{
    //[Authorize]
    public class CartController : Controller
    {

        private readonly ICartService _cartService;
        private readonly IUserService _userService;
        private readonly Mapper _mapper;
        public string _userId; 
        
        public CartController(ICartService cartService, IUserService userService)
        {
            _cartService = cartService;
            _userService = userService;
        }

        public async Task<IActionResult> Index(string userName)
        {
            var user = await _userService.GetByUserName(userName);
            _userId = user.Id;
            
            var cart = await _cartService.GetCartByUserId(_userId);

            if (cart == null)
            {
               cart = await _cartService.Create(_userId);
            }
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToCart(int productId)
        {
            await _cartService.AddProductToCart(_userId, productId);
            return View("Index");
        }

        public async Task<IActionResult> DeleteCart(int productId)
        {
            await _cartService.RemoveAllProductFromCart(_userId, productId);
            return View("Index");
        }

        public async Task<IActionResult> RemoveProductFromCart(int productId)
        {
            await _cartService.RemoveProductFromCart(_userId, productId);
            return View("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetCart(string id)
        {
            var cart = await _cartService.GetCartById(id);
            if (cart == null)
            {
                return NotFound();
            }
            return View(cart.Products);
        }
    }
}
