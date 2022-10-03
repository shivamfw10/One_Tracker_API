using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTracker.ServiceModel.DTO.Response
{
    public class TicketDTO
    {
        public int Ticketid { get; set; }
        public string CustName { get; set; } = null!;
        public string CustEmail { get; set; } = null!;
        public string EscEmail { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string IssueDesc { get; set; } = null!;
        public string Teamlink { get; set; } = null!;
        public int Department { get; set; }
   
    }
}
