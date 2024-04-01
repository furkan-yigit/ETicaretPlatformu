﻿using ETicaretPlatformu.Application.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.UserService
{
    public interface IUserService
    {
        Task<IdentityResult> AdminRegister(RegisterDto model);
        Task<IdentityResult> MemberRegister(RegisterDto model);

        Task<SignInResult> Login(LoginDto model);

        Task LogOut();

        Task UpdateUser(UpdateProfileDto model);

        Task<UpdateProfileDto> GetByUserName(string userName);
        Task<bool> UserInRole(string userName, string role);
    }
}