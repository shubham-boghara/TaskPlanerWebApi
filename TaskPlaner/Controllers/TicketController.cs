using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskPlaner.Models;

namespace TaskPlaner.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TicketController : Controller
    {
        [HttpGet]
        [Route("/api/getAllTickets/{projectId}")]
        public IActionResult Index([FromRoute] string projectId, [FromQuery] string order = "asc")
        {
            return Ok("All tickets");
        }

        [HttpGet]
        [Route("/api/getSingleTicket/{ticketId}")]
        public IActionResult Details()
        {
            return Ok("ticket details");
        }

        [HttpPost]
        [Route("/api/addTicket")]
        public IActionResult Add([FromBody] Ticket ticket)
        {
            return Ok("ticket added");
        }

        [HttpPut]
        [Route("/api/updateTicket")]
        public IActionResult Update([FromBody] Ticket ticket)
        {
            return Ok("ticket updated");
        }

        [HttpDelete("/api/deleteTicket/{ticketId}")]
        public IActionResult Delete([FromRoute] string ticketId)
        {
            return Ok("ticket deleted");
        }
    }
}
