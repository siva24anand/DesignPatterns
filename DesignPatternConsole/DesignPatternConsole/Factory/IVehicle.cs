using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public interface IVehicle
    {
        void Drive(int miles);
        int FuelAmount { get;}
    }
}
