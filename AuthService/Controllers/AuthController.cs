using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthService.Data;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TestController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("test-db")]
        public async Task<IActionResult> TestDbConnection()
        {
            try
            {
                var count = await _context.Users.CountAsync();
                return Ok(new { Message = "Database connection is successful", EntityCount = count });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Database connection failed", Error = ex.Message });
            }
        }
    }
}
