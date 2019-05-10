using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    public class HondaFactory : IHondaFactory
    {
        public IHonda GetVehicleDetails(string CarName)
        {
            switch(CarName)
            {
                case "City":return new City();
                case "Amaze": return new Amaze();
                case "Civic": return new Civic();
                default: return null;
            }
        }
    }
}
