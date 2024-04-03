﻿using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.UserDtos;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo,
                           UserManager<User> userManager,
                           SignInManager<User> signInManager,
                           IMapper mapper)
        {
            _userRepo = userRepo;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }




        public async Task<UpdateProfileDto> GetByUserName(string userName)
        {
            var user = await _userRepo.GetFilteredFirstOrDefault(
                            select: x => _mapper.Map<UpdateProfileDto>(x),
                            where: x => x.UserName.Equals(userName) && x.Status != Status.Passive);

            return user;
        }

        public async Task<SignInResult> Login(LoginDto model)
        {
            var user = await _userRepo.GetDefault(x => x.UserName.Equals(model.UserName));
            if (user.Status != Status.Passive)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                return result;                
            }
            else
            {
                return SignInResult.Failed;
            }
            
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> AdminRegister(RegisterDto model)
        {
            var user = _mapper.Map<User>(model);

            var result = await _userManager.CreateAsync(user, model.Password);
            await _userManager.AddToRoleAsync(user, "ADMIN");

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
            }


            return result;
        }

        public async Task<IdentityResult> MemberRegister(RegisterDto model)
        {
            var user = _mapper.Map<User>(model);

            var result = await _userManager.CreateAsync(user, model.Password);
            await _userManager.AddToRoleAsync(user, "MEMBER");

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
            }


            return result;
        }

        public async Task UpdateUser(UpdateProfileDto model)
        {
            var user = await _userRepo.GetDefault(x => x.Id.Equals(model.Id));

            if (model.UploadPath != null)
            {
                using var image = Image.Load(model.UploadPath.OpenReadStream());
                image.Mutate(x => x.Resize(600, 560));
                Guid guid = Guid.NewGuid();
                image.Save($"wwwroot/images/{guid}.jpg");
                user.ImagePath = $"/images/{guid}.jpg";

                await _userRepo.Update(user);
            }
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;


            if (!string.IsNullOrEmpty(model.Password))
            {
                var isUserNameExist = await _userManager.FindByNameAsync(model.UserName);

                if (isUserNameExist == null)
                {
                    await _userManager.SetUserNameAsync(user, model.UserName);
                    await _signInManager.SignInAsync(user, false);
                }
            }

            if (!string.IsNullOrEmpty(model.Email))
            {
                var isUserEmailExist = await _userManager.FindByEmailAsync(model.Email.ToUpper());

                if (isUserEmailExist == null)
                {
                    await _userManager.SetEmailAsync(user, model.Email);
                }
            }
        }

        public async Task<bool> UserInRole(string userName, string role)
        {
            var user = await _userManager.FindByNameAsync(userName);
            bool isInRole = await _userManager.IsInRoleAsync(user, role);

            return isInRole;
        }

        public async Task<IEnumerable<UserDto>> GetUsers()
        {
            var users = await _userRepo.GetDefaults(x=>true);
            return _mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<bool> UpdateUserStatus(string userName, string status)
        {
            var user = await _userRepo.GetDefault(x => x.UserName.Equals(userName));

            if (user == null)
            {
                return false;
            }

            if (status == "Active")
            {
                user.Status = Status.Active;
            }
            else
            {
                user.Status = Status.Passive;
            }
            
            await _userRepo.Update(user);
            return true;
        }
    }
}
