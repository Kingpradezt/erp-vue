using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ERP.Inventory.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Just return some dummy users to test
            var users = new List<object> {
                new { Id = 1, Username = "user1" },
                new { Id = 2, Username = "user2" }
            };
            return Ok(users);
        }
        
    }
}
