using OneTracker.API.Services.Interface;
using OneTracker.DataModel.Entities;
using OneTracker.DataModel.Repository.Interface;

namespace OneTracker.API.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public int DeleteTicket(int id)
        {
            return _ticketRepository.DeleteTicket(id);
        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
            return await _ticketRepository.GetAllTickets();
        }

        public async Task<Ticket> GetTicketById(int id)
        {
            return await _ticketRepository.GetTicketById(id);
        }
    }
}
