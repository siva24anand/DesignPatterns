using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    public class City : IHonda
    {
        public string Name
        {
            get { return "City"; }
        }
        public string Color
        {
            get { return "White"; }
        }

        public int GetCarModel
        {
            get { return 2015; }
        }
    }
}
