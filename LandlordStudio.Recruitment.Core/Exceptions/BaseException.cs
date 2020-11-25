using LandlordStudio.Recruitment.Core.Enums;
using System;

namespace LandlordStudio.Recruitment.Core.Exceptions
{
    public class BaseException : Exception
    {
        public BaseException(StatusCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
        public StatusCode StatusCode { get; set; }
    }
}
