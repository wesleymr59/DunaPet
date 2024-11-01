using AutoMapper;
using DunaPet.App.Entities.DTO.Request.User;
using DunaPet.App.Entities.DTO.Response.User;
using DunaPet.App.Entities.MySQL;


namespace DunaPet.App.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Aqui você mapeia suas entidades para DTOs
            CreateMap<UserRequest, UserResponse>();
            CreateMap<User, UserResponse>();
        }
    }
}
