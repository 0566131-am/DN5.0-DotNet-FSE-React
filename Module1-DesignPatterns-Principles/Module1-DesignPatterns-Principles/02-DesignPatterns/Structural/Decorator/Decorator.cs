// DECORATOR PATTERN
// Attaches additional responsibilities to an object dynamically,
// without modifying the original class or using inheritance explosion.
using System;

namespace Patterns.Structural.Decorator
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainCoffee : ICoffee
    {
        public string GetDescription() => "Coffee";
        public double GetCost() => 50.0;
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;
        protected CoffeeDecorator(ICoffee coffee) => _coffee = coffee;

        public abstract string GetDescription();
        public abstract double GetCost();
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => _coffee.GetDescription() + " + Milk";
        public override double GetCost() => _coffee.GetCost() + 10.0;
    }

    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }
        public override string GetDescription() => _coffee.GetDescription() + " + Sugar";
        public override double GetCost() => _coffee.GetCost() + 5.0;
    }

    class Program
    {
        static void Main()
        {
            ICoffee order = new PlainCoffee();
            order = new MilkDecorator(order);
            order = new SugarDecorator(order);

            Console.WriteLine($"{order.GetDescription()} costs Rs.{order.GetCost()}");
        }
    }
}
