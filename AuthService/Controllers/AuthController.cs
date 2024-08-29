using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Jija");
        }
    }
}
