using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Facade
{ 
    public class OnlineShoppingFacade
    {
        private InventoryManager _inventoryManager;
        private OrderVerify _orderVerify;
        private CostManager _costManager;
        private PaymentManager _paymentManager;
        private LogisticsManager _logisticsManager;

        public void PlaceOrder()
        {
            _inventoryManager = new InventoryManager();
            _orderVerify = new OrderVerify();
            _paymentManager = new PaymentManager();
            _logisticsManager = new LogisticsManager();
            _inventoryManager.Update();
            _orderVerify.VerifyShippingAddress();
            _paymentManager.ProcessPayment();
            _logisticsManager.ShipProduct();
        }

        public void PlaceOrderinSuperSale()
        {
            _inventoryManager = new InventoryManager();
            _orderVerify = new OrderVerify();
            _costManager = new CostManager();
            _paymentManager = new PaymentManager();
            _logisticsManager = new LogisticsManager();
            _inventoryManager.Update();
            _orderVerify.VerifyShippingAddress();
            _costManager.ApplyDiscount();
            _paymentManager.ProcessPayment();
            _logisticsManager.ShipProduct();
        }

    }
}
