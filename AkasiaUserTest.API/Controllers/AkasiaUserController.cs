using AkasiaUserTest.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkasiaUserTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AkasiaUserController : ControllerBase
    {
        // List Data
        private readonly List<User> _users = new List<User>
        {
            new User { id = 1, name = "John Doe", email = "john@example.com", created_at = DateTime.Parse("2024-01-01T12:00:00") },
            new User { id = 2, name = "Jane Smith", email = "jane@example.com", created_at = DateTime.Parse("2024-02-01T15:30:00") },
            new User { id = 3, name = "Alice Johnson", email = "alice@example.com", created_at = DateTime.Parse("2024-03-01T10:20:00") }
        };

        // Endpoint GET /api/users
        [HttpGet]
        public IActionResult GetUsers()
        {
            var response = new
            {
                status = "success",
                data = _users
            };
            return Ok(response);
        }
    }
}
