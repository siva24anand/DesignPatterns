using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Facade
{
    public static class Facade
    {
        public static void Execute()
        {
            var onlineFacade = new OnlineShoppingFacade();
            Console.WriteLine("Placing an order in normal days..");
            Console.WriteLine("==================================");
            onlineFacade.PlaceOrder();
            Console.WriteLine();
            Console.WriteLine("Placing an order in festive days..");
            Console.WriteLine("==================================");
            onlineFacade.PlaceOrderinSuperSale();
        }
    }
}
