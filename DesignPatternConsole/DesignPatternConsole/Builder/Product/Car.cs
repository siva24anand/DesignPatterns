using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder.Product
{
    public class Car
    {
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Tyre { get; set; }

        public Car()
        {

        }
        public void Show()
        {
            Console.WriteLine("Engine: " + Engine);
            Console.WriteLine("Transmission: " + Transmission);
            Console.WriteLine("Tyre: " + Tyre);
        }
    }
}
