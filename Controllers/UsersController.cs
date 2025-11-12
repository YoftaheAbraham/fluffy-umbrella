using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = new[] { "Alice", "Bob", "Charlie" };
            return Ok(users);
        }
    }
}
