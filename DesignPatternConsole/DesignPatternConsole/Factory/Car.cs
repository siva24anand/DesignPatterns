using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class Car : IVehicle
    {
        public int FuelAmount
        {
            get
            {
                return 70;
            }
        }

        public void Drive(int miles)
        {
            Console.WriteLine("Drive the car with: " + miles.ToString() + " miles");
        }

        public int TollAmount()
        {
            return 600;
        }

    }
}
