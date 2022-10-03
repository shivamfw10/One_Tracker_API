using Microsoft.EntityFrameworkCore;
using OneTracker.DataModel.Entities;
using OneTracker.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTracker.DataModel.Repository
{
    public class TicketRepository : ITicketRepository
    {
        private readonly OneTrackerContext _oneTrackerContext;
        public TicketRepository(OneTrackerContext oneTrackerContext)
        {
            _oneTrackerContext = oneTrackerContext;
        }

        public int DeleteTicket(int id)
        {
            var data = _oneTrackerContext.Tickets.Find(id);
            if (data == null)
                return 0;
            else
                _oneTrackerContext.Tickets.Remove(data);
                _oneTrackerContext.SaveChanges();
            return 1;

        }

        public async Task<IEnumerable<Ticket>> GetAllTickets()
        {
           return await _oneTrackerContext.Tickets.ToListAsync();
        }

        public async Task<Ticket> GetTicketById(int id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Ticket ticket = await _oneTrackerContext.Tickets.FirstOrDefaultAsync(x => x.Ticketid == id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (ticket!=null)
            {
                _oneTrackerContext.Entry(ticket).State = EntityState.Detached;
                return ticket;
            }
            return null;
        }
    }
}
