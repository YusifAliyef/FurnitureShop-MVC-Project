using Fs.DataAccessLayer.EntityFrameworkCore.Abstract;
using Fs.DataAccessLayer.EntityFrameworkCore.Contexts;
using Fs.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
