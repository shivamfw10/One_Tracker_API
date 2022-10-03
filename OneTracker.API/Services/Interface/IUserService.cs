using OneTracker.DataModel.Entities;
using OneTracker.ServiceModel.DTO.Response;

namespace OneTracker.API.Services.Interface
{
    public interface IUserService
    {
        List<UserDTO> GetAllUsers();
        Task<User> GetUserById(int id);
        int DeleteUser(int id);
    }
}
