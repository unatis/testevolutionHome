using Microsoft.AspNetCore.Mvc;

namespace testevolutionHome.Controllers
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }  // Optional for registration
        public string Password { get; set; }
    }
    public class AuthController : Controller
    {
        private static List<User> _users = new(){new User { Username = "admin", Password = "123", Email = "admin@example.com" } };

        [HttpPost("/login")]
        public IActionResult Login(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                HttpContext.Session.SetString("user", username);
                return Redirect("/dashboard/index.html");
            }

            TempData["Error"] = "Invalid username or password.";
            return Redirect("/index.html");
        }

        [HttpPost("/register")]
        public IActionResult Register(string username, string email, string password)
        {
            if (_users.Any(u => u.Username == username))
            {
                TempData["Error"] = "Username already exists.";
                return Redirect("/index.html");
            }

            _users.Add(new User { Username = username, Email = email, Password = password });
            HttpContext.Session.SetString("user", username);
            return Redirect("/dashboard/index.html");
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return Redirect("/index.html");
        }
    }
}
