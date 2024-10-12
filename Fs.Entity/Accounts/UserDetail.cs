using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Accounts
{
    public class UserDetail:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StatusId { get; set; }
        public RegisterStatus Status { get; set; }
        public bool IsConfirmPassword { get; set; }
        public int? ConfirmCode { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }
        public DateTime? DateOfBirth { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
