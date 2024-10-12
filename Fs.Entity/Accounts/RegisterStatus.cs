using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Accounts
{
    public class RegisterStatus:BaseEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}

