﻿using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Repositories;
using ETicaretPlatformu.InfraStructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.Repositories
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(AppDbContext context) : base(context)
        {
        }
    }
}
