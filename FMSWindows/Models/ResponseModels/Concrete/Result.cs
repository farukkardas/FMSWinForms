using FMSWindows.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Models.ResponseModels.Concrete
{
    public class Result : IResult
    {
        protected Result(bool success, string message) : this(success)
        {
            Success = success;
            Message = message;
        }

        protected Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; set; }
    }
}
