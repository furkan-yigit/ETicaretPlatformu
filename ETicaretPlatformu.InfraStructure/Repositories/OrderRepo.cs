using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Repositories;
using ETicaretPlatformu.InfraStructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.Repositories
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        private readonly AppDbContext context;

        public OrderRepo(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Order>> GetOrderByUserId(string userId)
        {
            var orders =await context.Orders.Where(x => x.UserId == userId).ToListAsync();
            return orders;
        }
    }
}
