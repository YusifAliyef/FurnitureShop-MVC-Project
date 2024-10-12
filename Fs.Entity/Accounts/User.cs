using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Accounts
{
    public class User:BaseEntity
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            UploadedFiles = new HashSet<UploadedFile>();
        }
        public string Email { get; set; }
        public string PassworHash { get; set; }
        public string PasswordSalt { get; set; }
        public UserDetail? UserDetail { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<UploadedFile> UploadedFiles { get; set; }
       
    }
}
