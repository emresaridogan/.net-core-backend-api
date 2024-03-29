﻿using Northwind.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        private IDataResult<User> userToCheck;
        private object successfulLogin;

        public SuccessDataResult(T data, string message) : base(data,true,message)
        {

        }

        public SuccessDataResult(T data) : base(data,true)
        {

        }

        public SuccessDataResult(string message) : base(default,true,message)
        {

        }

        public SuccessDataResult() : base(default,true)
        {

        }

    }
}
