﻿using ETicaretPlatformu.Application.Models.DTOs;
using ETicaretPlatformu.Application.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        
            private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        #region AdminRegisterView
        [AllowAnonymous]
        public IActionResult AdminRegister()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", nameof(HomeController));
            }
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> AdminRegister(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return View(registerDto);
            }
            var result = await _userService.AdminRegister(registerDto);
            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region MemberRegisterView
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", nameof(HomeController));
            }
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return View(registerDto);
            }
            var result = await _userService.MemberRegister(registerDto);
            return RedirectToAction("Index", "Home");
        }
        #endregion


        [AllowAnonymous]
        public IActionResult Login(string returnUrl = "/")
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginDto loginDto, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.Login(loginDto);

                if (result.Succeeded)
                {
                    if (await _userService.UserInRole(loginDto.UserName, "Admin"))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else if (await _userService.UserInRole(loginDto.UserName, "Member"))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Member" });
                    }
                    return RedirectToAction(returnUrl);
                }
                ModelState.AddModelError("", "Hatali giris islemi");
            }
            return View(loginDto);
        }


        private IActionResult RedirectToLocal(string returnUrl = "/")
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> Edit(string userName)
        {
            var user = await _userService.GetByUserName(userName);
            return View(user);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProfileDto update)
        {
            if (ModelState.IsValid)
            {
                await _userService.UpdateUser(update);
                TempData["Success"] = "Guncelleme islemi basarili";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Error"] = "Guncelleme islemi basarisiz";
                return View(update);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _userService.LogOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
