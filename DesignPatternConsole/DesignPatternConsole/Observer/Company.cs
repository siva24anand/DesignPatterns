﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Observer
{
    public class Company : Stock
    {
        public Company(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
