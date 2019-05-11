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
            //Console.WriteLine($"Car Details: Name: {hondaCity.Name}, Model: {hondaCity.GetCarModel}, Color: {hondaCity.Color}");
            Console.WriteLine("Car Details: Name: {0}, Model: {1}, Color: {2}",hondaCity.Name,hondaCity.GetCarModel,hondaCity.Color);
            IHonda hondaAmaze = hondaFactory.GetVehicleDetails("Amaze");
            //Console.WriteLine($"Car Details: Name: {hondaAmaze.Name}, Model: {hondaAmaze.GetCarModel}, Color: {hondaAmaze.Color}");
            Console.WriteLine("Car Details: Name: {0}, Model: {1}, Color: {2}", hondaAmaze.Name, hondaAmaze.GetCarModel, hondaAmaze.Color);
            IHonda hondaCivic = hondaFactory.GetVehicleDetails("Civic");
            //Console.WriteLine($"Car Details: Name: {hondaCivic.Name}, Model: {hondaCivic.GetCarModel}, Color: {hondaCivic.Color}");
            Console.WriteLine("Car Details: Name: {0}, Model: {1}, Color: {2}", hondaCivic.Name, hondaCivic.GetCarModel, hondaCivic.Color);
            Console.ReadLine();
        }
    }
}
