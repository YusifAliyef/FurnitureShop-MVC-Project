using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Products
{
    public class Customer:EditedBaseEntity
    {
        public Customer()
        {
            Orders=new HashSet<Order>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Order>Orders { get; set; }
    }
}
