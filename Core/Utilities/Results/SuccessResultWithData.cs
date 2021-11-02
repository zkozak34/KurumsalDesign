using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResultWithData<T> : ResultWithData<T>
    {
        public SuccessResultWithData(T data, string message) : base(data, true, message) {}
        public SuccessResultWithData(T data) : base(data, true) {}
    }
}