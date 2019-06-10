using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Observer
{
    public static class Observer
    {
        public static void Execute()
        {
            var ibm = new Company("IBM", 243.48);
            ibm.Attach(new Investor("Investor1"));
            ibm.Attach(new Investor("Investor2"));

            ibm.Price = 205.487;
            ibm.Price = 348.57;
            ibm.Price = 455.37;
            ibm.Price = 105.36;
            ibm.Attach(new Investor("Investor3"));
            ibm.Price = 543.33;
            ibm.Detach(new Investor("Investor2"));
            ibm.Price = 643.33;
            ibm.Attach(new Investor("Investor4"));
            ibm.Price = 743.33;

        }
    }
}
