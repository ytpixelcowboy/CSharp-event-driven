﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class StringFormatException : Exception
    {
        public StringFormatException(string msg) : base(msg) { }
    }
}
