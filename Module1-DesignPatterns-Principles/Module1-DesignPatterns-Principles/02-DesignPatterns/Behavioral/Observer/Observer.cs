// OBSERVER PATTERN
// Defines a one-to-many dependency: when the Subject's state changes,
// all registered Observers are notified automatically.
using System;
using System.Collections.Generic;

namespace Patterns.Behavioral.Observer
{
    public interface IInvestor
    {
        void Update(string stockSymbol, double price);
    }

    public class Stock
    {
        private readonly List<IInvestor> _investors = new();
        public string Symbol { get; }
        private double _price;

        public Stock(string symbol, double initialPrice)
        {
            Symbol = symbol;
            _price = initialPrice;
        }

        public void Subscribe(IInvestor investor) => _investors.Add(investor);
        public void Unsubscribe(IInvestor investor) => _investors.Remove(investor);

        public void SetPrice(double newPrice)
        {
            _price = newPrice;
            NotifyInvestors();
        }

        private void NotifyInvestors()
        {
            foreach (var investor in _investors)
                investor.Update(Symbol, _price);
        }
    }

    public class Investor : IInvestor
    {
        private readonly string _name;
        public Investor(string name) => _name = name;

        public void Update(string stockSymbol, double price) =>
            Console.WriteLine($"{_name} notified: {stockSymbol} is now Rs.{price}");
    }

    class Program
    {
        static void Main()
        {
            var stock = new Stock("INFY", 1500);

            var investor1 = new Investor("Mubeena");
            var investor2 = new Investor("Rahul");

            stock.Subscribe(investor1);
            stock.Subscribe(investor2);

            stock.SetPrice(1550); // Both investors get notified
            stock.Unsubscribe(investor2);
            stock.SetPrice(1600); // Only investor1 gets notified
        }
    }
}
