using DunaPet.App.Entities.DTO.Request.User;
using DunaPet.App.Entities.DTO.Response.User;
using DunaPet.App.Usecases.User;
using DunaPet.Infrastructure.Database.MySql.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

namespace DunaPet.App.Controllers.User
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserUsecase _userUseCase;
        public UserController(UserUsecase userUseCase)
        {
            _userUseCase = userUseCase;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser([FromBody] UserRequest userRequest)
        {
            try
            {
                var userResponse = await _userUseCase.CreateUser(userRequest);
                return Ok(userResponse);
            }
            catch (Exception ex)
            {
                // Retorne o erro apropriado
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                var userResponse = await _userUseCase.GetUserById(id);
                if (userResponse == null){
                    return NotFound();
                }
                return Ok(userResponse);
            }
            catch (Exception ex)
            {
                // Retorne o erro apropriado
                return BadRequest(ex.Message);
            }
        }
    }
}
