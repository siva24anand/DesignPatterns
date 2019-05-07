using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory.FactoryMethod
{
    public class CarFactory : BaseVehicleFactory
    {
        public CarFactory(VehicleExpences exp) : base(exp)
        {
        }

        public override IVehicle Create()
        {
            var car = new Car();
            _exp.TollAmount = car.TollAmount();
            return car;
        }
    }
}
