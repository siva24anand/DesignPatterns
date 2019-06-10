using DesignPatternConsole.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    public class SwiftBuilder: ICarBuilder
    {
        Car car = new Car();
        public void SetEngine()
        {
            car.Engine = "VVT";
        }

        public void SetTransmission()
        {
            car.Transmission = "AMT";
        }

        public void SetTyre()
        {
            car.Tyre = "Apollo";
        }
        public Car GetCar()
        {
            return car;
        }
    }
}
