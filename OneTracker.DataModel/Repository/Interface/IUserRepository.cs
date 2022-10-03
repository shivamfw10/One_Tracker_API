using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneTracker.DataModel.Entities;
using OneTracker.ServiceModel.DTO.Response;

namespace OneTracker.DataModel.Repository.Interface
{
    public interface IUserRepository
    {
        List<UserDTO> GetAllUsers();
        Task<User> GetTicketById(int id);
        //User GetUserById(int id);
        int DeleteUser(int id);
    }
}
