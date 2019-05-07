using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Factory
{
    public class Bike : IVehicle
    {
        public int FuelAmount
        {
            get
            {
                return 76;
            }
        }

        public void Drive(int miles)
        {
            Console.WriteLine("Drive the bike with: " + miles.ToString()+ " miles");
        }

        public int HelmetAmount()
        {
            return 1000;
        }
    }
}
