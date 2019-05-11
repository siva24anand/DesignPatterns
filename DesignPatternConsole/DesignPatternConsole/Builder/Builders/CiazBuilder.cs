using DesignPatternConsole.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    public class CiazBuilder: ICarBuilder
    {
        Car car = new Car();
        public void SetEngine()
        {
            car.Engine = "VVT";
        }

        public void SetTransmission()
        {
            car.Transmission = "AT";
        }

        public void SetTyre()
        {
            car.Tyre = "Michelin";
        }
        public Car GetCar()
        {
            return car;
        }
    }
}
