using OrderService.Models;

namespace OrderService.Services
{
    // Owns its own data — OrderService's private database in the exercise.
    // It never reads or writes ProductService's data directly.
    public class OrderStore
    {
        private readonly List<Order> _orders = new();
        private int _nextId = 1;

        public IEnumerable<Order> GetAll() => _orders;

        public Order Add(Order order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
            return order;
        }
    }
}
