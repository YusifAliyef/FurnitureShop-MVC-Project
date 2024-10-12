using FS.CoreLayer.Classes;
using FS.CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Wrappers.Interfaces
{
    public interface IResponseResult
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }

        ICollection<ResponseValidationResult> ResponseValidationResults { get; set; }
    }
}
