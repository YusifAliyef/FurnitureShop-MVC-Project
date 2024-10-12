using FS.CoreLayer.Classes;
using FS.CoreLayer.Enums;
using FS.CoreLayer.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Wrappers.Implementations
{
    public class ResponseResult : IResponseResult
    {
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
        public ICollection<ResponseValidationResult> ResponseValidationResults { get; set ; }

        public ResponseResult(ResponseType responseType, string message)
        {
            ResponseType = responseType;
            Message = message;
        }

        public ResponseResult(ICollection<ResponseValidationResult> responseValidationResults)
        {
            Message = " Validation error";
            ResponseType = ResponseType.ValidationError;
            ResponseValidationResults = responseValidationResults;
        }



    }
}
