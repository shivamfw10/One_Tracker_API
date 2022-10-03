using System;
using System.Collections.Generic;

namespace OneTracker.DataModel.Entities
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; } = null!;
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
