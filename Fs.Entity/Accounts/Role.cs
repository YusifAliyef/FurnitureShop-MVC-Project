using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Accounts
{
    public class Role:EditedBaseEntity
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public string Value { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
