using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneTracker.DataModel.Entities
{
    public partial class Ticket
    {
        
        public int Ticketid { get; set; }
        public string CustName { get; set; } = null!;
        public string CustEmail { get; set; } = null!;
        public string EscEmail { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string IssueDesc { get; set; } = null!;
        public string Teamlink { get; set; } = null!;
        public int Department { get; set; }
        public DateTime? Modification { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public DateTime? IssueDate { get; set; }
        public int Category { get; set; }
        public int Subcategory { get; set; }

        public virtual Category CategoryNavigation { get; set; } = null!;
        public virtual Department DepartmentNavigation { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual SubCategory SubcategoryNavigation { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
