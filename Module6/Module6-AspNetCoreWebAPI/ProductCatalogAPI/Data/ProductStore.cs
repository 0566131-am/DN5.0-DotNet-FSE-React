using ProductCatalogAPI.Models;

namespace ProductCatalogAPI.Data
{
    // Simple in-memory store so the exercise runs with zero DB setup.
    // Swap this out for EF Core + SQL Server if you want to combine it with Module 5.
    public class ProductStore
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Wireless Mouse", Price = 599.00m, Description = "Ergonomic wireless mouse", StockQuantity = 120 },
            new Product { Id = 2, Name = "Mechanical Keyboard", Price = 2499.00m, Description = "RGB backlit mechanical keyboard", StockQuantity = 45 },
            new Product { Id = 3, Name = "USB-C Hub", Price = 1299.00m, Description = "7-in-1 USB-C hub", StockQuantity = 80 }
        };

        private int _nextId = 4;

        public IEnumerable<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }

        public bool Update(int id, Product updated)
        {
            var existing = GetById(id);
            if (existing is null) return false;

            existing.Name = updated.Name;
            existing.Price = updated.Price;
            existing.Description = updated.Description;
            existing.StockQuantity = updated.StockQuantity;
            return true;
        }

        public bool Delete(int id)
        {
            var existing = GetById(id);
            if (existing is null) return false;
            _products.Remove(existing);
            return true;
        }
    }
}
