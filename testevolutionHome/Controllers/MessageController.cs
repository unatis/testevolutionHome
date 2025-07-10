using Microsoft.AspNetCore.Mvc;

namespace testevolutionHome.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            //var loggedInUser = HttpContext.Session.GetString("user");

            //if (string.IsNullOrEmpty(loggedInUser))
            //{
            //    return Redirect("/index.html");
            //}

            return Ok(new { message = "Привет от ASP.NET Core Web API!" });
        }
    }
}
