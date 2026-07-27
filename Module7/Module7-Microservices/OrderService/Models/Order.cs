namespace OrderService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public class CreateOrderRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    // Mirrors the shape ProductService returns — a lightweight DTO,
    // not a shared library, to keep the two services independently deployable.
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
