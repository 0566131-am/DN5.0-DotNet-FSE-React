using ProductService.Models;

namespace ProductService.Data
{
    // Owns its own data — this is ProductService's private database in the exercise.
    public class ProductStore
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Wireless Mouse", Price = 599.00m, StockQuantity = 120 },
            new Product { Id = 2, Name = "Mechanical Keyboard", Price = 2499.00m, StockQuantity = 45 },
            new Product { Id = 3, Name = "USB-C Hub", Price = 1299.00m, StockQuantity = 0 }
        };

        public IEnumerable<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public bool ReduceStock(int id, int quantity)
        {
            var product = GetById(id);
            if (product is null || product.StockQuantity < quantity) return false;
            product.StockQuantity -= quantity;
            return true;
        }
    }
}
