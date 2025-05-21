using Microsoft.AspNetCore.Mvc;
using ERP.Inventory.API.Services;
using ERP.Inventory.API.Models;
using System.Linq.Expressions;

namespace ERP.Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly BaseService _baseService;

        public AuthController(BaseService baseService)
        {
            _baseService = baseService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            Console.WriteLine($"Login attempt: Username={request?.Username}, Password={request?.Password}");

            // Basic validation
            if (request == null || string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            {
                Console.WriteLine("Invalid credentials: missing username or password.");
                return BadRequest("Invalid credentials.");
            }

            // Query to find user by username and password hash
            // Make sure _baseService.ListOfTable accepts Expression<Func<T,bool>>
            Expression<Func<AppUser, bool>> predicate = u => u.Username == request.Username && u.PasswordHash == request.Password;

            var users = await _baseService.ListOfTable(predicate);

            Console.WriteLine($"Users found with matching credentials: {users.Count}");

            if (users.Any())
            {
                var user = users.First();

                Console.WriteLine($"Login successful for user: {user.Username}");

                return Ok(new
                {
                    message = "Login successful",
                    user.UserId,
                    user.Username,
                    user.FullName,
                });
            }

            Console.WriteLine("Login failed: invalid username or password.");
            return Unauthorized("Invalid username or password.");
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
