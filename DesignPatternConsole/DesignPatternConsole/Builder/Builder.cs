using DesignPatternConsole.Builder.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Builder
{
    public static class Builder
    {
        public static void Execute()
        {
            var carCreator = new CarCreator(new SwiftBuilder());
            carCreator.CreateCar();
            carCreator.GetCar().Show();
            Console.WriteLine("----------------------------------------");
            
            carCreator = new CarCreator(new BalenoBuilder());
            carCreator.CreateCar();
            carCreator.GetCar().Show();
            Console.WriteLine("----------------------------------------");

            carCreator = new CarCreator(new CiazBuilder());
            carCreator.CreateCar();
            carCreator.GetCar().Show();
            Console.WriteLine("----------------------------------------");

        }
    }
}
