using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OneTracker.API.Services.Interface;
using OneTracker.DataModel.Entities;
using OneTracker.ServiceModel.DTO.Response;

namespace OneTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public ActionResult <List<UserDTO>> GetAllUsers()
        {
            var users = _userService.GetAllUsers().ToList();
            if (!ModelState.IsValid)
                return BadRequest();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> GetUsers(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
                return NotFound("No User Registered with supplied ID");
            else
                return Ok(user);
        }
        [HttpDelete]
        public async Task<int> DeleteUser(int id)
        {
            var data = _userService.DeleteUser(id);
            if (data == null)
                return 0;
            else
                return 1;
        }
    }
}
