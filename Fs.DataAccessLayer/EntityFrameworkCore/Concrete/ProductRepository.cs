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
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
