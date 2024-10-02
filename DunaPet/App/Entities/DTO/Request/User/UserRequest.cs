using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.DTO.Request.User
{
    public class UserRequest
    {
        public required string Name { get; set; }

        public string? LastName { get; set; }

        public required string Username { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public int TypeProfileId { get; set; }

        public string? Picture { get; set; }

        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }
    }
}
