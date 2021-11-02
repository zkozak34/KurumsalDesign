using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResultWithData<T> : ResultWithData<T>
    {
        public ErrorResultWithData(T data, string message) : base(data, false, message) {}
        public ErrorResultWithData(T data) : base(data, false) {}
    }
}