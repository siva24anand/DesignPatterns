using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Strategy
{
    public class Minus : ICalculate
    {
        public int Calculate(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
