using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Repositories;
using ETicaretPlatformu.InfraStructure.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.Repositories
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        UserManager<User> _userManager;
        public UserRepo(AppDbContext context, UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
        }

        public override Task Create(User entity)
        {
            _userManager.CreateAsync(entity);
            return base.Create(entity);
        }
    }
}
