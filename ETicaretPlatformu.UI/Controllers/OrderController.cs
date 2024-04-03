using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Application.Services.OrderService;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static NuGet.Packaging.PackagingConstants;

namespace ETicaretPlatformu.UI.Controllers
{
    [Route("Siparislerim")]
    public class OrderController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        UserManager<User> _userManager;

        public OrderController(IUserService userService, IOrderService orderService, UserManager<User> userManager)
        {
            _userService = userService;
            _orderService = orderService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            List<OrderVm> orders=new List<OrderVm>();
            if (user != null)
                orders = await _orderService.GetOrdersForUser(user.Id);
            TempData["user"] = user;
            ViewBag.orders = orders;
            return View();
        }
    }
}
