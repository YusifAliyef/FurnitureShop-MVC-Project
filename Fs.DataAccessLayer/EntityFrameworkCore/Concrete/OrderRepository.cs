﻿using Fs.DataAccessLayer.EntityFrameworkCore.Abstract;
using Fs.DataAccessLayer.EntityFrameworkCore.Contexts;
using Fs.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
