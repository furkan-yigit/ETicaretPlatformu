using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.DTOs.UserDtos;
using ETicaretPlatformu.Application.Services.OrderDetailService;
using ETicaretPlatformu.Application.Services.OrderService;
using ETicaretPlatformu.Application.Services.ProductService;
using ETicaretPlatformu.Application.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IUserService _userService;

        public OrderController(IOrderService orderService,IOrderDetailService orderDetailService,IUserService userService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _userService = userService;
        }
        public async Task<IActionResult>  Index()
        {
            var orders = await _orderService.GetOrders();
            return View(orders);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Users = await _userService.GetUsers();
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDto model)
        {
            if (ModelState.IsValid)
            {
                await _orderService.Create(model);

                return RedirectToAction("Index", "Order", new { area = "Admin" });
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Update()
        {
            ViewBag.Users = await _userService.GetUsers();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateOrderDto model)
        {
            if (ModelState.IsValid)
            {
                await _orderService.Update(model);

                return RedirectToAction("Index", "Order", new { area = "Admin" });
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _orderService.Delete(id);
            return RedirectToAction("Index", "Order", new {area="Admin"});
        }

        
        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.Users = await _userService.GetUsers();

            var order = await _orderService.GetById(id);
            return View(order);
        }

    }
}
