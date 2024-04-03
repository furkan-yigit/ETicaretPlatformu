using ETicaretPlatformu.Application.Models.DTOs.UserDtos;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Enums;
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

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerDto);
            }
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
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerDto);
            }
            
        }
        #endregion


        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }            
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginDto loginDto)
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
                    return RedirectToAction("Index", "Home");
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
            if (!ModelState.IsValid)
            {
                return View(update);
            }
            try
            {
                await _userService.UpdateUser(update);
                TempData["Success"] = "Profile successfully updated";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error: " + ex.Message);
                return View(update);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await _userService.LogOut();
            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> UpdateUserStatus(string userName, string status)
        {
            var result = await _userService.UpdateUserStatus(userName, status);

            if (result)
            {
                TempData["Success"] = "asfasfg";
            }
            else
            {
                TempData["Error"] = "asfasfg";
            }

            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}

