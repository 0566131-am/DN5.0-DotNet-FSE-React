using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogAPI.Data;
using ProductCatalogAPI.Models;

namespace ProductCatalogAPI.Controllers
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

        // GET api/products
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_store.GetAll());
        }

        // GET api/products/5
        [HttpGet("{id:int}")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetById(int id)
        {
            var product = _store.GetById(id);
            if (product is null) return NotFound(new { message = $"Product {id} not found" });
            return Ok(product);
        }

        // POST api/products
        [HttpPost]
        [Authorize]
        [ProducesResponseType(typeof(Product), 201)]
        [ProducesResponseType(400)]
        public IActionResult Create([FromBody] Product product)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var created = _store.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // PUT api/products/5
        [HttpPut("{id:int}")]
        [Authorize]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Update(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var updated = _store.Update(id, product);
            if (!updated) return NotFound(new { message = $"Product {id} not found" });
            return NoContent();
        }

        // DELETE api/products/5
        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Delete(int id)
        {
            var deleted = _store.Delete(id);
            if (!deleted) return NotFound(new { message = $"Product {id} not found" });
            return NoContent();
        }
    }
}
