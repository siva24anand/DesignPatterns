using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory.CarTyre
{
    public class Apollo : ITyre
    {
        public string TyreInfo()
        {
            return "Apollo";
        }
    }
}
