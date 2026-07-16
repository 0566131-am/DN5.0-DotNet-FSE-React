// STRATEGY PATTERN
// Defines a family of interchangeable algorithms and lets the client
// choose/swap the algorithm (strategy) at runtime.
using System;

namespace Patterns.Behavioral.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(double amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount) =>
            Console.WriteLine($"Paid Rs.{amount} using Credit Card.");
    }

    public class UpiPayment : IPaymentStrategy
    {
        public void Pay(double amount) =>
            Console.WriteLine($"Paid Rs.{amount} using UPI.");
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount) =>
            Console.WriteLine($"Paid Rs.{amount} using PayPal.");
    }

    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public ShoppingCart(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        // Strategy can be swapped at runtime
        public void SetPaymentStrategy(IPaymentStrategy strategy) => _paymentStrategy = strategy;

        public void Checkout(double amount) => _paymentStrategy.Pay(amount);
    }

    class Program
    {
        static void Main()
        {
            var cart = new ShoppingCart(new CreditCardPayment());
            cart.Checkout(1200);

            cart.SetPaymentStrategy(new UpiPayment());
            cart.Checkout(450);

            cart.SetPaymentStrategy(new PayPalPayment());
            cart.Checkout(899);
        }
    }
}
