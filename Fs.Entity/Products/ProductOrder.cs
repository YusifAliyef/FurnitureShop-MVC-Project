using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Products
{
    public class ProductOrder:BaseEntity
    {
        public ProductOrder()
        {
            Product = new Product();
            Order = new Order();
        }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
