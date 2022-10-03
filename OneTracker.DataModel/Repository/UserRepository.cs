using OneTracker.DataModel.Entities;
using OneTracker.DataModel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneTracker.ServiceModel.DTO.Response;

namespace OneTracker.DataModel.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly OneTrackerContext _context;
        public UserRepository(OneTrackerContext oneTrackerContext)
        { 
            _context = oneTrackerContext;
        }

        public int DeleteUser(int id)
        {
            var data = _context.Users.Find(id);
            if(data == null)
                return 0;
            else
                _context.Users.Remove(data);    
            _context.SaveChanges();
            return 1;
        }

        public List<UserDTO> GetAllUsers()
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            var userList = (from u in _context.Users
                            join r in _context.Roles on u.RoleId equals r.RoleId
                            select new UserDTO
                            {
                                UserId = u.UserId,
                                FirstName = u.FirstName,
                                LastName = u.LastName,
                                RoleName=r.RoleName
                           
                            }).ToList();
#pragma warning restore CS8601 // Possible null reference assignment.
            return userList;
        }

        public async Task<User> GetTicketById(int id)
        {
            User user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (user!= null)
            {
                _context.Entry(user).State = EntityState.Detached;
#pragma warning disable CS8603 // Possible null reference return.
                return user;
#pragma warning restore CS8603 // Possible null reference return.
            }
            return null;
        }

        

    }
}
