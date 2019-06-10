using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Strategy
{
    public static class Strategy
    {
        public static void Execute()
        {
            var plusClient = new CalculateClient(new Plus());
            Console.WriteLine("Plus|(7+3): " + plusClient.Execute(7, 3));

            var minusClient = new CalculateClient(new Minus());
            Console.WriteLine("Minus|(7-3): " + minusClient.Execute(7, 3));

        }
    }
}
