using Microsoft.AspNetCore.Mvc;
using ProductService.Data;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductStore _store;

        public ProductsController(ProductStore store)
        {
            _store = store;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_store.GetAll());

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var product = _store.GetById(id);
            if (product is null) return NotFound(new { message = $"Product {id} not found" });
            return Ok(product);
        }

        // Called internally by OrderService to atomically check + reduce stock.
        [HttpPost("{id:int}/reserve")]
        public IActionResult ReserveStock(int id, [FromQuery] int quantity)
        {
            var product = _store.GetById(id);
            if (product is null) return NotFound(new { message = $"Product {id} not found" });

            var reserved = _store.ReduceStock(id, quantity);
            if (!reserved)
                return BadRequest(new { message = $"Insufficient stock for product {id}" });

            return Ok(new { message = "Stock reserved", productId = id, quantity });
        }
    }
}
