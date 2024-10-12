using Fs.Entity.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Abstract
{
    public interface ICustomerRepository:IGenericRepository<Customer>
    {
    }
}
