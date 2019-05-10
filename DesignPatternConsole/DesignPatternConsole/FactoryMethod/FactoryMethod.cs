using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.FactoryMethod
{
    public static class FactoryMethod
    {
        public static void Execute()
        {
            var hondaFactory = new HondaFactory();
            IHonda hondaCity = hondaFactory.GetVehicleDetails("City");
            Console.WriteLine($"Car Details: Name: {hondaCity.Name}, Model: {hondaCity.GetCarModel}, Color: {hondaCity.Color}");
            IHonda hondaAmaze = hondaFactory.GetVehicleDetails("Amaze");
            Console.WriteLine($"Car Details: Name: {hondaAmaze.Name}, Model: {hondaAmaze.GetCarModel}, Color: {hondaAmaze.Color}");
            IHonda hondaCivic = hondaFactory.GetVehicleDetails("Civic");
            Console.WriteLine($"Car Details: Name: {hondaCivic.Name}, Model: {hondaCivic.GetCarModel}, Color: {hondaCivic.Color}");
            Console.ReadLine();
        }
    }
}
