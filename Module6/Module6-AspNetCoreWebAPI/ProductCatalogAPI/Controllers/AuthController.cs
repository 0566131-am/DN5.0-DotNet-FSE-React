using Microsoft.AspNetCore.Mvc;
using ProductCatalogAPI.Models;
using ProductCatalogAPI.Services;

namespace ProductCatalogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(JwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        // Demo credentials only — replace with real user store / Identity in production.
        // admin / password123  -> Role: Admin
        // user  / password123  -> Role: User
        [HttpPost("login")]
        [ProducesResponseType(typeof(LoginResponse), 200)]
        [ProducesResponseType(401)]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            string? role = (request.Username, request.Password) switch
            {
                ("admin", "password123") => "Admin",
                ("user", "password123") => "User",
                _ => null
            };

            if (role is null)
                return Unauthorized(new { message = "Invalid username or password" });

            var (token, expiresAt) = _jwtTokenService.GenerateToken(request.Username, role);
            return Ok(new LoginResponse { Token = token, ExpiresAt = expiresAt });
        }
    }
}
