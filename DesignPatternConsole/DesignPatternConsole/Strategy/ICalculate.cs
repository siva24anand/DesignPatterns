﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Strategy
{
    public interface ICalculate
    {
        int Calculate(int value1, int value2);
    }
}
