using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ResultWithData<T> : Result, IResultWithData<T>
    {

        public ResultWithData(T data, bool isSucceed, string message) : base(isSucceed, message) {
            Data = data;
        }

        public ResultWithData(T data, bool isSucceed) : base(isSucceed) {
            Data = data;
        }

        public T Data { get; }
    }
}