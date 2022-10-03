using System;
using System.Collections.Generic;

namespace OneTracker.DataModel.Entities
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
            Tickets = new HashSet<Ticket>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
