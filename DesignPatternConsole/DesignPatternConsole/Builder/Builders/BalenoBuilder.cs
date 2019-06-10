using DesignPatternConsole.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    public class BalenoBuilder: ICarBuilder
    {
        Car car = new Car();
        public void SetEngine()
        {
            car.Engine = "DDIS";
        }

        public void SetTransmission()
        {
            car.Transmission = "Manual";
        }

        public void SetTyre()
        {
            car.Tyre = "Ceat";
        }
        public Car GetCar()
        {
            return car;
        }
    }
}
