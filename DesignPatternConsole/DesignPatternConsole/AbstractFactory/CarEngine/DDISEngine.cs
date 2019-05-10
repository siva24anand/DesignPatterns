using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory.CarEngine
{
    public class DDISEngine : IEngine
    {
        public string EngineInfo()
        {
            return "DDIS";
        }
    }
}
