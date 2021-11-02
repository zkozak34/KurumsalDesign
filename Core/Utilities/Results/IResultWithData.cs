using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResultWithData<T> : IResult
    {
        T Data { get; } 
    }
}