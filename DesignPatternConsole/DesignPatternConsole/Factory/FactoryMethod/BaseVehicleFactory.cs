using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory.FactoryMethod
{
    public abstract class BaseVehicleFactory
    {
        protected VehicleExpences _exp;
        public BaseVehicleFactory(VehicleExpences exp)
        {
            _exp = exp;
        }

        public VehicleExpences GetExpeces()
        {
            IVehicle vehicle =  this.Create();
            _exp.FuelAmount = vehicle.FuelAmount;
            return _exp;
        }
        public abstract IVehicle Create();
    }
}
