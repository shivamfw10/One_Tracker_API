using OneTracker.DataModel.Entities;

namespace OneTracker.API.Services.Interface
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetAllTickets();
        Task<Ticket> GetTicketById(int id);
        int DeleteTicket(int id);
    }
}
