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
            return Ok(new { message = "Привет от ASP.NET Core Web API!" });
        }
    }
}
