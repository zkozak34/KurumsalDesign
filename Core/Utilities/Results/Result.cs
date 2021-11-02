using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSucceed, string message) : this(isSucceed)
        {
            Message = message;
        }

        public Result(bool isSucceed)
        {
            IsSucceed = isSucceed;
        }

        public bool IsSucceed { get; }

        public string Message { get; }
    }
}