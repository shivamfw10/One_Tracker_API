using System;
using System.Collections.Generic;

namespace OneTracker.DataModel.Entities
{
    public partial class Status
    {
        public Status()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
