using Fs.BusinessLogicLayer.Dtos;
using FS.CoreLayer.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.Abstract
{
    public interface IUserService
    {
        Task<IResponseDataResult<RegisterUserDto>> CreateUserAsync(CreateUserDto userDto);

    }
}
