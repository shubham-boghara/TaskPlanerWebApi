using Microsoft.AspNetCore.Mvc;
using TaskPlaner.Models;

namespace TaskPlaner.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProjectController : Controller
    {
        [HttpGet]
        [Route("/api/getAllProjects")]
        public IActionResult Index([FromQuery] string order = "asc")
        {
            return Ok("project created");
        }

        [HttpGet]
        [Route("/api/getSingleProject/{projectId}")]
        public IActionResult Details([FromRoute] string projectId)
        {
            return Ok("project details");
        }

        [HttpPost]
        [Route("/api/addProject")]
        public IActionResult Add([FromBody] Project project)
        {
            return Ok("project added");
        }

        [HttpPost]
        [Route("/api/updateProject")]
        public IActionResult Update([FromBody] Project project)
        {
            return Ok("project updated");
        }

        [HttpPut]
        [Route("/api/deleteProject/{projectId}")]
        public IActionResult Delete([FromRoute] string projectId)
        {
            return Ok("project deleted");
        }
    }
}
