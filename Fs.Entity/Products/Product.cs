using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Products
{
    public class Product:EditedBaseEntity
    {
        public Product()
        {
            ProductOrders=new HashSet<ProductOrder>();
            UploadedFiles = new HashSet<UploadedFile>();
        }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool Instock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductOrder>ProductOrders { get; set; }
        public ICollection<UploadedFile> UploadedFiles { get; set; }
    }
}
