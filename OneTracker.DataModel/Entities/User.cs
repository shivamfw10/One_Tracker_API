using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneTracker.DataModel.Entities
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public string? UserImg { get; set; }
        public DateTime? JoiningDate { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
