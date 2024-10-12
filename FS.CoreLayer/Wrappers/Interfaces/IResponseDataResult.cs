using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Wrappers.Interfaces
{
    public interface IResponseDataResult<T>:IResponseResult
    {
        T Data { get; set; }
    }
}
