using ETicaretPlatformu.Application.Models.DTOs.Order_Details;
using ETicaretPlatformu.Application.Models.DTOs.OrderDto;
using ETicaretPlatformu.Application.Models.VMs.Order;
using ETicaretPlatformu.Application.Services.OrderDetailService;
using ETicaretPlatformu.Application.Services.OrderService;
using ETicaretPlatformu.Application.Services.ProductService;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ETicaretPlatformu.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderDetailController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;

        public OrderDetailController(IOrderService orderService, IProductService productService, IOrderDetailService orderDetailService, IUserService userService, UserManager<User> userManager)
        {
            _orderService = orderService;
            _productService = productService;
            _orderDetailService = orderDetailService;
            _userService = userService;
            _userManager = userManager;
        }


        public async Task<IActionResult> Create(int orderId)
        {
            var model = await _orderDetailService.GetOrderVm(orderId);
            ViewBag.order = model;
            ViewBag.products =await _productService.GetProducts();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDetailDto model)
        {
            var a = await _orderDetailService.GetOrderVm(model.OrderId);
            ViewBag.order = a;
            ViewBag.products = await _productService.GetProducts();
            if (ModelState.IsValid)
            {
                bool isDetailExist =await _orderDetailService.DoesDetailExist(model.OrderId, model.ProductId);
                int id=0;
                if (isDetailExist)
                {
                    await _orderDetailService.Create(model);
                }
                else
                {
               _orderDetailService.ChangeQuantity(await _orderDetailService.GetDetailId(model.OrderId, model.ProductId), model.Quantity);
                  //  await _orderDetailService.Update();
                }


                return RedirectToAction("Update", "Order", new { area = "Admin",id= model.OrderId });
            }
            else
            {
                return View(model.OrderId);
            }
        }
    }
}
