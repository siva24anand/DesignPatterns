using DesignPatternConsole.Factory.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public static class Factory
    {
        public static void Execute()
        {
            var exp = new VehicleExpences();
            var factoryMethod = true;
            if(factoryMethod)
            {
                exp.VehicleType = "Car";
                BaseVehicleFactory expFactory = new ExpencesManagerFactory().CreateFactory(exp);
                expFactory.GetExpeces();
                Console.WriteLine("VehicleType: " + exp.VehicleType + "| FuelAmount: " + exp.FuelAmount +
                    "| TollAmount: " + exp.TollAmount + "| HelmetAmount:" + exp.HelmetAmount);
            }
            else
            {
                VehicleFactory vehicleFactory = new ConcreateVehicleFactory();

                IVehicle bike = vehicleFactory.GetVehicle("Bike");
                bike.Drive(20);

                IVehicle car = vehicleFactory.GetVehicle("Car");
                car.Drive(50);
            }
            Console.ReadKey();
        }
    }
}
