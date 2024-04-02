using ETicaretPlatformu.Application.AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Services.CartService;
using ETicaretPlatformu.Application.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Controllers
{
    public class CartController : Controller
    {

        private readonly ICartService _cartService;
        private readonly IUserService _userService;

        public CartController(ICartService cartService, IUserService userService)
        {
            _cartService = cartService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string name)
        {
            var user = await _userService.GetByUserName(name);
            
            CreateCartDto createCartDto = new CreateCartDto();
            createCartDto.UserId = user.Id;
            await CreateCart(createCartDto);

            return View(createCartDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCart(CreateCartDto model)
        {
            await _cartService.Create(model);
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToCart(int cartId, int productId)
        {
            await _cartService.AddProductToCart(cartId, productId);
            return View("Index");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCart(UpdateCartDto model)
        {
            await _cartService.Update(model);
            return View("Index");
        }

        public async Task<IActionResult> DeleteCart(int cartId, int productId)
        {
            await _cartService.RemoveAllProductFromCart(cartId, productId);
            return View("Index");
        }

        public async Task<IActionResult> RemoveProductFromCart(int cartId, int productId)
        {
            await _cartService.RemoveProductFromCart(cartId, productId);
            return View("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetCart(int id)
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
