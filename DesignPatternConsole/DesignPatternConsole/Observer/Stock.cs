using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Observer
{
    public abstract class Stock
    {
        private readonly string _stockName;
        private double _price;

        private List<IInvestor> _investors = new List<IInvestor>();

        public Stock(string stockName, double price)
        {
            _stockName = stockName;
            _price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }
        public void Detach(IInvestor investor)
        {
            _investors.RemoveAll(i => i.Name == investor.Name);
        }
        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(StockName, Price);
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if(_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string StockName
        {
            get
            {
                return _stockName;
            }
        }

    }
}
