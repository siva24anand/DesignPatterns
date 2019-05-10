using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory.CarLight
{
    public class Projector : ILight
    {
        public string LightInfo()
        {
            return "Projector";
        }
    }
}
