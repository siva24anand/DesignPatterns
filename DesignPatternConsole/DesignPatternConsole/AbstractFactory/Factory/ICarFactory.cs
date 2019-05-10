using DesignPatternConsole.AbstractFactory.CarEngine;
using DesignPatternConsole.AbstractFactory.CarLight;
using DesignPatternConsole.AbstractFactory.CarTyre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    public interface ICarFactory
    {
        IEngine GetEngine();
        ILight GetLight();
        ITyre GetTyre();
    }
}
