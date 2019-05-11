using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Observer
{
    public class Investor: IInvestor
    {
        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }

        public void Update(string stockName, double price)
        {
            Console.WriteLine("Notfied for investor: {0} | Stock: {1} Price: changed to {2}",_name,stockName,price);
            //Console.WriteLine($"Notfied for investor: {_name} | Stock: {stockName} Price: changed to {price}");
        }
    }
}
