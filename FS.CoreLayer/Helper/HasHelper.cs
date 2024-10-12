using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Helper
{
    public static class HasHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac= new HMACSHA256())
            {
                passwordHash = hmac.Key;
                passwordSalt=hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
             
            }
        }
    }
}
