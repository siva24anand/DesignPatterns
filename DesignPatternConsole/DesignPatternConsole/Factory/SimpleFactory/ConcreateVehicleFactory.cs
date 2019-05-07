using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class ConcreateVehicleFactory : VehicleFactory
    {
        public override IVehicle GetVehicle(string Vehicle)
        {
            switch(Vehicle)
            {
                case "Bike": return new Bike();
                case "Car": return new Car();
                default: throw new Exception(Vehicle + " cannot created");
            }
                

        }
    }
}
