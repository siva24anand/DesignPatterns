using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternConsole.AbstractFactory.CarEngine;
using DesignPatternConsole.AbstractFactory.CarLight;
using DesignPatternConsole.AbstractFactory.CarTyre;

namespace DesignPatternConsole.AbstractFactory
{
    public class SwiftCarFactory : ICarFactory
    {
        public IEngine GetEngine()
        {
            return new VVTEngine();
        }

        public ILight GetLight()
        {
            return new LED();
        }

        public ITyre GetTyre()
        {
            return new Apollo();
        }
    }
}
