using Microsoft.AspNetCore.Mvc;
using OneTracker.API.Services.Interface;
using OneTracker.DataModel.Entities;

namespace OneTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController:Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetAllTickets()
        {
            var tickets = await _ticketService.GetAllTickets();
            if(tickets == null)
                return NotFound("No Tickets");
            else
                return Ok(tickets);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTickets(int id)
        {
            var ticket = await _ticketService.GetTicketById(id);
            if (ticket == null)
                return NotFound("No User Registered with supplied ID");
            else
                return Ok(ticket);
        }
        [HttpDelete]
        public Task<int> DeleteTickets(int id)
        {
            var data = _ticketService.DeleteTicket(id);
            if (data == null)
                return 0;
            else
                return 1;
        }

    }
}
