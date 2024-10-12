using Fs.DataAccessLayer.EntityFrameworkCore.Abstract;
using Fs.DataAccessLayer.EntityFrameworkCore.Contexts;
using Fs.Entity.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class RegisterStatusRepostiory : GenericRepository<RegisterStatus>, IRegisterStatuRepository
    {
        public RegisterStatusRepostiory(FsContext dbContext) : base(dbContext)
        {
        }
    }
}
