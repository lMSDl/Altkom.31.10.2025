using WebApp.Models;
using WebApp.Services;

namespace WebApp.Auth
{
 public class AuthService
 {
 private readonly UserService _userService;

 public AuthService(UserService userService)
 {
 _userService = userService;
 }

 public bool Authenticate(string name, string password)
 {
 var user = _userService.GetAllUsers().FirstOrDefault(u => u.Name == name && u.Password == password);
 return user != null;
 }
 }
}
