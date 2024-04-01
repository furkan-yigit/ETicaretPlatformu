using ETicaretPlatformu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Domain.Repositories
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
         public Task<List<Order>> GetOrderByUserId(string userId);
    }
}
