using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.core
{
    public class AppException
    {
        public AppException(int statusCode, string message, string details = null)
        {
            StatusCode = statusCode;
            Message = message;
            this.details = details;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; } 

        public string details { get; set; }
    }
}