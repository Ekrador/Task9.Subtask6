﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public override string Message => "This is My Exception";
    }
}
