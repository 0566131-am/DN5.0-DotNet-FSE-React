// DEPENDENCY INJECTION (DI)
// Instead of a class creating its own dependencies, they are "injected" from
// the outside (constructor injection shown here), making code loosely coupled
// and easy to unit test (you can inject a mock/fake in tests).
using System;

namespace Patterns.Architectural.DependencyInjection
{
    public interface IDiscountService
    {
        double ApplyDiscount(double amount);
    }

    public class FestiveDiscountService : IDiscountService
    {
        public double ApplyDiscount(double amount) => amount * 0.9; // 10% off
    }

    public class NoDiscountService : IDiscountService
    {
        public double ApplyDiscount(double amount) => amount;
    }

    public class OrderService
    {
        private readonly IDiscountService _discountService;

        // Constructor Injection - the dependency is provided, not created internally
        public OrderService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public void PlaceOrder(double amount)
        {
            double finalAmount = _discountService.ApplyDiscount(amount);
            Console.WriteLine($"Order placed. Amount payable: Rs.{finalAmount}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Plug in whichever discount strategy is needed, without modifying OrderService.
            var festiveOrder = new OrderService(new FestiveDiscountService());
            festiveOrder.PlaceOrder(1000);

            var regularOrder = new OrderService(new NoDiscountService());
            regularOrder.PlaceOrder(1000);
        }
    }
}
