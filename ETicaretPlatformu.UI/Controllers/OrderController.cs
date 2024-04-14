using ETicaretPlatformu.Application.Models.DTOs.Order_Details;
using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Application.Services.CartService;
using ETicaretPlatformu.Application.Services.OrderDetailService;
using ETicaretPlatformu.Application.Services.OrderService;
using ETicaretPlatformu.Application.Services.ProductService;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static NuGet.Packaging.PackagingConstants;

namespace ETicaretPlatformu.UI.Controllers
{

    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrderDetailService _detailService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        UserManager<User> _userManager;
        private readonly ICartService _cartService;

        public OrderController(IUserService userService, IOrderDetailService detailService, IOrderService orderService, UserManager<User> userManager, ICartService cartService, IProductService productService)

        {
            _userService = userService;
            _detailService = detailService;
            _orderService = orderService;
            _userManager = userManager;
            _cartService = cartService;
            _productService = productService;
        }

        public async Task<IActionResult> Checkout(string userId)
        {
            Cart cart = await _cartService.GetCartByUserId(userId);
            var ord = await _orderService.GetOrders();
            if (cart != null)
            {
                List<CartLine> list = cart.CartLines.ToList();
                foreach (var cartLine in list)
                {
                    var product = await _productService.GetById(cartLine.ProductId);
                    if (product.StockQuantity < cartLine.Quantity)
                    {
                        await _cartService.DeleteCart(cart);
                        TempData["Error"] = $"insufficient stock quantity for the product {product.Name}";
                        return RedirectToAction("Index", "Home");

                    }
                }

                int createdOrderID = 1;
                if (ord.Count >= 1)
                    createdOrderID = ord.Max(x => x.Id) + 1;

                List<OrderDetail> orderDetails = await _detailService.GetOrderDetailsByOrderId(createdOrderID);

                var order = new CreateOrderDto()
                {
                    UserId = userId,
                };
                await _orderService.Create(order);



                foreach (var c in list)
                {
                    await _productService.DecreaseStockQuantity(c.ProductId, c.Quantity);
                    CreateOrderDetailDto detail = new CreateOrderDetailDto()
                    {
                        ProductId = c.ProductId,
                        Quantity = c.Quantity,
                        OrderId = createdOrderID
                    };
                    await _detailService.Create(detail);
                }
                await _cartService.DeleteCart(cart);

            }
            return RedirectToAction("Index", "Order", new { area = "" });
        }
        [Route("MyOrders")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            List<OrderVm> orders = new List<OrderVm>();
            if (user != null)
                orders = await _orderService.GetOrdersForUser(user.Id);
            ViewData["user"] = user;
            ViewBag.orders = orders;
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var Order = await _orderService.GetVmById(id);

            if (Order.User == user)
            {
                return View(Order);
            }

            return RedirectToAction("Index", "Home");

        }
    }
}
