﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message) // base olunca Result sınıfındaki metotlara gönderir. 
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
