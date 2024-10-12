using FS.CoreLayer.Classes;
using FS.CoreLayer.Enums;
using FS.CoreLayer.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Wrappers.Implementations
{
    public class ResponseDataResult<T> : ResponseResult, IResponseDataResult<T>
    {
        public ResponseDataResult(ResponseType responseType, string message) : base(responseType, message)
        {

        }

        public ResponseDataResult(ICollection<ResponseValidationResult> validationResults) : base(validationResults)
        {

        }

        public T Data { get; set; }
        public ResponseDataResult(T data) : base(ResponseType.SuccessResult, "Success")
        {
            Data = data;
        }


    }
}
