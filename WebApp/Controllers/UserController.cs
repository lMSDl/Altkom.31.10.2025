using Microsoft.AspNetCore.Mvc;
using WebApp.Services;
using WebApp.Models;

namespace WebApp.Controllers
{
 [ApiController]
 [Route("api/[controller]")]
 public class UserController : ControllerBase
 {
 private readonly UserService _userService;

 public UserController(UserService userService)
 {
 _userService = userService;
 }

 [HttpPost("add")]
 public IActionResult AddUser([FromQuery] string name, [FromQuery] string password)
 {
 var user = new User { Name = name, Password = password };
 _userService.AddUser(user);
 // Set a cookie for demonstration
 Response.Cookies.Append("LastUserAdded", name);
 return Ok($"User added: {name}");
 }

 [HttpDelete("remove")]
 public IActionResult RemoveUser([FromQuery] string name)
 {
 var result = _userService.RemoveUser(name);
 return result ? Ok($"User removed: {name}") : NotFound();
 }

 [HttpGet("get")]
 public IActionResult GetUserByIndex([FromQuery] int index)
 {
 try
 {
 var user = _userService.GetUserByIndex(index);
 return Ok(user.Name);
 }
 catch (ArgumentOutOfRangeException)
 {
 return NotFound();
 }
 }
 }
}
