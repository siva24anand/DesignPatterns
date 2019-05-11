using DesignPatternConsole.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder.Director
{
    public class CarCreator
    {
        private readonly ICarBuilder _carBuilder;
        public CarCreator(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }
        public void CreateCar()
        {
            _carBuilder.SetEngine();
            _carBuilder.SetTransmission();
            _carBuilder.SetTyre();
        }
        public Car GetCar()
        {
            return _carBuilder.GetCar();
        }
    }
}
