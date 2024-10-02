using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.MySQL
{
    [Table("Users")]
    public class User
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string Name { get; set; }

            [MaxLength(100)]
            public string? LastName { get; set; }

            [Required]
            [MaxLength(100)]
            public string Username { get; set; }

            [Required]
            [MaxLength(100)]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [MaxLength(100)]
            public string Password { get; set; }

            [Required]
            public int TypeProfileId { get; set; }

            [MaxLength(900)]
            public string? Picture { get; set; }

            [MaxLength(100)]
            public string? City { get; set; }

            [MaxLength(100)]
            public string? PostalCode { get; set; }

            [MaxLength(100)]
            public string? State { get; set; }

            [MaxLength(100)]
            public string? Country { get; set; }

            [Required]
            public DateTime UpdatedAt { get; set; } = DateTime.Now;

            [Required]
            public bool Active { get; set; }

            // Foreign Key Relationship
            [ForeignKey("TypeProfileId")]
            public virtual TypeProfile TypeProfile { get; set; }

            // Construtor padrão
            public User() { }

            // Construtor personalizado
            public User(string name, string username, string email, string password, int typeProfileId)
            {
                Name = name;
                Username = username;
                Email = email;
                Password = password;
                TypeProfileId = typeProfileId;
                Active = true;
            }
        }
    }
