using System;
using System.Collections.Generic;

namespace OneTracker.DataModel.Entities
{
    public partial class Department
    {
        public Department()
        {
            Categories = new HashSet<Category>();
            Tickets = new HashSet<Ticket>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
