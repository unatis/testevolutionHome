using Microsoft.AspNetCore.Mvc;

namespace testevolutionHome.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost("/login")]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                // Перенаправление на панель
                return Redirect("/dashboard/index.html");
            }

            // Можно передавать ошибку через TempData, ViewData и т.п.
            return Redirect("/index.html");
        }
    }
}
