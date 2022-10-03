using OneTracker.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTracker.DataModel.Repository.Interface
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetAllTickets();
        Task<Ticket> GetTicketById(int id);
        int DeleteTicket(int id); 
    }
}
