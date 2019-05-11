using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    public static class AbstractFactory
    {
        public static void Execute()
        {
            var carDispatch = new CarDispatch();
            carDispatch.CreateCar("Swift");
            carDispatch.CreateCar("breeza");
            carDispatch.CreateCar("ciaz");
        }

    }
}
