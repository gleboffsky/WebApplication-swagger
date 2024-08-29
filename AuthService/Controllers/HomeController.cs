using AuthService.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStringService _stringService;
        public HomeController(IStringService stringService) 
        {
            _stringService = stringService;
        }
        [HttpGet("Index")]
        public IActionResult Index(int a = 0)
        {
            var value = _stringService.GetInt(a);
            return Ok("Index" + value);
        }
        [HttpGet]
        public IActionResult Get() 
        {
            var jija = _stringService.GetString();
            return Ok(jija);
        }
    }
}

