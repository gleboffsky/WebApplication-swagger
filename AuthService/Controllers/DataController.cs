using AuthService.Models;
using AuthService.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IUserService _userService;
        public DataController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("Get")]
        public IActionResult Get()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
        [HttpPost("Create")]
        public IActionResult Create(User user)
        {
            _userService.CreateUser(user);
            return Ok("Success Create");
        }
        [HttpPut("Update")]
        public IActionResult Update(User user)
        {
            _userService.UpdateUser(user);
            return Ok("Success Update");
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            _userService.DeleteUser(id);
            return Ok("Success Delete");
        }
    }
}
