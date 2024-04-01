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
    public class OrderDetailRepo : BaseRepo<OrderDetail>, IOrderDetailRepo
    {
        private readonly AppDbContext _context;

        public OrderDetailRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId)
        {
            var details = await _context.OrderDetails.Where(x=>x.OrderId==orderId).ToListAsync();

            return details;
        }
    }
}
