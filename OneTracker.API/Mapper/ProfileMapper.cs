using AutoMapper;
using OneTracker.DataModel.Entities;
using OneTracker.ServiceModel.DTO.Response;

namespace OneTracker.API.Mapper
{
    public class ProfileMapper:Profile
    {
        public ProfileMapper()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<Ticket, TicketDTO>();
            CreateMap<TicketDTO, Ticket>();
        }
    }
}
