using AutoMapper;
using DunaPet.App.Entities.DTO.Request.User;
using DunaPet.App.Entities.DTO.Response.User;
using DunaPet.App.Entities.MySQL;
using DunaPet.App.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pet.Infrastructure.Data.Config;
using DunaPet.App.Entities.MySQL;

namespace DunaPet.Infrastructure.Database.MySql.Repositories.Users
{
    public class UserRepository: IUser
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserResponse> CreateUser(UserRequest userRequest)
        {
            var typeProfileExists = await _context.TypeProfile.AnyAsync(tp => tp.Id == userRequest.TypeProfileId);
            if (!typeProfileExists)
            {
                throw new Exception("TypeProfile Invalid!");
            }

            var createUser = new User
            {
                Name = userRequest.Name,
                LastName = userRequest.LastName,
                Username = userRequest.Username,
                Password = userRequest.Password,
                Email = userRequest.Email,
                TypeProfileId = userRequest.TypeProfileId,
                Picture = userRequest.Picture,
                City = userRequest.City,
                PostalCode = userRequest.PostalCode,
                State = userRequest.State,
                Country = userRequest.Country,
                UpdatedAt = DateTime.UtcNow,
                Active = true

            };
            await _context.AddAsync(createUser);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserResponse>(userRequest);
        }

        public async Task<UserResponse> GetUserById(int id)
        {
            var user = await _context.User.Where(x => x.Active && x.Id == id).ToListAsync();
            return _mapper.Map<UserResponse>(user); ;
        }
    }
}
