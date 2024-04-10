﻿using AutoMapper;
using ETicaretPlatformu.Application.AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.Cart;
using ETicaretPlatformu.Application.Services.CartService;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ETicaretPlatformu.UI.Controllers
{
    [Authorize]
    public class CartController : Controller
    {

        private readonly ICartService _cartService;
        private readonly IUserService _userService;

        public CartController(ICartService cartService, IUserService userService)
        {
            _cartService = cartService;
            _userService = userService;
        }

        public async Task<IActionResult> Index(string userName)
        {
            var user = await _userService.GetByUserName(userName);
            var cart = await _cartService.GetCartByUserId(user.Id);

            if (cart == null)
                await _cartService.Create(user.Id);

            return RedirectToAction("GetCart", new { userId = user.Id });
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToCart(string userName, int productId, string returnURL)
        {
            var user = await _userService.GetByUserName(userName);
            try
            {
                await _cartService.AddProductToCart(user.Id, productId);
                TempData["Success"] = "Add to cart successful.";
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while adding the product to the cart.";
            }

            return RedirectToAction("GetCart", new { userId = user.Id });
            //return Redirect(returnURL);
            //return Ok("kayıt başarılı");
        }

        public async Task<IActionResult> RemoveProductFromCart(string userName, int productId)
        {
            var user = await _userService.GetByUserName(userName);

            try
            {
                await _cartService.RemoveProductFromCart(user.Id, productId);
                TempData["Success"] = "Delete from cart successful.";
            }
            catch (Exception)
            {
                TempData["Error"] = "An error occurred while removing the product from the cart.";
            }

            return RedirectToAction("GetCart", new { userId = user.Id });
        }

        [HttpGet]
        public async Task<IActionResult> GetCart(string userId)
        {
            var cart = await _cartService.GetCartByUserId(userId);
            if (cart == null)
                TempData["Error"] = "Cart not found.";

            return View(cart);
        }
    }
}
