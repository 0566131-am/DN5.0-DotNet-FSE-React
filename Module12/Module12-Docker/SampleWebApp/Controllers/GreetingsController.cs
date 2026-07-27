using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from inside a Docker container!" });
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(new { message = $"Hello, {name}, from inside a Docker container!" });
        }
    }
}
