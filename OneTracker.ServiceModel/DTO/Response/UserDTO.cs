
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTracker.ServiceModel.DTO.Response
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public string? UserImg { get; set; }
        public string RoleName { get; set; } = null!;
        public DateTime? JoiningDate { get; set; }


    }
}
