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
    public class ProductRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext context) : base(context)
        {
        }
    }
}
