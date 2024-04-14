using ETicaretPlatformu.Application.Models.DTOs.UserDtos;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretPlatformu.UI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;

        public AccountController(IUserService userService, UserManager<User> userManager)
        {
            _userService = userService;
            _userManager = userManager;
        }

        #region AdminRegisterView
        [AllowAnonymous]
        public IActionResult AdminRegister()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    //return RedirectToAction("Index", "Home");
                
            //}
            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> AdminRegister(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return View(registerDto);
            }


            if (await CheckExistingUser(registerDto))
            {
                return View(registerDto);
            }


            var result = await _userService.AdminRegister(registerDto);
            if (result.Succeeded)
            {
                await _userService.LogOut();
                TempData["Success"] = "Admin registration successful.";
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

            if (await CheckExistingUser(registerDto))
            {
                return View(registerDto);
            }

            var result = await _userService.MemberRegister(registerDto);
            if (result.Succeeded)
            {
                TempData["Success"] = "Member registration successful.";
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
                        TempData["Success"] = "Login successful as admin.";
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else if (await _userService.UserInRole(loginDto.UserName, "Member"))
                    {
                        TempData["Success"] = "Login successful as member.";
                        return RedirectToAction("Index", "Home", new { area = "Member" });
                    }
                    TempData["Success"] = "Login successful.";
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login credentials.");
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
                TempData["Success"] = "Profile updated successfully.";         
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
            TempData["Success"] = "Successfully Logout";
            return RedirectToAction("Index", "Home");
        }

        
        public async Task<IActionResult> UpdateUserStatus(string userName, string status)
        {
            var result = await _userService.UpdateUserStatus(userName, status);

            if (result)
            {
                TempData["Success"] = "User status updated successfully";
            }
            else
            {
                TempData["Error"] = "Failed to update user status";
            }

            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }


        private async Task<bool> CheckExistingUser(RegisterDto registerDto)
        {
            var existingEmailUser = await _userManager.FindByEmailAsync(registerDto.Email);
            var existingUserName = await _userManager.FindByNameAsync(registerDto.UserName);

            if (existingEmailUser != null || existingUserName != null)
            {
                if (existingEmailUser != null && existingUserName != null)
                {
                    ModelState.AddModelError("Email", "This email is already in use.");
                    ModelState.AddModelError("UserName", "This username is already in use.");
                    return true;
                }
                else
                {
                    if (existingEmailUser != null)
                    {
                        ModelState.AddModelError("Email", "This email is already in use.");
                        return true;
                    }
                    else
                    {
                        ModelState.AddModelError("UserName", "This username is already in use.");
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

