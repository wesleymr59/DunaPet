using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.DTO.Response.User
{
    public class UserResponse
    {
        public string Name { get; set; }

        public string? LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int TypeProfileId { get; set; }

        public string? Picture { get; set; }

        public string? City { get; set; }

        public string? PostalCode { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public bool Active { get; set; }
    }
}
