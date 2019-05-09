using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Observer
{
    public interface IInvestor
    {
        void Update(string stockName, double price);
        string Name { get; }
    }
}
