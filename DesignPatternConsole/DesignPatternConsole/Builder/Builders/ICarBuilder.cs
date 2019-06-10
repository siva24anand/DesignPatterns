using DesignPatternConsole.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    public interface ICarBuilder
    {
        void SetEngine();
        void SetTransmission();
        void SetTyre();

        Car GetCar();
    }
}
