using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory.FactoryMethod
{
    public class BikeFactory : BaseVehicleFactory
    {
        public BikeFactory(VehicleExpences exp) : base(exp)
        {
        }

        public override IVehicle Create()
        {
            var bike = new Bike();
            _exp.HelmetAmount = bike.HelmetAmount();
            return bike;
        }
    }
}
