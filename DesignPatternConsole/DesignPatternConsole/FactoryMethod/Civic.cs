using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    public class Civic: IHonda
    {
        public string Name
        {
            get { return "Civi"; }
        }
        public string Color
        {
            get { return "Silver"; }
        }

        public int GetCarModel
        {
            get { return 2010; }
        }
    }
}
