using DunaPet.App.Entities.DTO.Request.User;
using DunaPet.App.Entities.DTO.Response.User;
using DunaPet.App.Entities.HealthyCheck;
using DunaPet.App.Interfaces.HealthyCheck;
using DunaPet.App.Interfaces.User;
using DunaPet.App.Utils;
using System.Security.Cryptography.X509Certificates;

namespace DunaPet.App.Usecases.User
{
    public class UserUsecase
    {
        private readonly IUser _userInterface;
        private readonly Crypt _crypt;

        public UserUsecase(IUser user, Crypt crypt)
        {
            _userInterface = user;
            _crypt = crypt;
        }

        public Task<UserResponse> CreateUser(UserRequest userRequest)
        {
            var hasedPasswd = _crypt.HashPasswd(userRequest.Password);
            userRequest.Password = hasedPasswd;
            return _userInterface.CreateUser(userRequest);

        }

        public Task<UserResponse> GetUserById(int id){
            return _userInterface.GetUserById(id);
        }
    }
}
