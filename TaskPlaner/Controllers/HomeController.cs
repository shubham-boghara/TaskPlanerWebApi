using Microsoft.AspNetCore.Mvc;

namespace TaskPlaner.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Welcome Shubham");
        }
    }
}