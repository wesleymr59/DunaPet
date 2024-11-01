using DunaPet.App.Entities.DTO.Request.User;
using DunaPet.App.Entities.DTO.Response.User;
using DunaPet.App.Entities.HealthyCheck;
using Microsoft.AspNetCore.Mvc;

namespace DunaPet.App.Interfaces.User
{
    public interface IUser
    {
        Task<UserResponse> CreateUser(UserRequest userRequest);
        Task<UserResponse> GetUserById(int id);
    }
}
