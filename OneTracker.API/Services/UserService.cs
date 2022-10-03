using OneTracker.API.Services.Interface;
using OneTracker.DataModel.Entities;
using OneTracker.DataModel.Repository.Interface;
using OneTracker.ServiceModel.DTO.Response;

namespace OneTracker.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRespository;
        public UserService(IUserRepository userRepository)
        {
            _userRespository = userRepository;
        }

        public int DeleteUser(int id)
        {
            return _userRespository.DeleteUser(id);
        }

        public List<UserDTO> GetAllUsers()
        {
            return _userRespository.GetAllUsers();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRespository.GetTicketById(id);
        }
    }
}
