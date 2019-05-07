using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory.FactoryMethod
{
    public class ExpencesManagerFactory
    {
        public BaseVehicleFactory CreateFactory(VehicleExpences exp)
        {
            BaseVehicleFactory baseVehicleFactory = null;
            if(exp.VehicleType == "Car")
            {
                baseVehicleFactory =  new CarFactory(exp);
            }
            else if(exp.VehicleType == "Bike")
            {
                baseVehicleFactory = new BikeFactory(exp);
            }
            return baseVehicleFactory;
        }

    }
}
