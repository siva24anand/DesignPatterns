using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.AbstractFactory
{
    public class CarDispatch
    {
        private ICarFactory _carFactory = null;
        public void CreateCar(string carName)
        {
            if(carName.ToLower() == "swift")
                _carFactory = new SwiftCarFactory();
            else if(carName.ToLower() == "breeza")
                _carFactory = new BreezaCarFactory();
            else if(carName.ToLower() == "ciaz")
                _carFactory = new CiazCarFactory();

            //Console.WriteLine($"{carName} Details:  Engine: {_carFactory.GetEngine().EngineInfo()}, Light: {_carFactory.GetLight().LightInfo()}," +
            //    $" Tyre: {_carFactory.GetTyre().TyreInfo()}");

            Console.WriteLine("{0} Details:  Engine: {1}, Light: {2}, Tyre: {3}", carName, _carFactory.GetEngine().EngineInfo(), _carFactory.GetLight().LightInfo(), _carFactory.GetTyre().TyreInfo());
        }
    }
}
