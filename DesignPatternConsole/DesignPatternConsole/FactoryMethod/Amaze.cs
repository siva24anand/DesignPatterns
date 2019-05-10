using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    public class Amaze: IHonda
    {
        public string Name
        {
            get { return "Amaze"; }
        }
        public string Color
        {
            get { return "Red"; }
        }

        public int GetCarModel
        {
            get { return 2018; }
        }
    }
}
