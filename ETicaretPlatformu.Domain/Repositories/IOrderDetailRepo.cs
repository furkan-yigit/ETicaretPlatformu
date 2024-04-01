using ETicaretPlatformu.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Domain.Repositories
{
    public interface IOrderDetailRepo : IBaseRepo<OrderDetail>
    {
        public Task<List<OrderDetail>> GetOrderDetailsByOrderId(int orderId);

    }
}
