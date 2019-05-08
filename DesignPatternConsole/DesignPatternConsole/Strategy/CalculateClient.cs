using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Strategy
{
    public class CalculateClient
    {
        private ICalculate _calculate;
        public CalculateClient(ICalculate calculate)
        {
            _calculate = calculate;
        }
        public int Execute(int value1, int value2)
        {
            return _calculate.Calculate(value1, value2);
        }
    }
}
