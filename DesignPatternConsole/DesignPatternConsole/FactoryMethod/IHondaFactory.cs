using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    public interface IHondaFactory
    {
        IHonda GetVehicleDetails(string CarName);
    }
}
