using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Services;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderStore _orderStore;
        private readonly ProductServiceClient _productServiceClient;

        public OrdersController(OrderStore orderStore, ProductServiceClient productServiceClient)
        {
            _orderStore = orderStore;
            _productServiceClient = productServiceClient;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_orderStore.GetAll());

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateOrderRequest request)
        {
            if (request.Quantity <= 0)
                return BadRequest(new { message = "Quantity must be greater than zero" });

            // Inter-service call #1: does the product exist?
            var product = await _productServiceClient.GetProductAsync(request.ProductId);
            if (product is null)
                return NotFound(new { message = $"Product {request.ProductId} not found in ProductService" });

            if (product.StockQuantity < request.Quantity)
                return BadRequest(new { message = $"Insufficient stock: only {product.StockQuantity} left" });

            // Inter-service call #2: reserve the stock on ProductService.
            var reserved = await _productServiceClient.ReserveStockAsync(request.ProductId, request.Quantity);
            if (!reserved)
                return BadRequest(new { message = "Could not reserve stock — it may have just sold out" });

            var order = _orderStore.Add(new Order
            {
                ProductId = product.Id,
                ProductName = product.Name,
                Quantity = request.Quantity,
                TotalPrice = product.Price * request.Quantity
            });

            return CreatedAtAction(nameof(GetAll), new { }, order);
        }
    }
}
