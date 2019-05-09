using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Facade
{
    public class InventoryManager
    {
        public void Update()
        {
            Console.WriteLine("Product is subtracted from the store's inventory");
        }
    }

    public class OrderVerify
    {
        public void VerifyShippingAddress()
        {
            Console.WriteLine("The Product can be shipped to the pincode");
        }
    }

    public class CostManager
    {
        public void ApplyDiscount()
        {
            Console.WriteLine("A discount of 5 % is applied on the product");
        }
    }

    public class PaymentManager
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed");
        }
    }

    public class LogisticsManager
    {
        public void ShipProduct()
        {
            Console.WriteLine("Item has been shipped to the following address..");
        }
    }

}
